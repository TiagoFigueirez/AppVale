namespace AppVale
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtHospital = new System.Windows.Forms.TextBox();
            this.gbDadosPedido = new System.Windows.Forms.GroupBox();
            this.lblConvenio = new System.Windows.Forms.Label();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.lblDataCirugia = new System.Windows.Forms.Label();
            this.mskDataCirugia = new System.Windows.Forms.MaskedTextBox();
            this.rbNaoPossui = new System.Windows.Forms.RadioButton();
            this.rbBomba = new System.Windows.Forms.RadioButton();
            this.rbAngiodroid = new System.Windows.Forms.RadioButton();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.cbAngiodroidBomba = new System.Windows.Forms.ComboBox();
            this.btnConfirmarDados = new System.Windows.Forms.Button();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblPaciente = new System.Windows.Forms.Label();
            this.lblMedico = new System.Windows.Forms.Label();
            this.lblHospital = new System.Windows.Forms.Label();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.cbVendedor = new System.Windows.Forms.ComboBox();
            this.txtMedico = new System.Windows.Forms.TextBox();
            this.gbProduto = new System.Windows.Forms.GroupBox();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEnviarVale = new System.Windows.Forms.Button();
            this.lblLerProduto = new System.Windows.Forms.Label();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.Contagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Validade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLerProduto = new System.Windows.Forms.TextBox();
            this.msCrudData = new System.Windows.Forms.MenuStrip();
            this.emailDeEnvioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailsRecebedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbDadosPedido.SuspendLayout();
            this.gbProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.msCrudData.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHospital
            // 
            this.txtHospital.Location = new System.Drawing.Point(26, 49);
            this.txtHospital.Name = "txtHospital";
            this.txtHospital.Size = new System.Drawing.Size(247, 20);
            this.txtHospital.TabIndex = 0;
            // 
            // gbDadosPedido
            // 
            this.gbDadosPedido.Controls.Add(this.lblConvenio);
            this.gbDadosPedido.Controls.Add(this.txtConvenio);
            this.gbDadosPedido.Controls.Add(this.lblDataCirugia);
            this.gbDadosPedido.Controls.Add(this.mskDataCirugia);
            this.gbDadosPedido.Controls.Add(this.rbNaoPossui);
            this.gbDadosPedido.Controls.Add(this.rbBomba);
            this.gbDadosPedido.Controls.Add(this.rbAngiodroid);
            this.gbDadosPedido.Controls.Add(this.lblSelecione);
            this.gbDadosPedido.Controls.Add(this.cbAngiodroidBomba);
            this.gbDadosPedido.Controls.Add(this.btnConfirmarDados);
            this.gbDadosPedido.Controls.Add(this.lblVendedor);
            this.gbDadosPedido.Controls.Add(this.lblPaciente);
            this.gbDadosPedido.Controls.Add(this.lblMedico);
            this.gbDadosPedido.Controls.Add(this.lblHospital);
            this.gbDadosPedido.Controls.Add(this.txtPaciente);
            this.gbDadosPedido.Controls.Add(this.cbVendedor);
            this.gbDadosPedido.Controls.Add(this.txtMedico);
            this.gbDadosPedido.Controls.Add(this.txtHospital);
            this.gbDadosPedido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.gbDadosPedido.Location = new System.Drawing.Point(54, 43);
            this.gbDadosPedido.Name = "gbDadosPedido";
            this.gbDadosPedido.Size = new System.Drawing.Size(690, 297);
            this.gbDadosPedido.TabIndex = 1;
            this.gbDadosPedido.TabStop = false;
            this.gbDadosPedido.Text = "Dados do pedido";
            // 
            // lblConvenio
            // 
            this.lblConvenio.AutoSize = true;
            this.lblConvenio.Location = new System.Drawing.Point(308, 29);
            this.lblConvenio.Name = "lblConvenio";
            this.lblConvenio.Size = new System.Drawing.Size(52, 13);
            this.lblConvenio.TabIndex = 18;
            this.lblConvenio.Text = "Convênio";
            // 
            // txtConvenio
            // 
            this.txtConvenio.Location = new System.Drawing.Point(308, 49);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.Size = new System.Drawing.Size(144, 20);
            this.txtConvenio.TabIndex = 1;
            // 
            // lblDataCirugia
            // 
            this.lblDataCirugia.AutoSize = true;
            this.lblDataCirugia.Location = new System.Drawing.Point(319, 87);
            this.lblDataCirugia.Name = "lblDataCirugia";
            this.lblDataCirugia.Size = new System.Drawing.Size(79, 13);
            this.lblDataCirugia.TabIndex = 16;
            this.lblDataCirugia.Text = "Data da cirugia";
            // 
            // mskDataCirugia
            // 
            this.mskDataCirugia.Location = new System.Drawing.Point(322, 104);
            this.mskDataCirugia.Mask = "00/00/0000";
            this.mskDataCirugia.Name = "mskDataCirugia";
            this.mskDataCirugia.Size = new System.Drawing.Size(130, 20);
            this.mskDataCirugia.TabIndex = 4;
            this.mskDataCirugia.ValidatingType = typeof(System.DateTime);
            // 
            // rbNaoPossui
            // 
            this.rbNaoPossui.AutoSize = true;
            this.rbNaoPossui.Location = new System.Drawing.Point(182, 160);
            this.rbNaoPossui.Name = "rbNaoPossui";
            this.rbNaoPossui.Size = new System.Drawing.Size(78, 17);
            this.rbNaoPossui.TabIndex = 6;
            this.rbNaoPossui.TabStop = true;
            this.rbNaoPossui.Text = "Não possui";
            this.rbNaoPossui.UseVisualStyleBackColor = true;
            this.rbNaoPossui.CheckedChanged += new System.EventHandler(this.rbNaoPossui_CheckedChanged);
            // 
            // rbBomba
            // 
            this.rbBomba.AutoSize = true;
            this.rbBomba.Location = new System.Drawing.Point(182, 221);
            this.rbBomba.Name = "rbBomba";
            this.rbBomba.Size = new System.Drawing.Size(58, 17);
            this.rbBomba.TabIndex = 8;
            this.rbBomba.TabStop = true;
            this.rbBomba.Text = "Bomba";
            this.rbBomba.UseVisualStyleBackColor = true;
            this.rbBomba.CheckedChanged += new System.EventHandler(this.rbBomba_CheckedChanged);
            // 
            // rbAngiodroid
            // 
            this.rbAngiodroid.AutoSize = true;
            this.rbAngiodroid.Location = new System.Drawing.Point(182, 190);
            this.rbAngiodroid.Name = "rbAngiodroid";
            this.rbAngiodroid.Size = new System.Drawing.Size(75, 17);
            this.rbAngiodroid.TabIndex = 7;
            this.rbAngiodroid.TabStop = true;
            this.rbAngiodroid.Text = "Angiodroid";
            this.rbAngiodroid.UseVisualStyleBackColor = true;
            this.rbAngiodroid.CheckedChanged += new System.EventHandler(this.rbAngiodroid_CheckedChanged);
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Location = new System.Drawing.Point(26, 140);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(57, 13);
            this.lblSelecione.TabIndex = 11;
            this.lblSelecione.Text = "Selecione:";
            this.lblSelecione.Visible = false;
            // 
            // cbAngiodroidBomba
            // 
            this.cbAngiodroidBomba.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAngiodroidBomba.FormattingEnabled = true;
            this.cbAngiodroidBomba.Items.AddRange(new object[] {
            "Angiodroid",
            "Bomba Penumbra"});
            this.cbAngiodroidBomba.Location = new System.Drawing.Point(26, 159);
            this.cbAngiodroidBomba.Name = "cbAngiodroidBomba";
            this.cbAngiodroidBomba.Size = new System.Drawing.Size(121, 21);
            this.cbAngiodroidBomba.TabIndex = 6;
            this.cbAngiodroidBomba.Visible = false;
            this.cbAngiodroidBomba.SelectedIndexChanged += new System.EventHandler(this.cbAngiodroidBomba_SelectedIndexChanged);
            // 
            // btnConfirmarDados
            // 
            this.btnConfirmarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnConfirmarDados.FlatAppearance.BorderSize = 0;
            this.btnConfirmarDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmarDados.ForeColor = System.Drawing.Color.White;
            this.btnConfirmarDados.Location = new System.Drawing.Point(269, 250);
            this.btnConfirmarDados.Name = "btnConfirmarDados";
            this.btnConfirmarDados.Size = new System.Drawing.Size(101, 41);
            this.btnConfirmarDados.TabIndex = 8;
            this.btnConfirmarDados.Text = "Travar";
            this.btnConfirmarDados.UseVisualStyleBackColor = false;
            this.btnConfirmarDados.Click += new System.EventHandler(this.btnConfirmarDados_Click);
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(509, 87);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(53, 13);
            this.lblVendedor.TabIndex = 7;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblPaciente
            // 
            this.lblPaciente.AutoSize = true;
            this.lblPaciente.Location = new System.Drawing.Point(26, 87);
            this.lblPaciente.Name = "lblPaciente";
            this.lblPaciente.Size = new System.Drawing.Size(49, 13);
            this.lblPaciente.TabIndex = 6;
            this.lblPaciente.Text = "Paciente";
            // 
            // lblMedico
            // 
            this.lblMedico.AutoSize = true;
            this.lblMedico.Location = new System.Drawing.Point(475, 30);
            this.lblMedico.Name = "lblMedico";
            this.lblMedico.Size = new System.Drawing.Size(42, 13);
            this.lblMedico.TabIndex = 5;
            this.lblMedico.Text = "Médico";
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Location = new System.Drawing.Point(26, 30);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(45, 13);
            this.lblHospital.TabIndex = 4;
            this.lblHospital.Text = "Hospital";
            // 
            // txtPaciente
            // 
            this.txtPaciente.Location = new System.Drawing.Point(26, 103);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(247, 20);
            this.txtPaciente.TabIndex = 3;
            // 
            // cbVendedor
            // 
            this.cbVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVendedor.FormattingEnabled = true;
            this.cbVendedor.Items.AddRange(new object[] {
            "Aurora Dalpin",
            "Felipe Nisen",
            "Hugor Dalpin"});
            this.cbVendedor.Location = new System.Drawing.Point(512, 103);
            this.cbVendedor.Name = "cbVendedor";
            this.cbVendedor.Size = new System.Drawing.Size(121, 21);
            this.cbVendedor.TabIndex = 5;
            // 
            // txtMedico
            // 
            this.txtMedico.Location = new System.Drawing.Point(478, 49);
            this.txtMedico.Name = "txtMedico";
            this.txtMedico.Size = new System.Drawing.Size(169, 20);
            this.txtMedico.TabIndex = 2;
            // 
            // gbProduto
            // 
            this.gbProduto.Controls.Add(this.btnDeletar);
            this.gbProduto.Controls.Add(this.btnCancelar);
            this.gbProduto.Controls.Add(this.btnEnviarVale);
            this.gbProduto.Controls.Add(this.lblLerProduto);
            this.gbProduto.Controls.Add(this.dgvProduto);
            this.gbProduto.Controls.Add(this.txtLerProduto);
            this.gbProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.gbProduto.Location = new System.Drawing.Point(54, 359);
            this.gbProduto.Name = "gbProduto";
            this.gbProduto.Size = new System.Drawing.Size(690, 286);
            this.gbProduto.TabIndex = 2;
            this.gbProduto.TabStop = false;
            this.gbProduto.Text = "Produtos";
            // 
            // btnDeletar
            // 
            this.btnDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnDeletar.Enabled = false;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.ForeColor = System.Drawing.Color.White;
            this.btnDeletar.Location = new System.Drawing.Point(324, 237);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(115, 41);
            this.btnDeletar.TabIndex = 11;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(461, 237);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 41);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEnviarVale
            // 
            this.btnEnviarVale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnEnviarVale.Enabled = false;
            this.btnEnviarVale.FlatAppearance.BorderSize = 0;
            this.btnEnviarVale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarVale.ForeColor = System.Drawing.Color.White;
            this.btnEnviarVale.Location = new System.Drawing.Point(182, 237);
            this.btnEnviarVale.Name = "btnEnviarVale";
            this.btnEnviarVale.Size = new System.Drawing.Size(115, 41);
            this.btnEnviarVale.TabIndex = 9;
            this.btnEnviarVale.Text = "Enviar Vale";
            this.btnEnviarVale.UseVisualStyleBackColor = false;
            this.btnEnviarVale.Click += new System.EventHandler(this.btnEnviarVale_Click);
            // 
            // lblLerProduto
            // 
            this.lblLerProduto.AutoSize = true;
            this.lblLerProduto.Location = new System.Drawing.Point(237, 16);
            this.lblLerProduto.Name = "lblLerProduto";
            this.lblLerProduto.Size = new System.Drawing.Size(185, 13);
            this.lblLerProduto.TabIndex = 2;
            this.lblLerProduto.Text = "Leia o codigo com o cursor no campo";
            // 
            // dgvProduto
            // 
            this.dgvProduto.AllowUserToAddRows = false;
            this.dgvProduto.AllowUserToDeleteRows = false;
            this.dgvProduto.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contagem,
            this.Produto,
            this.Lote,
            this.Validade,
            this.Quantidade});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduto.Enabled = false;
            this.dgvProduto.Location = new System.Drawing.Point(68, 71);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProduto.Size = new System.Drawing.Size(590, 150);
            this.dgvProduto.TabIndex = 1;
            // 
            // Contagem
            // 
            this.Contagem.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.Contagem.DefaultCellStyle = dataGridViewCellStyle2;
            this.Contagem.HeaderText = "Contagem";
            this.Contagem.Name = "Contagem";
            this.Contagem.ReadOnly = true;
            // 
            // Produto
            // 
            this.Produto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Produto.HeaderText = "Produto";
            this.Produto.Name = "Produto";
            this.Produto.ReadOnly = true;
            // 
            // Lote
            // 
            this.Lote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            this.Lote.ReadOnly = true;
            // 
            // Validade
            // 
            this.Validade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Validade.HeaderText = "Validade";
            this.Validade.Name = "Validade";
            this.Validade.ReadOnly = true;
            this.Validade.Width = 81;
            // 
            // Quantidade
            // 
            this.Quantidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // txtLerProduto
            // 
            this.txtLerProduto.Enabled = false;
            this.txtLerProduto.Location = new System.Drawing.Point(124, 32);
            this.txtLerProduto.Name = "txtLerProduto";
            this.txtLerProduto.Size = new System.Drawing.Size(425, 20);
            this.txtLerProduto.TabIndex = 0;
            this.txtLerProduto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLerProduto_KeyPress);
            // 
            // msCrudData
            // 
            this.msCrudData.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailDeEnvioToolStripMenuItem,
            this.emailsRecebedoresToolStripMenuItem,
            this.vendedoresToolStripMenuItem});
            this.msCrudData.Location = new System.Drawing.Point(0, 0);
            this.msCrudData.Name = "msCrudData";
            this.msCrudData.Size = new System.Drawing.Size(800, 24);
            this.msCrudData.TabIndex = 3;
            this.msCrudData.Text = "menuStrip1";
            // 
            // emailDeEnvioToolStripMenuItem
            // 
            this.emailDeEnvioToolStripMenuItem.Name = "emailDeEnvioToolStripMenuItem";
            this.emailDeEnvioToolStripMenuItem.Size = new System.Drawing.Size(96, 20);
            this.emailDeEnvioToolStripMenuItem.Text = "Email de envio";
            this.emailDeEnvioToolStripMenuItem.Click += new System.EventHandler(this.emailDeEnvioToolStripMenuItem_Click);
            // 
            // emailsRecebedoresToolStripMenuItem
            // 
            this.emailsRecebedoresToolStripMenuItem.Name = "emailsRecebedoresToolStripMenuItem";
            this.emailsRecebedoresToolStripMenuItem.Size = new System.Drawing.Size(120, 20);
            this.emailsRecebedoresToolStripMenuItem.Text = "Emails recebedores";
            this.emailsRecebedoresToolStripMenuItem.Click += new System.EventHandler(this.emailsRecebedoresToolStripMenuItem_Click);
            // 
            // vendedoresToolStripMenuItem
            // 
            this.vendedoresToolStripMenuItem.Name = "vendedoresToolStripMenuItem";
            this.vendedoresToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.vendedoresToolStripMenuItem.Text = "Vendedores";
            this.vendedoresToolStripMenuItem.Click += new System.EventHandler(this.vendedoresToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.gbProduto);
            this.Controls.Add(this.gbDadosPedido);
            this.Controls.Add(this.msCrudData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msCrudData;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vale";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.gbDadosPedido.ResumeLayout(false);
            this.gbDadosPedido.PerformLayout();
            this.gbProduto.ResumeLayout(false);
            this.gbProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.msCrudData.ResumeLayout(false);
            this.msCrudData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHospital;
        private System.Windows.Forms.GroupBox gbDadosPedido;
        private System.Windows.Forms.TextBox txtMedico;
        private System.Windows.Forms.ComboBox cbVendedor;
        private System.Windows.Forms.TextBox txtPaciente;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblPaciente;
        private System.Windows.Forms.Label lblMedico;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Button btnConfirmarDados;
        private System.Windows.Forms.GroupBox gbProduto;
        private System.Windows.Forms.Label lblLerProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtLerProduto;
        private System.Windows.Forms.Button btnEnviarVale;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Produto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.DataGridViewTextBoxColumn Validade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.ComboBox cbAngiodroidBomba;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.RadioButton rbNaoPossui;
        private System.Windows.Forms.RadioButton rbBomba;
        private System.Windows.Forms.RadioButton rbAngiodroid;
        private System.Windows.Forms.MaskedTextBox mskDataCirugia;
        private System.Windows.Forms.Label lblDataCirugia;
        private System.Windows.Forms.Label lblConvenio;
        private System.Windows.Forms.TextBox txtConvenio;
        private System.Windows.Forms.MenuStrip msCrudData;
        private System.Windows.Forms.ToolStripMenuItem emailDeEnvioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailsRecebedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendedoresToolStripMenuItem;
    }
}

