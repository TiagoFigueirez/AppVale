using AppVale.Model;
using AppVale.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;

namespace AppVale.Repository
{
    internal class SubmitEMail : ISubmitEMail
    { 
        private readonly IEMailForSubmit _EMailForSubmit;
        private readonly IEMailToRecipients _EmailToRecipients;

        public SubmitEMail() 
        {
            _EMailForSubmit = new EmailForSubmit();
            _EmailToRecipients = new EMailToRecipients();
        }
        public string EMailBody(PedidoModel _pedidoModel, AngiodroidOrBombaModel _agioOrBombaModel, List<ProdutoModel> produtos)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"<p><strong>Número: </strong>{_pedidoModel.Guid.ToUpper()}</p>");
            sb.AppendLine($"<p><strong>Hospital: </strong>{_pedidoModel.Hospital}</p>");
            sb.AppendLine($"<p><strong>Médico: </strong>{_pedidoModel.Medico}</p>");
            sb.AppendLine($"<p><strong>Paciente: </strong>{_pedidoModel.Paciente}</p>");
            sb.AppendLine($"<p><strong>Vendedor: </strong>{_pedidoModel.Vendedor}</p>");
            sb.AppendLine($"<p><strong>Data da cirugia: </strong>{_pedidoModel.DataCirugia}</p>");

            sb.AppendLine("<table border´='1' style='width: 100%'>");
            sb.AppendLine("<tr>");
            sb.AppendLine($"<th style:='padding: 8px;'text-align: center;>Código do Produto</th>");
            sb.AppendLine($"<th style:='padding: 8px;'text-align: center;>Lote</th>");
            sb.AppendLine($"<th style:='padding: 8px;'text-align: center;>Data de Validade</th>");
            sb.AppendLine($"<th style:='padding: 8px;'text-align: center;>Quantidade</th>");
            sb.AppendLine("</tr");

            if (_agioOrBombaModel != null)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{_agioOrBombaModel.NameItem}</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{_agioOrBombaModel.Lote}</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>Não possui</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>1</td>");
                sb.AppendLine("</tr>");
            }

            for(int i = 0; i < produtos.Count; i++)
            {
                sb.AppendLine("<tr>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{produtos[i].CodigoProduto}</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{produtos[i].Lote}</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{produtos[i].DataValidade}</td>");
                sb.AppendLine($"<td style:='padding: 8px;'text-align: center;>{produtos[i].Quantidade}</td>");
                sb.AppendLine("</tr>");
            }

            return sb.ToString();   
        }

        public bool SubmEMail(List<string> emails, string eMailBody, PedidoModel _PedidoModel)
        {
            string[] eMailForSubmit = _EMailForSubmit.Get($@"{
                                            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}EmailForSubmit.txt");

            string[] eMailToRecipients = _EmailToRecipients.Get($@"{
                                                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}EmailForSubmit.txt");

            if (eMailForSubmit == null || eMailToRecipients == null)
            {
                return false;
            }

            //pegando os dados do e-mail que envia e divindo onde tem espaço
            string[] dataEmailForSubmit = eMailForSubmit[0].Split(' ');

            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(dataEmailForSubmit[0], $"{_PedidoModel.Vendedor} {DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy")}");

                 foreach(var Email in eMailToRecipients)
                {
                    mail.To.Add(Email);
                }

                mail.Subject = $"Vale: {_PedidoModel.Guid.ToUpper()}";
                mail.Body = eMailBody;
                mail.IsBodyHtml = true;

                using (SmtpClient smtp = new SmtpClient(dataEmailForSubmit[2], Convert.ToInt16(dataEmailForSubmit[3])))
                {
                    try
                    {
                        smtp.Credentials = new NetworkCredential(eMailForSubmit[0], eMailForSubmit[1]);
                        smtp.EnableSsl = true;
                        smtp.Send(mail);

                        return true;
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }
    }
}
