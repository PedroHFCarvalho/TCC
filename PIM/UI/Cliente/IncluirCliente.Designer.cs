namespace PIM.UI.Cliente
{
    partial class frmIncluirCliente
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncluirCliente));
			this.txtEndereco = new System.Windows.Forms.TextBox();
			this.txtRG = new System.Windows.Forms.TextBox();
			this.txtCPF = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.txtSenha = new System.Windows.Forms.TextBox();
			this.txtLogin = new System.Windows.Forms.TextBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblSenha = new System.Windows.Forms.Label();
			this.lblLogin = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtEndereco
			// 
			this.txtEndereco.Location = new System.Drawing.Point(96, 209);
			this.txtEndereco.Name = "txtEndereco";
			this.txtEndereco.Size = new System.Drawing.Size(301, 20);
			this.txtEndereco.TabIndex = 37;
			// 
			// txtRG
			// 
			this.txtRG.Location = new System.Drawing.Point(96, 170);
			this.txtRG.Name = "txtRG";
			this.txtRG.Size = new System.Drawing.Size(301, 20);
			this.txtRG.TabIndex = 34;
			// 
			// txtCPF
			// 
			this.txtCPF.Location = new System.Drawing.Point(96, 131);
			this.txtCPF.Name = "txtCPF";
			this.txtCPF.Size = new System.Drawing.Size(301, 20);
			this.txtCPF.TabIndex = 33;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(33, 212);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 30;
			this.label3.Text = "Endereço:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(33, 173);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(26, 13);
			this.label2.TabIndex = 29;
			this.label2.Text = "RG:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(33, 134);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 13);
			this.label1.TabIndex = 28;
			this.label1.Text = "CPF:";
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(391, 376);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 27;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// txtSenha
			// 
			this.txtSenha.Location = new System.Drawing.Point(96, 93);
			this.txtSenha.Name = "txtSenha";
			this.txtSenha.Size = new System.Drawing.Size(301, 20);
			this.txtSenha.TabIndex = 25;
			// 
			// txtLogin
			// 
			this.txtLogin.Location = new System.Drawing.Point(96, 59);
			this.txtLogin.Name = "txtLogin";
			this.txtLogin.Size = new System.Drawing.Size(301, 20);
			this.txtLogin.TabIndex = 24;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(96, 25);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(301, 20);
			this.txtNome.TabIndex = 23;
			// 
			// lblSenha
			// 
			this.lblSenha.AutoSize = true;
			this.lblSenha.Location = new System.Drawing.Point(33, 96);
			this.lblSenha.Name = "lblSenha";
			this.lblSenha.Size = new System.Drawing.Size(41, 13);
			this.lblSenha.TabIndex = 21;
			this.lblSenha.Text = "Senha:";
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(33, 62);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(36, 13);
			this.lblLogin.TabIndex = 20;
			this.lblLogin.Text = "Login:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(33, 28);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 19;
			this.lblNome.Text = "Nome:";
			// 
			// frmIncluirCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(478, 411);
			this.Controls.Add(this.txtEndereco);
			this.Controls.Add(this.txtRG);
			this.Controls.Add(this.txtCPF);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.txtSenha);
			this.Controls.Add(this.txtLogin);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lblSenha);
			this.Controls.Add(this.lblLogin);
			this.Controls.Add(this.lblNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmIncluirCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "IncluirCliente";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblNome;
    }
}