using AppVale.Model;
using DocumentFormat.OpenXml.Wordprocessing;
using System.Collections.Generic;

namespace AppVale.Repository.Interface
{
    public interface IDocFormat
    {
        Paragraph CreateParagraph(string text, double fontesize, bool isBold = false, 
                                  bool SpacingBetweenLines = false, JustificationValues? justification = null);
        Table CreateTable(List<ProdutoModel> produtos, AngiodroidOrBombaModel _angiodroidOrBombaModel);
        TableCell CreateCell(string text, bool isBold = false);
       

    }
}
