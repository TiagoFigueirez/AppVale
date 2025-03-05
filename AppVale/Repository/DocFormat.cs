using AppVale.Model;
using AppVale.Repository.Interface;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;

namespace AppVale.Repository
{
    public class DocFormat : IDocFormat
    {
        public TableCell CreateCell(string text, bool isBold = false)
        {
            TableCell cell = new TableCell();
            Paragraph paragraphCell = CreateParagraph(text, 12 ,isBold);
            cell.Append(paragraphCell);
            return cell;
        }

        public Paragraph CreateParagraph(string text, double fontesize, bool isBold = false,
                                         bool SpacingBetweenLines = false, JustificationValues? justification = null)
        {
            //cria o texto no word com run e passa as propriedades do texto
            Run _run = new Run(new Text(text));
            RunProperties _runProperties = new RunProperties();
            _runProperties.FontSize = new FontSize() { Val = (fontesize * 2).ToString() };

            if (isBold)
            {
                _runProperties.Append(new RunProperties(new Bold()));
            }
            _run.RunProperties = _runProperties;

            //criando o paragrafo e passando o texto dele
            Paragraph _paragraph = new Paragraph(_run);

            //definindo propriedades do paragrafo
            ParagraphProperties _paragraphProperties = new ParagraphProperties();

            if(SpacingBetweenLines)
            {
                _paragraphProperties.SpacingBetweenLines = new SpacingBetweenLines()
                {
                    Before = "0",
                    After = "0",
                    Line = (400 * 1).ToString(),
                    LineRule = LineSpacingRuleValues.Auto
                };
            }

            if (justification.HasValue)
            {
               _paragraphProperties.Justification = new Justification() { Val = justification.Value };
            }

            _paragraph.ParagraphProperties = _paragraphProperties;

            return _paragraph;
        }

        public Table CreateTable(List<ProdutoModel> produtos, AngiodroidOrBombaModel _angiodroidOrBombaModel)
        {
            Table _table = new Table();

            //cria as linhas divisorias da tabela
            TableProperties _tableProperties = new TableProperties(new TableWidth() { Width = "5000", Type = TableWidthUnitValues.Pct },
                new TableBorders(
                    new TopBorder() { Val = BorderValues.Single, Size = 4 },
                    new BottomBorder() { Val = BorderValues.Single, Size = 4 },
                    new LeftBorder() { Val = BorderValues.Single, Size = 4 },
                    new RightBorder() { Val = BorderValues.Single, Size = 4 },
                    new InsideHorizontalBorder() { Val = BorderValues.Single, Size = 4 },
                    new InsideVerticalBorder() { Val = BorderValues.Single, Size = 4 }
                    )
            );

            //adcionando propriedades da tabela
            _table.AppendChild(_tableProperties);

            //criando o cabeçalho
            TableRow harderRow = new TableRow();
            harderRow.Append(CreateCell("Referência", true));
            harderRow.Append(CreateCell("Lote", true));
            harderRow.Append(CreateCell("Data de validade", true));
            harderRow.Append(CreateCell("Quantidade", true));
            _table.AppendChild(_tableProperties);

            //criando linhas
            for(int i = 0; i < produtos.Count; i++)
            {
                TableRow row = new TableRow();
                row.Append(CreateCell(produtos[i].CodigoProduto.ToString()));
                row.Append(CreateCell(produtos[i].Lote.ToString()));
                row.Append(CreateCell(produtos[i].DataValidade.ToString()));
                row.Append(CreateCell(produtos[i].Quantidade.ToString()));
                _table.AppendChild(_tableProperties);
            }

            if(_angiodroidOrBombaModel.Lote != null)
            {
                TableRow rowAngioBomba = new TableRow();
                rowAngioBomba.Append(CreateCell(_angiodroidOrBombaModel.NameItem));
                rowAngioBomba.Append(CreateCell(_angiodroidOrBombaModel.NameItem));
                rowAngioBomba.Append(CreateCell("Não possui"));
                rowAngioBomba.Append(CreateCell("1"));
                _table.Append(rowAngioBomba);
            }

            return _table;
        }


    }
}
