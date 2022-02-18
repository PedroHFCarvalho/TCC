namespace PIM.UI.Motorista
{
    partial class frmInicioMotorista
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
			this.btnIncluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgMotorista = new System.Windows.Forms.DataGridView();
			this.plManterFuncionario = new System.Windows.Forms.Panel();
			this.lblVeicAtual = new System.Windows.Forms.Label();
			this.lblCnh = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.lblSalario = new System.Windows.Forms.Label();
			this.lblCargo = new System.Windows.Forms.Label();
			this.lblRg = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblAcesso = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMotorista)).BeginInit();
			this.plManterFuncionario.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLocalizar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.btnIncluir);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Controls.Add(this.dgMotorista);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 6;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Location = new System.Drawing.Point(372, 12);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btnLocalizar.TabIndex = 13;
			this.btnLocalizar.Text = "Localizar";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(232, 14);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(132, 20);
			this.txtLocalizar.TabIndex = 12;
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(137, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Localizar por RG:";
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
			// dgMotorista
			// 
			this.dgMotorista.AllowUserToAddRows = false;
			this.dgMotorista.AllowUserToDeleteRows = false;
			this.dgMotorista.AllowUserToResizeColumns = false;
			this.dgMotorista.AllowUserToResizeRows = false;
			this.dgMotorista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgMotorista.BackgroundColor = System.Drawing.Color.White;
			this.dgMotorista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMotorista.Location = new System.Drawing.Point(12, 41);
			this.dgMotorista.MultiSelect = false;
			this.dgMotorista.Name = "dgMotorista";
			this.dgMotorista.ReadOnly = true;
			this.dgMotorista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMotorista.Size = new System.Drawing.Size(435, 342);
			this.dgMotorista.TabIndex = 0;
			this.dgMotorista.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMotorista_CellClick);
			this.dgMotorista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMotorista_CellDoubleClick);
			// 
			// plManterFuncionario
			// 
			this.plManterFuncionario.Controls.Add(this.lblVeicAtual);
			this.plManterFuncionario.Controls.Add(this.lblCnh);
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
			this.plManterFuncionario.TabIndex = 7;
			// 
			// lblVeicAtual
			// 
			this.lblVeicAtual.AutoSize = true;
			this.lblVeicAtual.Location = new System.Drawing.Point(6, 311);
			this.lblVeicAtual.Name = "lblVeicAtual";
			this.lblVeicAtual.Size = new System.Drawing.Size(86, 13);
			this.lblVeicAtual.TabIndex = 136;
			this.lblVeicAtual.Text = "ID Veiculo Atual:";
			// 
			// lblCnh
			// 
			this.lblCnh.AutoSize = true;
			this.lblCnh.Location = new System.Drawing.Point(7, 246);
			this.lblCnh.Name = "lblCnh";
			this.lblCnh.Size = new System.Drawing.Size(33, 13);
			this.lblCnh.TabIndex = 134;
			this.lblCnh.Text = "CNH:";
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(7, 224);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(56, 13);
			this.lblEndereco.TabIndex = 125;
			this.lblEndereco.Text = "Endereço:";
			// 
			// lblSalario
			// 
			this.lblSalario.AutoSize = true;
			this.lblSalario.Location = new System.Drawing.Point(7, 201);
			this.lblSalario.Name = "lblSalario";
			this.lblSalario.Size = new System.Drawing.Size(44, 13);
			this.lblSalario.TabIndex = 124;
			this.lblSalario.Text = "Salalrio:";
			// 
			// lblCargo
			// 
			this.lblCargo.AutoSize = true;
			this.lblCargo.Location = new System.Drawing.Point(7, 178);
			this.lblCargo.Name = "lblCargo";
			this.lblCargo.Size = new System.Drawing.Size(38, 13);
			this.lblCargo.TabIndex = 123;
			this.lblCargo.Text = "Cargo:";
			// 
			// lblRg
			// 
			this.lblRg.AutoSize = true;
			this.lblRg.Location = new System.Drawing.Point(7, 156);
			this.lblRg.Name = "lblRg";
			this.lblRg.Size = new System.Drawing.Size(26, 13);
			this.lblRg.TabIndex = 122;
			this.lblRg.Text = "RG:";
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(7, 134);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(30, 13);
			this.lblCPF.TabIndex = 121;
			this.lblCPF.Text = "CPF:";
			// 
			// lblAcesso
			// 
			this.lblAcesso.AutoSize = true;
			this.lblAcesso.Location = new System.Drawing.Point(7, 112);
			this.lblAcesso.Name = "lblAcesso";
			this.lblAcesso.Size = new System.Drawing.Size(45, 13);
			this.lblAcesso.TabIndex = 116;
			this.lblAcesso.Text = "Acesso:";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(7, 89);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 115;
			this.lblSenha.Text = "Senha:";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(7, 67);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 114;
			this.lblLogin.Text = "Login:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(7, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 113;
			this.lblNome.Text = "Nome:";
			// 
			// frmInicioMotorista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterFuncionario);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInicioMotorista";
			this.Text = "InicioMotorista";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgMotorista)).EndInit();
			this.plManterFuncionario.ResumeLayout(false);
			this.plManterFuncionario.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgMotorista;
        private System.Windows.Forms.Panel plManterFuncionario;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblVeicAtual;
		private System.Windows.Forms.Label lblCnh;
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