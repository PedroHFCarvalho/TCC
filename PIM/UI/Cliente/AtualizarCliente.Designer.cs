namespace PIM.UI.Cliente
{
    partial class frmAtualizarCliente
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
			this.plEditar = new System.Windows.Forms.Panel();
			this.btnFecharEdit = new System.Windows.Forms.Button();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.txtCpf = new System.Windows.Forms.TextBox();
			this.txtRg = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblkExcluir = new System.Windows.Forms.LinkLabel();
			this.lblEnderecoEX = new System.Windows.Forms.Label();
			this.lblRgEX = new System.Windows.Forms.Label();
			this.lblCpfEX = new System.Windows.Forms.Label();
			this.lblIdEX = new System.Windows.Forms.Label();
			this.lblEndereco = new System.Windows.Forms.Label();
			this.lblRg = new System.Windows.Forms.Label();
			this.lblCPF = new System.Windows.Forms.Label();
			this.lblSenhaEX = new System.Windows.Forms.Label();
			this.lblLoginEX = new System.Windows.Forms.Label();
			this.lblNomeEX = new System.Windows.Forms.Label();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblkEditar = new System.Windows.Forms.LinkLabel();
			this.dgContratoR = new System.Windows.Forms.DataGridView();
			this.lblkVeisculosR = new System.Windows.Forms.LinkLabel();
			this.lblkAddVeiculo = new System.Windows.Forms.LinkLabel();
			this.plEditar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratoR)).BeginInit();
			this.SuspendLayout();
			// 
			// plEditar
			// 
			this.plEditar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plEditar.Controls.Add(this.btnFecharEdit);
			this.plEditar.Controls.Add(this.btnAtualizar);
			this.plEditar.Controls.Add(this.label10);
			this.plEditar.Controls.Add(this.label1);
			this.plEditar.Controls.Add(this.txtNome);
			this.plEditar.Controls.Add(this.txtLogin);
			this.plEditar.Controls.Add(this.txtSenha);
			this.plEditar.Controls.Add(this.label4);
			this.plEditar.Controls.Add(this.label5);
			this.plEditar.Controls.Add(this.txtCpf);
			this.plEditar.Controls.Add(this.txtRg);
			this.plEditar.Controls.Add(this.label7);
			this.plEditar.Controls.Add(this.label8);
			this.plEditar.Controls.Add(this.txtEndereco);
			this.plEditar.Controls.Add(this.label9);
			this.plEditar.Location = new System.Drawing.Point(176, 9);
			this.plEditar.Name = "plEditar";
			this.plEditar.Size = new System.Drawing.Size(287, 216);
			this.plEditar.TabIndex = 80;
			// 
			// btnFecharEdit
			// 
			this.btnFecharEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFecharEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFecharEdit.Location = new System.Drawing.Point(264, 3);
			this.btnFecharEdit.Name = "btnFecharEdit";
			this.btnFecharEdit.Size = new System.Drawing.Size(18, 25);
			this.btnFecharEdit.TabIndex = 88;
			this.btnFecharEdit.Text = "X";
			this.btnFecharEdit.UseVisualStyleBackColor = true;
			this.btnFecharEdit.Click += new System.EventHandler(this.btnFecharEdit_Click);
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.Color.White;
			this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizar.Location = new System.Drawing.Point(194, 180);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 60;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(22, 14);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 18);
			this.label10.TabIndex = 59;
			this.label10.Text = "Editar";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(22, 157);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 58;
			this.label1.Text = "Endereço:";
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(81, 41);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(188, 20);
			this.txtNome.TabIndex = 13;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(81, 63);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(188, 20);
			this.txtLogin.TabIndex = 14;
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(81, 85);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(188, 20);
			this.txtSenha.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(22, 133);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(26, 13);
			this.label4.TabIndex = 55;
			this.label4.Text = "RG:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(22, 111);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(30, 13);
			this.label5.TabIndex = 54;
			this.label5.Text = "CPF:";
			// 
			// txtCpf
			// 
			this.txtCpf.Location = new System.Drawing.Point(81, 108);
			this.txtCpf.Name = "txtCpf";
			this.txtCpf.Size = new System.Drawing.Size(188, 20);
			this.txtCpf.TabIndex = 37;
			// 
			// txtRg
			// 
			this.txtRg.Location = new System.Drawing.Point(81, 130);
			this.txtRg.Name = "txtRg";
			this.txtRg.Size = new System.Drawing.Size(188, 20);
			this.txtRg.TabIndex = 38;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(22, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(41, 13);
			this.label7.TabIndex = 52;
			this.label7.Text = "Senha:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(22, 66);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(36, 13);
			this.label8.TabIndex = 51;
			this.label8.Text = "Login:";
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(81, 154);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(188, 20);
			this.txtEndereco.TabIndex = 47;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(22, 44);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 50;
			this.label9.Text = "Nome:";
			// 
			// lblkExcluir
			// 
			this.lblkExcluir.AutoSize = true;
			this.lblkExcluir.Location = new System.Drawing.Point(94, 9);
			this.lblkExcluir.Name = "lblkExcluir";
			this.lblkExcluir.Size = new System.Drawing.Size(38, 13);
			this.lblkExcluir.TabIndex = 79;
			this.lblkExcluir.TabStop = true;
			this.lblkExcluir.Text = "Excluir";
			this.lblkExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkExcluir_LinkClicked);
			// 
			// lblEnderecoEX
			// 
			this.lblEnderecoEX.AutoSize = true;
			this.lblEnderecoEX.Location = new System.Drawing.Point(73, 153);
			this.lblEnderecoEX.Name = "lblEnderecoEX";
			this.lblEnderecoEX.Size = new System.Drawing.Size(77, 13);
			this.lblEnderecoEX.TabIndex = 78;
			this.lblEnderecoEX.Text = "lblEnderecoEX";
			// 
			// lblRgEX
			// 
			this.lblRgEX.AutoSize = true;
			this.lblRgEX.Location = new System.Drawing.Point(74, 133);
			this.lblRgEX.Name = "lblRgEX";
			this.lblRgEX.Size = new System.Drawing.Size(45, 13);
			this.lblRgEX.TabIndex = 75;
			this.lblRgEX.Text = "lblRgEX";
			// 
			// lblCpfEX
			// 
			this.lblCpfEX.AutoSize = true;
			this.lblCpfEX.Location = new System.Drawing.Point(74, 111);
			this.lblCpfEX.Name = "lblCpfEX";
			this.lblCpfEX.Size = new System.Drawing.Size(47, 13);
			this.lblCpfEX.TabIndex = 74;
			this.lblCpfEX.Text = "lblCpfEX";
			// 
			// lblIdEX
			// 
			this.lblIdEX.AutoSize = true;
			this.lblIdEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdEX.Location = new System.Drawing.Point(12, 9);
			this.lblIdEX.Name = "lblIdEX";
			this.lblIdEX.Size = new System.Drawing.Size(60, 20);
			this.lblIdEX.TabIndex = 73;
			this.lblIdEX.Text = "lblIdEX";
			// 
			// lblEndereco
			// 
			this.lblEndereco.AutoSize = true;
			this.lblEndereco.Location = new System.Drawing.Point(13, 153);
			this.lblEndereco.Name = "lblEndereco";
			this.lblEndereco.Size = new System.Drawing.Size(56, 13);
			this.lblEndereco.TabIndex = 72;
			this.lblEndereco.Text = "Endereço:";
			// 
			// lblRg
			// 
			this.lblRg.AutoSize = true;
			this.lblRg.Location = new System.Drawing.Point(14, 133);
			this.lblRg.Name = "lblRg";
			this.lblRg.Size = new System.Drawing.Size(26, 13);
			this.lblRg.TabIndex = 69;
			this.lblRg.Text = "RG:";
			// 
			// lblCPF
			// 
			this.lblCPF.AutoSize = true;
			this.lblCPF.Location = new System.Drawing.Point(14, 111);
			this.lblCPF.Name = "lblCPF";
			this.lblCPF.Size = new System.Drawing.Size(30, 13);
			this.lblCPF.TabIndex = 68;
			this.lblCPF.Text = "CPF:";
			// 
			// lblSenhaEX
			// 
			this.lblSenhaEX.AutoSize = true;
			this.lblSenhaEX.Location = new System.Drawing.Point(73, 89);
			this.lblSenhaEX.Name = "lblSenhaEX";
			this.lblSenhaEX.Size = new System.Drawing.Size(62, 13);
			this.lblSenhaEX.TabIndex = 66;
			this.lblSenhaEX.Text = "lblSenhaEX";
			// 
			// lblLoginEX
			// 
			this.lblLoginEX.AutoSize = true;
			this.lblLoginEX.Location = new System.Drawing.Point(73, 67);
			this.lblLoginEX.Name = "lblLoginEX";
			this.lblLoginEX.Size = new System.Drawing.Size(57, 13);
			this.lblLoginEX.TabIndex = 65;
			this.lblLoginEX.Text = "lblLoginEX";
			// 
			// lblNomeEX
			// 
			this.lblNomeEX.AutoSize = true;
			this.lblNomeEX.Location = new System.Drawing.Point(73, 45);
			this.lblNomeEX.Name = "lblNomeEX";
			this.lblNomeEX.Size = new System.Drawing.Size(59, 13);
			this.lblNomeEX.TabIndex = 64;
			this.lblNomeEX.Text = "lblNomeEX";
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(13, 89);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 62;
			this.lblSenha.Text = "Senha:";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(13, 67);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 61;
			this.lblLogin.Text = "Login:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(13, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 60;
			this.lblNome.Text = "Nome:";
			// 
			// lblkEditar
			// 
			this.lblkEditar.AutoSize = true;
			this.lblkEditar.Location = new System.Drawing.Point(13, 180);
			this.lblkEditar.Name = "lblkEditar";
			this.lblkEditar.Size = new System.Drawing.Size(34, 13);
			this.lblkEditar.TabIndex = 85;
			this.lblkEditar.TabStop = true;
			this.lblkEditar.Text = "Editar";
			this.lblkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkEditar_LinkClicked);
			// 
			// dgContratoR
			// 
			this.dgContratoR.AllowUserToAddRows = false;
			this.dgContratoR.AllowUserToDeleteRows = false;
			this.dgContratoR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgContratoR.BackgroundColor = System.Drawing.Color.White;
			this.dgContratoR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgContratoR.Location = new System.Drawing.Point(16, 235);
			this.dgContratoR.MultiSelect = false;
			this.dgContratoR.Name = "dgContratoR";
			this.dgContratoR.ReadOnly = true;
			this.dgContratoR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgContratoR.Size = new System.Drawing.Size(447, 150);
			this.dgContratoR.TabIndex = 83;
			// 
			// lblkVeisculosR
			// 
			this.lblkVeisculosR.AutoSize = true;
			this.lblkVeisculosR.Location = new System.Drawing.Point(14, 212);
			this.lblkVeisculosR.Name = "lblkVeisculosR";
			this.lblkVeisculosR.Size = new System.Drawing.Size(115, 13);
			this.lblkVeisculosR.TabIndex = 86;
			this.lblkVeisculosR.TabStop = true;
			this.lblkVeisculosR.Text = "Contrato Relacionados";
			// 
			// lblkAddVeiculo
			// 
			this.lblkAddVeiculo.AutoSize = true;
			this.lblkAddVeiculo.Location = new System.Drawing.Point(14, 388);
			this.lblkAddVeiculo.Name = "lblkAddVeiculo";
			this.lblkAddVeiculo.Size = new System.Drawing.Size(94, 13);
			this.lblkAddVeiculo.TabIndex = 87;
			this.lblkAddVeiculo.TabStop = true;
			this.lblkAddVeiculo.Text = "Adicionar Contrato";
			this.lblkAddVeiculo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkAddVeiculo_LinkClicked);
			// 
			// frmAtualizarCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(478, 423);
			this.Controls.Add(this.lblkAddVeiculo);
			this.Controls.Add(this.lblkVeisculosR);
			this.Controls.Add(this.dgContratoR);
			this.Controls.Add(this.lblkEditar);
			this.Controls.Add(this.plEditar);
			this.Controls.Add(this.lblkExcluir);
			this.Controls.Add(this.lblEnderecoEX);
			this.Controls.Add(this.lblRgEX);
			this.Controls.Add(this.lblCpfEX);
			this.Controls.Add(this.lblIdEX);
			this.Controls.Add(this.lblEndereco);
			this.Controls.Add(this.lblRg);
			this.Controls.Add(this.lblCPF);
			this.Controls.Add(this.lblSenhaEX);
			this.Controls.Add(this.lblLoginEX);
			this.Controls.Add(this.lblNomeEX);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAtualizarCliente";
			this.Text = "AtualizarCliente";
			this.plEditar.ResumeLayout(false);
			this.plEditar.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratoR)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plEditar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCpf;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.LinkLabel lblkExcluir;
        private System.Windows.Forms.Label lblEnderecoEX;
        private System.Windows.Forms.Label lblRgEX;
        private System.Windows.Forms.Label lblCpfEX;
        private System.Windows.Forms.Label lblIdEX;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSenhaEX;
        private System.Windows.Forms.Label lblLoginEX;
        private System.Windows.Forms.Label lblNomeEX;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.LinkLabel lblkEditar;
        private System.Windows.Forms.DataGridView dgContratoR;
        private System.Windows.Forms.LinkLabel lblkVeisculosR;
        private System.Windows.Forms.LinkLabel lblkAddVeiculo;
        private System.Windows.Forms.Button btnFecharEdit;
    }
}