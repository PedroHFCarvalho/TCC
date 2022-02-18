namespace PIM.UI.Funcionario
{
    partial class frmInicioGerente
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
			this.dgFuncionario = new System.Windows.Forms.DataGridView();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.plManterFuncionario = new System.Windows.Forms.Panel();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblRg = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblAcesso = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).BeginInit();
			this.panel1.SuspendLayout();
			this.plManterFuncionario.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgFuncionario
			// 
			this.dgFuncionario.AllowUserToAddRows = false;
			this.dgFuncionario.AllowUserToDeleteRows = false;
			this.dgFuncionario.AllowUserToResizeColumns = false;
			this.dgFuncionario.AllowUserToResizeRows = false;
			this.dgFuncionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgFuncionario.BackgroundColor = System.Drawing.Color.White;
			this.dgFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgFuncionario.Location = new System.Drawing.Point(12, 41);
			this.dgFuncionario.MultiSelect = false;
			this.dgFuncionario.Name = "dgFuncionario";
			this.dgFuncionario.ReadOnly = true;
			this.dgFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgFuncionario.Size = new System.Drawing.Size(435, 342);
			this.dgFuncionario.TabIndex = 0;
			this.dgFuncionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionario_CellClick);
			this.dgFuncionario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFuncionario_CellDoubleClick);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLocalizar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.btnIncluir);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Controls.Add(this.dgFuncionario);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 5;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Location = new System.Drawing.Point(372, 12);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btnLocalizar.TabIndex = 10;
			this.btnLocalizar.Text = "Localizar";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(232, 14);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(132, 20);
			this.txtLocalizar.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Localizar por RG:";
			// 
			// plManterFuncionario
			// 
			this.plManterFuncionario.Controls.Add(this.lblEndereco);
			this.plManterFuncionario.Controls.Add(this.lblSalario);
			this.plManterFuncionario.Controls.Add(this.lblCargo);
			this.plManterFuncionario.Controls.Add(this.lblRg);
			this.plManterFuncionario.Controls.Add(this.lblCPF);
			this.plManterFuncionario.Controls.Add(this.lblAcesso);
			this.plManterFuncionario.Controls.Add(this.lblSenha);
			this.plManterFuncionario.Controls.Add(this.lblLogin);
			this.plManterFuncionario.Controls.Add(this.lblNome);
			this.plManterFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plManterFuncionario.Location = new System.Drawing.Point(476, 0);
			this.plManterFuncionario.Name = "plManterFuncionario";
			this.plManterFuncionario.Size = new System.Drawing.Size(478, 423);
			this.plManterFuncionario.TabIndex = 6;
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(7, 224);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(56, 13);
			this.lblEndereco.TabIndex = 98;
			this.lblEndereco.Text = "Endereço:";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Location = new System.Drawing.Point(7, 201);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.Size = new System.Drawing.Size(44, 13);
			this.lblSalario.TabIndex = 97;
			this.lblSalario.Text = "Salalrio:";
			// 
			// lblCargo
			// 
			this.lblCargo.AutoSize = true;
			this.lblCargo.Location = new System.Drawing.Point(7, 178);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(38, 13);
			this.lblCargo.TabIndex = 96;
			this.lblCargo.Text = "Cargo:";
			// 
			// lblRg
			// 
			this.lblRg.AutoSize = true;
			this.lblRg.Location = new System.Drawing.Point(7, 156);
			this.lblRg.Name = "lblRg";
			this.lblRg.Size = new System.Drawing.Size(26, 13);
			this.lblRg.TabIndex = 95;
			this.lblRg.Text = "RG:";
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(7, 134);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(30, 13);
			this.lblCPF.TabIndex = 94;
			this.lblCPF.Text = "CPF:";
			// 
			// lblAcesso
			// 
			this.lblAcesso.AutoSize = true;
			this.lblAcesso.Location = new System.Drawing.Point(7, 112);
			this.lblAcesso.Name = "lblAcesso";
			this.lblAcesso.Size = new System.Drawing.Size(45, 13);
			this.lblAcesso.TabIndex = 89;
			this.lblAcesso.Text = "Acesso:";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(7, 89);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 88;
			this.lblSenha.Text = "Senha:";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(7, 67);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 87;
			this.lblLogin.Text = "Login:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(7, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 86;
			this.lblNome.Text = "Nome:";
			// 
			// frmInicioGerente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterFuncionario);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInicioGerente";
			this.Text = "Gerente";
			this.Click += new System.EventHandler(this.frmInicioFuncionario_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgFuncionario)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plManterFuncionario.ResumeLayout(false);
			this.plManterFuncionario.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFuncionario;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plManterFuncionario;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblEndereco;
		private System.Windows.Forms.Label lblSalario;
		private System.Windows.Forms.Label lblCargo;
		private System.Windows.Forms.Label lblRg;
		private System.Windows.Forms.Label lblCPF;
		private System.Windows.Forms.Label lblAcesso;
		private System.Windows.Forms.Label lblSenha;
		private System.Windows.Forms.Label lblLogin;
		private System.Windows.Forms.Label lblNome;
	}
}