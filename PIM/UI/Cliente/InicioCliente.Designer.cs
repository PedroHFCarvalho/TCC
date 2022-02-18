namespace PIM.UI.Cliente
{
    partial class frmInicioCliente
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgCliente = new System.Windows.Forms.DataGridView();
			this.plManterCliente = new System.Windows.Forms.Panel();
			this.dgContratoR = new System.Windows.Forms.DataGridView();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.lblRg = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).BeginInit();
			this.plManterCliente.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratoR)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLocalizar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnIncluir);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Controls.Add(this.dgCliente);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 8;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Location = new System.Drawing.Point(372, 13);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btnLocalizar.TabIndex = 7;
			this.btnLocalizar.Text = "Localizar";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(264, 15);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(100, 20);
			this.txtLocalizar.TabIndex = 6;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Localizar por ID:";
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(12, 12);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 1;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizar.Location = new System.Drawing.Point(12, 389);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(94, 23);
			this.btnAtualizar.TabIndex = 4;
			this.btnAtualizar.Text = "Atualizar Lista";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// dgCliente
			// 
			this.dgCliente.AllowUserToAddRows = false;
			this.dgCliente.AllowUserToDeleteRows = false;
			this.dgCliente.AllowUserToResizeColumns = false;
			this.dgCliente.AllowUserToResizeRows = false;
			this.dgCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgCliente.BackgroundColor = System.Drawing.Color.White;
			this.dgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgCliente.Location = new System.Drawing.Point(12, 41);
			this.dgCliente.MultiSelect = false;
			this.dgCliente.Name = "dgCliente";
			this.dgCliente.ReadOnly = true;
			this.dgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgCliente.Size = new System.Drawing.Size(435, 342);
			this.dgCliente.TabIndex = 0;
			this.dgCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellClick);
			this.dgCliente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCliente_CellDoubleClick);
			// 
			// plManterCliente
			// 
			this.plManterCliente.Controls.Add(this.dgContratoR);
			this.plManterCliente.Controls.Add(this.lblEndereco);
			this.plManterCliente.Controls.Add(this.lblRg);
			this.plManterCliente.Controls.Add(this.lblCPF);
			this.plManterCliente.Controls.Add(this.lblSenha);
			this.plManterCliente.Controls.Add(this.lblLogin);
			this.plManterCliente.Controls.Add(this.lblNome);
			this.plManterCliente.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plManterCliente.Location = new System.Drawing.Point(476, 0);
			this.plManterCliente.Name = "plManterCliente";
			this.plManterCliente.Size = new System.Drawing.Size(478, 423);
			this.plManterCliente.TabIndex = 9;
			// 
			// dgContratoR
			// 
			this.dgContratoR.AllowUserToAddRows = false;
			this.dgContratoR.AllowUserToDeleteRows = false;
			this.dgContratoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgContratoR.BackgroundColor = System.Drawing.Color.White;
			this.dgContratoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgContratoR.Location = new System.Drawing.Point(10, 235);
			this.dgContratoR.MultiSelect = false;
			this.dgContratoR.Name = "dgContratoR";
			this.dgContratoR.ReadOnly = true;
			this.dgContratoR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgContratoR.Size = new System.Drawing.Size(447, 150);
			this.dgContratoR.TabIndex = 102;
			this.dgContratoR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContratoR_CellContentClick);
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(7, 153);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(56, 13);
			this.lblEndereco.TabIndex = 96;
			this.lblEndereco.Text = "Endereço:";
			this.lblEndereco.Click += new System.EventHandler(this.lblEndereco_Click);
			// 
			// lblRg
			// 
			this.lblRg.AutoSize = true;
			this.lblRg.Location = new System.Drawing.Point(8, 133);
			this.lblRg.Name = "lblRg";
			this.lblRg.Size = new System.Drawing.Size(26, 13);
			this.lblRg.TabIndex = 95;
			this.lblRg.Text = "RG:";
			this.lblRg.Click += new System.EventHandler(this.lblRg_Click);
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(8, 111);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(30, 13);
			this.lblCPF.TabIndex = 94;
			this.lblCPF.Text = "CPF:";
			this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(7, 89);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 90;
			this.lblSenha.Text = "Senha:";
			this.lblSenha.Click += new System.EventHandler(this.lblSenha_Click);
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(7, 67);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 89;
			this.lblLogin.Text = "Login:";
			this.lblLogin.Click += new System.EventHandler(this.lblLogin_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(7, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 88;
			this.lblNome.Text = "Nome:";
			this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
			// 
			// frmInicioCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterCliente);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInicioCliente";
			this.Text = "InicioCliente";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgCliente)).EndInit();
			this.plManterCliente.ResumeLayout(false);
			this.plManterCliente.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratoR)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgCliente;
        private System.Windows.Forms.Panel plManterCliente;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgContratoR;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.Label lblRg;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblNome;
	}
}