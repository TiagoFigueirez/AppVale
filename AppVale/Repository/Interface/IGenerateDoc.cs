using AppVale.Model;
using DocumentFormat.OpenXml.Drawing;
using System.Collections.Generic;

namespace AppVale.Repository.Interface
{
    public interface IGenerateDoc
    {
        string  GenerateDocument(PedidoModel pedido, List<ProdutoModel> produtos, AngiodroidOrBombaModel angioOnBomba);
    }
}
