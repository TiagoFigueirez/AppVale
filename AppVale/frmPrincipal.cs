using AppVale.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using AppVale.Views;

namespace AppVale
{
    public partial class frmPrincipal : Form
    {
        public string codigo;
        public bool lendoCodigoDeBarras = false;
        public int contador = 1;
        public string DiretorioSelecionado;
        PedidoModel _pedidoModel = new PedidoModel();
        AngiodroidOrBombaModel _angiodroidOrBombaModel = new AngiodroidOrBombaModel();
        public List<ProdutoModel> produtos = new List<ProdutoModel>();

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnConfirmarDados_Click(object sender, EventArgs e)
        {
            Guid numeroVale = Guid.NewGuid();

            _pedidoModel.Guid = numeroVale.ToString().Substring(0, 10);
            _pedidoModel.Hospital = txtHospital.Text;
            _pedidoModel.Medico = txtMedico.Text;
            _pedidoModel.Convenio = txtConvenio.Text;
            _pedidoModel.Paciente = txtPaciente.Text;
            _pedidoModel.Vendedor = cbVendedor.Text;
            _pedidoModel.DataCirugia = mskDataCirugia.Text;

            if (VerificarEntrada(_pedidoModel, _angiodroidOrBombaModel))
            {

                txtHospital.Enabled = false;
                txtMedico.Enabled = false;
                txtPaciente.Enabled = false;
                txtHospital.Enabled = false;
                txtConvenio.Enabled = false;
                cbVendedor.Enabled = false;
                cbAngiodroidBomba.Enabled = false;
                cbAngiodroidBomba.Enabled = false;
                rbAngiodroid.Enabled = false;
                rbBomba.Enabled = false;
                rbNaoPossui.Enabled = false;
                btnConfirmarDados.Enabled = false;
                mskDataCirugia.Enabled = false;

                txtLerProduto.Enabled = true;
                btnEnviarVale.Enabled = true;
                btnCancelar.Enabled = true;
                btnDeletar.Enabled = true;
                dgvProduto.Enabled = true;
                txtLerProduto.Focus();

            }
            else
            {
                return;
            }

        }

        private async void txtLerProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            codigo += e.KeyChar;

            if (!lendoCodigoDeBarras)
            {
                lendoCodigoDeBarras = true;

                await LerCodigoBarras();
            }
        }

