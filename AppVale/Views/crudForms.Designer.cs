namespace AppVale.Views
{
    partial class FrmCrudForms
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtData = new System.Windows.Forms.TextBox();
            this.lblData = new System.Windows.Forms.Label();
            this.gbDadosSubmit = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtPortNumber = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtSmtpAdress = new System.Windows.Forms.TextBox();
            this.lblSmtpAdress = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.dgEMailSubmit = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gbDadosSubmit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailSubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(26, 46);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(617, 20);
            this.txtData.TabIndex = 0;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.lblData.Location = new System.Drawing.Point(26, 27);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(35, 13);
            this.lblData.TabIndex = 1;
            this.lblData.Text = "label1";
            // 
            // gbDadosSubmit
            // 
            this.gbDadosSubmit.Controls.Add(this.btnSubmit);
            this.gbDadosSubmit.Controls.Add(this.txtPortNumber);
            this.gbDadosSubmit.Controls.Add(this.lblPorta);
            this.gbDadosSubmit.Controls.Add(this.txtSmtpAdress);
            this.gbDadosSubmit.Controls.Add(this.lblSmtpAdress);
            this.gbDadosSubmit.Controls.Add(this.lblSenha);
            this.gbDadosSubmit.Controls.Add(this.txtSenha);
            this.gbDadosSubmit.Controls.Add(this.lblData);
            this.gbDadosSubmit.Controls.Add(this.txtData);
            this.gbDadosSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.gbDadosSubmit.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.gbDadosSubmit.Location = new System.Drawing.Point(60, 35);
            this.gbDadosSubmit.Name = "gbDadosSubmit";
            this.gbDadosSubmit.Size = new System.Drawing.Size(659, 225);
            this.gbDadosSubmit.TabIndex = 2;
            this.gbDadosSubmit.TabStop = false;
            this.gbDadosSubmit.Text = "Dados";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(257, 159);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Cadastrar";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtPortNumber
            // 
            this.txtPortNumber.Location = new System.Drawing.Point(467, 109);
            this.txtPortNumber.Name = "txtPortNumber";
            this.txtPortNumber.Size = new System.Drawing.Size(176, 20);
            this.txtPortNumber.TabIndex = 7;
            this.txtPortNumber.Visible = false;
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.lblPorta.Location = new System.Drawing.Point(464, 93);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(32, 13);
            this.lblPorta.TabIndex = 6;
            this.lblPorta.Text = "Porta";
            this.lblPorta.Visible = false;
            // 
            // txtSmtpAdress
            // 
            this.txtSmtpAdress.Location = new System.Drawing.Point(232, 109);
            this.txtSmtpAdress.Name = "txtSmtpAdress";
            this.txtSmtpAdress.Size = new System.Drawing.Size(211, 20);
            this.txtSmtpAdress.TabIndex = 5;
            this.txtSmtpAdress.Visible = false;
            // 
            // lblSmtpAdress
            // 
            this.lblSmtpAdress.AutoSize = true;
            this.lblSmtpAdress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.lblSmtpAdress.Location = new System.Drawing.Point(229, 93);
            this.lblSmtpAdress.Name = "lblSmtpAdress";
            this.lblSmtpAdress.Size = new System.Drawing.Size(78, 13);
            this.lblSmtpAdress.TabIndex = 4;
            this.lblSmtpAdress.Text = "Endereço smtp";
            this.lblSmtpAdress.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.lblSenha.Location = new System.Drawing.Point(26, 93);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            this.lblSenha.Visible = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(29, 109);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.Visible = false;
            // 
            // dgEMailSubmit
            // 
            this.dgEMailSubmit.AllowUserToAddRows = false;
            this.dgEMailSubmit.AllowUserToDeleteRows = false;
            this.dgEMailSubmit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEMailSubmit.Location = new System.Drawing.Point(60, 266);
            this.dgEMailSubmit.Name = "dgEMailSubmit";
            this.dgEMailSubmit.ReadOnly = true;
            this.dgEMailSubmit.RowHeadersWidth = 51;
            this.dgEMailSubmit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEMailSubmit.Size = new System.Drawing.Size(659, 150);
            this.dgEMailSubmit.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(52)))), ((int)(((byte)(139)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDelete.Location = new System.Drawing.Point(69, 422);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(127, 42);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmCrudForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgEMailSubmit);
            this.Controls.Add(this.gbDadosSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmCrudForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudForms";
            this.Load += new System.EventHandler(this.FrmCrudForms_Load);
            this.gbDadosSubmit.ResumeLayout(false);
            this.gbDadosSubmit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEMailSubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.GroupBox gbDadosSubmit;
        private System.Windows.Forms.DataGridView dgEMailSubmit;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSmtpAdress;
        private System.Windows.Forms.Label lblSmtpAdress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtPortNumber;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.Button btnDelete;
    }
}