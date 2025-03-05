using AppVale.Repository;
using AppVale.Repository.Interface;
using System;
using System.Windows.Forms;

namespace AppVale.Views
{
    public partial class FrmCrudForms : Form
    {
        private readonly int typeForm;
        private readonly IEMailForSubmit _EMailSubmit;
        private readonly IEMailToRecipients _EMailToRecipients;
        private readonly IVendedor _Vendedor;

        public FrmCrudForms(int typeForm)
        {
            this.typeForm = typeForm;
            _EMailSubmit = new EmailForSubmit();
            _EMailToRecipients = new EMailToRecipients();
            _Vendedor = new Vendedor();
            InitializeComponent();
        }

        private void FrmCrudForms_Load(object sender, System.EventArgs e)
        {
            string filePath;

            if (typeForm == 1)
            {
                lblSenha.Visible = true;
                lblPorta.Visible = true;
                lblSmtpAdress.Visible = true;
                lblData.Text = "E-mail de envio";

                txtSenha.Visible = true;
                txtSmtpAdress.Visible = true;
                txtPortNumber.Visible = true;
                this.Text = "E-mail de envio";

                filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForSubmit.txt";

                var  data = _EMailSubmit.GetEspecific(filePath);

                dgEMailSubmit.DataSource = data;
                FormatGridView(dgEMailSubmit);

                if (dgEMailSubmit.Rows.Count > 0)
                {
                    dgEMailSubmit.CellFormatting += DgEMailSubmit_CellFormatting;
                }


            }
            else if (typeForm == 2)
            {
                lblData.Text = "E-mail de Recebimento";
                Text = "E-mail de recebimento";

                filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForRecipients.txt";

                var data = _EMailToRecipients.GetEspecific(filePath);

                dgEMailSubmit.DataSource = data;
                FormatGridView(dgEMailSubmit);

               
            }else if(typeForm == 3)
            {
                lblData.Text = "Vendedor";
                Text = "Vendedores";

                filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Vendedor.txt";

                var data = _Vendedor.GetEspecific(filePath);

                dgEMailSubmit.DataSource = data;
                FormatGridView(dgEMailSubmit);
            }
        }

        private void btnSubmit_Click(object sender, System.EventArgs e)
        {
            if (typeForm == 1)
            {
                bool sucessCrud;
                string eMail = txtData.Text;
                string senha = txtSenha.Text;
                string smtpAdress = txtSmtpAdress.Text;
                string portNumber = txtPortNumber.Text;

                if (VerificationNullInputs())
                {
                    sucessCrud = _EMailSubmit.FormatCreate(eMail, senha, smtpAdress, portNumber);

                    if (sucessCrud)
                    {
                        MessageBox.Show("E-mail Cadastrado !");

                        var data = _EMailSubmit.GetEspecific($@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForSubmit.txt");
                        dgEMailSubmit.DataSource = data;
                    }
                    else
                    {
                        MessageBox.Show("Não foi póssível realizar o cadastro verifique se ja existe um e-mail de envio, caso exista exclua e cadastre o novo");
                    }

                }
                else
                {
                    MessageBox.Show("Dados em branco !");
                }              

            }else if(typeForm == 2)
            {
                string eMail = txtData.Text;
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForRecipients.txt";

                if (VerificationNullInputs())
                {
                    bool sucessCrud = _EMailToRecipients.Create(eMail, filePath);

                    if (sucessCrud)
                    {
                        MessageBox.Show("E-mail Cadastrado !");

                        _EMailToRecipients.GetEspecific(filePath);

                    }
                    else
                    {
                        MessageBox.Show("Não foi póssível realizar o cadastro");
                    }

                }
                else
                {
                    MessageBox.Show("Dados em branco !");
                }
            }else if(typeForm == 3)
            {
                string vendedor = txtData.Text;
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\Vendedor.txt";

                if (VerificationNullInputs())
                {
                    bool sucessCrud = _Vendedor.Create(vendedor, filePath);

                    if (sucessCrud)
                    {
                        MessageBox.Show("Vendedor Cadastrado !", "Sucesso");

                    }
                    else
                    {
                        MessageBox.Show("Não foi póssível realizar o cadastro");
                    }
                }
                else
                {
                    MessageBox.Show("Dados em branco !");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(typeForm == 1)
            {
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\EmailForSubmit.txt";
                string eMailForDelete = $@"{dgEMailSubmit.SelectedCells[0].Value}_{dgEMailSubmit.SelectedCells[1].Value}_{dgEMailSubmit.SelectedCells[2].Value}_" + 
                    $@"{dgEMailSubmit.SelectedCells[3].Value}";

                if(_EMailSubmit.Delete(filePath, eMailForDelete))
                {
                    MessageBox.Show("E-mail deletado !");
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar o e-mail");
                }             
            }else if(typeForm == 2)
            {
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\EmailForRecipients.txt";
                string eMailForDelete = $@"{dgEMailSubmit.SelectedCells[0].Value}";

                if (_EMailSubmit.Delete(filePath, eMailForDelete))
                {
                    MessageBox.Show("E-mail deletado !");
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar o e-mail");
                }
            }else if(typeForm == 3)
            {
                string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\\Vendedor.txt";
                string eMailForDelete = $@"{dgEMailSubmit.SelectedCells[0].Value}";

                if (_EMailSubmit.Delete(filePath, eMailForDelete))
                {
                    MessageBox.Show("Vendedor deletado !");
                }
                else
                {
                    MessageBox.Show("Não foi possivel deletar o Vendedor");
                }
            }
        }

        //FIM DOS EVENTOS DOS BOTÕES
        private void FormatGridView(DataGridView dgv)
        {
            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                dgv.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private bool VerificationNullInputs()
        {
            if ((txtData.Visible == true && txtData.Text == "") || (txtSenha.Visible == true && txtSenha.Text == "") ||
                (txtSmtpAdress.Visible == true && txtSmtpAdress.Text == "") || (txtPortNumber.Visible == true && txtPortNumber.Text == ""))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void DgEMailSubmit_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgEMailSubmit.Columns[e.ColumnIndex].Name == "Senha" && e.Value != null)
            {
                e.Value = new string('●', e.Value.ToString().Length);
                e.FormattingApplied = true;
            }
        }
    }
}
