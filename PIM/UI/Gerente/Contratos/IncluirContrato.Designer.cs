namespace PIM.UI.Gerente.Contratos
{
    partial class frmIncluirContrato
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
			this.btnIncluir = new System.Windows.Forms.Button();
			this.lblNome = new System.Windows.Forms.Label();
			this.cbPlano = new System.Windows.Forms.ComboBox();
			this.lblVagas = new System.Windows.Forms.Label();
			this.txtVagas = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(391, 376);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 17;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(33, 28);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 9;
			this.lblNome.Text = "Nome:";
			// 
			// cbPlano
			// 
			this.cbPlano.FormattingEnabled = true;
			this.cbPlano.Items.AddRange(new object[] {
            "10 Vagas",
            "20 Vagas",
            "30 Vagas",
            "Personalizado"});
			this.cbPlano.Location = new System.Drawing.Point(78, 28);
			this.cbPlano.Name = "cbPlano";
			this.cbPlano.Size = new System.Drawing.Size(121, 21);
			this.cbPlano.TabIndex = 18;
			this.cbPlano.Text = "Personalizado";
			this.cbPlano.SelectedIndexChanged += new System.EventHandler(this.cbPlano_SelectedIndexChanged);
			// 
			// lblVagas
			// 
			this.lblVagas.AutoSize = true;
			this.lblVagas.Location = new System.Drawing.Point(227, 31);
			this.lblVagas.Name = "lblVagas";
			this.lblVagas.Size = new System.Drawing.Size(90, 13);
			this.lblVagas.TabIndex = 19;
			this.lblVagas.Text = "Limites de Vagas:";
			// 
			// txtVagas
			// 
			this.txtVagas.Location = new System.Drawing.Point(323, 28);
			this.txtVagas.Name = "txtVagas";
			this.txtVagas.Size = new System.Drawing.Size(112, 20);
			this.txtVagas.TabIndex = 20;
			// 
			// frmIncluirContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(478, 411);
			this.Controls.Add(this.txtVagas);
			this.Controls.Add(this.lblVagas);
			this.Controls.Add(this.cbPlano);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.lblNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmIncluirContrato";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Contrato";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.ComboBox cbPlano;
		private System.Windows.Forms.Label lblVagas;
		private System.Windows.Forms.TextBox txtVagas;
	}
}