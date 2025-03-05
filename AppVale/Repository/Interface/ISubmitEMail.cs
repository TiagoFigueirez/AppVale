using AppVale.Model;
using System.Collections.Generic;

namespace AppVale.Repository
{
    public interface ISubmitEMail
    {
        string EMailBody(PedidoModel _pedidoModel, AngiodroidOrBombaModel _agioOrBombaModel, List<ProdutoModel> produtos);
        bool SubmEMail(List<string> emails, string eMailBody, PedidoModel _PedidoModel);

    }
}