        private void btnEnviarVale_Click(object sender, EventArgs e)
        {
            
            Environment.Exit(0);
            Application.Restart();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgvProduto.SelectedCells.Count > 0)
            {
                int contador = Convert.ToInt32(dgvProduto.SelectedCells[0].Value);

                ProdutoModel produtoExcluido = produtos.Find(p => p.Contador == contador);

                DialogResult confirmarExclusao = MessageBox.Show("Deseja realmente exclui o produto da contagem ?", "atenção",
                                                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmarExclusao == DialogResult.Yes)
                {
                    produtos.Remove(produtoExcluido);
                    txtLerProduto.Focus();

                    RenumerarContador();

                    LimparGridView();
                    CarregarGridView();

                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtHospital.Enabled = true;
            txtMedico.Enabled = true;
            txtPaciente.Enabled = true;
            txtHospital.Enabled = true;
            txtConvenio.Enabled = true;
            cbVendedor.Enabled = true;
            cbAngiodroidBomba.Enabled = true;
            rbAngiodroid.Enabled = true;
            rbBomba.Enabled = true;
            rbNaoPossui.Enabled = true;
            btnConfirmarDados.Enabled = true;
            mskDataCirugia.Enabled = true;

            txtLerProduto.Enabled = false;
            txtLerProduto.Enabled = false;
            btnEnviarVale.Enabled = false;
            btnCancelar.Enabled = false;
            btnDeletar.Enabled = false;
            dgvProduto.Enabled = false;
            txtHospital.Focus();
        }

        private void rbNaoPossui_CheckedChanged(object sender, EventArgs e)
        {
            cbAngiodroidBomba.Visible = false;
            cbAngiodroidBomba.Text = string.Empty;
        }

        private void rbAngiodroid_CheckedChanged(object sender, EventArgs e)
        {
            cbAngiodroidBomba.Items.Clear();
            cbAngiodroidBomba.Visible = true;

            cbAngiodroidBomba.Items.Add(new AngiodroidOrBombaModel { NameItem = "ANG-CO2-0003", Lote = "AH-0317" });
         
        }

        private void rbBomba_CheckedChanged(object sender, EventArgs e)
        {
            cbAngiodroidBomba.Items.Clear();
            cbAngiodroidBomba.Visible = true;

            cbAngiodroidBomba.Items.Add(new AngiodroidOrBombaModel { NameItem = "PMXENGN", Lote = "S10413-55" });
            cbAngiodroidBomba.Items.Add(new AngiodroidOrBombaModel { NameItem = "PMXENGN", Lote = "S10413-60" });
            cbAngiodroidBomba.Items.Add(new AngiodroidOrBombaModel { NameItem = "PMXENGN", Lote = "S10435-01" });

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            rbNaoPossui.Checked = true;
        }

        private void cbAngiodroidBomba_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbAngiodroidBomba.SelectedItem is AngiodroidOrBombaModel selectedItem)
            {
                _angiodroidOrBombaModel.NameItem = selectedItem.NameItem;
                _angiodroidOrBombaModel.Lote = selectedItem.Lote;
            }
        }
        //FIM DOS EVENTOS DOS BOTÕES

        private async Task LerCodigoBarras()
        {
            int tempoLimite = 1000;

            await Task.Delay(tempoLimite);
            AdicionarProduto(codigo);

            codigo = "";
            txtLerProduto.Clear();
            lendoCodigoDeBarras = false;
        }

        private void AdicionarProduto(string produto)
        {
            string[] produtoDivido = produto.Split(' ');

            ProdutoModel _produtoModel = new ProdutoModel();

            try
            {
                _produtoModel.CodigoProduto = produtoDivido[0];
                _produtoModel.Lote = produtoDivido[1];
                _produtoModel.DataValidade = produtoDivido[2];

                if (_produtoModel.DataValidade.Length > 7)
                {
                    MessageBox.Show("Entrada inválida, tente novamente", "atenção");
                    return;
                }

                ProdutoModel verificarProdutoExistente = produtos.FirstOrDefault(p => p.CodigoProduto == _produtoModel.CodigoProduto
                                                                                 && p.Lote == _produtoModel.Lote);
                if (verificarProdutoExistente != null)
                {
                    verificarProdutoExistente.Quantidade++;
                    LimparGridView();
                    CarregarGridView();

                }
                else
                {
                    _produtoModel.Contador = contador;
                    _produtoModel.Quantidade = 1;

                    produtos.Add(_produtoModel);

                    LimparGridView();
                    CarregarGridView();
                    ++contador;
                }
            }
            catch
            {
                txtLerProduto.Text = null;
                MessageBox.Show("Falha ao ler o codigo, tente novamente", "Atenção");
                return;
            }

        }

        private bool VerificarEntrada(PedidoModel _pedidoModel, AngiodroidOrBombaModel _angiodroidOrBombaModel)
        {
            if (_pedidoModel.Hospital == "")
            {
                MessageBox.Show("Informe o Hospital!", "Atenção");
                return false;
            }
            else if (_pedidoModel.Medico == "")
            {
                MessageBox.Show("Informe o médico", "Atenção");
                return false;
            }
            else if (_pedidoModel.Paciente == "")
            {
                MessageBox.Show("Informe o paciente", "Atenção");
                return false;
            }
            else if (_pedidoModel.Vendedor == "")
            {
                MessageBox.Show("Informe o vendedor", "Atenção");
                return false;
            }
            else if (_pedidoModel.DataCirugia == "")
            {
                MessageBox.Show("Informe a data da cirugia", "Atenção");
                return false;
            }
            else if(_pedidoModel.Convenio == "")
            {
                MessageBox.Show("Informe o convênio", "Atenção");
                return false;
            }
            else if (rbNaoPossui.Checked == false && cbAngiodroidBomba.Text == "")
            {
                MessageBox.Show("Informe o lote do angiodroid ou da bomba", "Atenção");
                return false;
            }
            else
            {
                return true;
            }

        }

        private void LimparGridView()
        {
            dgvProduto.Rows.Clear();
        }

        private void CarregarGridView()
        {
            int ultimaLinha;

            foreach (var produtosGrid in produtos)
            {
                dgvProduto.Rows.Add(produtosGrid.Contador, produtosGrid.CodigoProduto, produtosGrid.Lote, produtosGrid.DataValidade, produtosGrid.Quantidade);
            }

            ultimaLinha = dgvProduto.Rows.Count - 1;

            if (ultimaLinha > 0)
            {
                dgvProduto.FirstDisplayedScrollingRowIndex = ultimaLinha;
                dgvProduto.Rows[ultimaLinha].Selected = true;
                dgvProduto.CurrentCell = dgvProduto.Rows[ultimaLinha].Cells[0];
            }
        }

        private void RenumerarContador()
        {
            int contador = 0;

            foreach (var produto in produtos)
            {
                produto.Contador = ++contador;
            }
            ProdutoModel PegarUltimoContador = produtos[produtos.Count - 1];

            this.contador = PegarUltimoContador.Contador;
            this.contador++;
        }
       
        private void emailDeEnvioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudForms frmCrudForms = new FrmCrudForms(1);
            frmCrudForms.ShowDialog();
        }

        private void emailsRecebedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudForms frmCrudForms = new FrmCrudForms(2);
            frmCrudForms.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrudForms frmCrudForms = new FrmCrudForms(3);
            frmCrudForms.ShowDialog();
        }
    }
}
