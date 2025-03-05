using AppVale.Model;
using AppVale.Repository.Interface;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Packaging;

namespace AppVale.Repository
{
    public class GenerateDoc : IGenerateDoc
    {
        private readonly IDocFormat _docFormat;

        public GenerateDoc()
        {
            _docFormat = new DocFormat();
        }

        public string GenerateDocument(PedidoModel pedido, List<ProdutoModel> produtos, AngiodroidOrBombaModel angioOnBomba)
        {
            string modelDocument = @"C:\Users\thiago.paula\Desktop\AppVale - Refatorado\VALE.docx";
            string newDoc = @"C:\temp\Vale.docx";

            if (File.Exists(newDoc))
            {
                File.Delete(newDoc);
            }

            FileInfo _fileInfo = new FileInfo(modelDocument);
            _fileInfo.CopyTo(newDoc);

            using (WordprocessingDocument _wordProcessing = WordprocessingDocument.Open(newDoc, true))
            {
                MainDocumentPart _documentPart = _wordProcessing.MainDocumentPart;

                Body documentBody = _documentPart.Document.Body;

                documentBody.Append(_docFormat.CreateParagraph("Vale de entrega", 12, true, true, JustificationValues.Center));
                documentBody.Append(_docFormat.CreateParagraph($"Hospital: {pedido.Hospital}", 12, true, true));
                documentBody.Append(_docFormat.CreateParagraph($"Médico: {pedido.Medico}", 12, true, true));
                documentBody.Append(_docFormat.CreateParagraph($"Convênio: {pedido.Convenio}", 12, true, true));
                documentBody.Append(_docFormat.CreateParagraph($"Paciente: {pedido.Paciente}", 12, true, true));
                documentBody.Append(_docFormat.CreateParagraph($"Vendedor: {pedido.Vendedor}", 12, true, true));
                documentBody.Append(_docFormat.CreateParagraph($"Data da cirugia: {pedido.DataCirugia}", 12, true, true));

                var table = _docFormat.CreateTable(produtos, angioOnBomba);

                documentBody.Append(table);

                _documentPart.Document.Save();
            }

            return newDoc;
        }
    }
}
