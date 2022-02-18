namespace PIM.UI.Veiculos
{
    partial class frmIncluirVeiculo
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
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.cbMarca = new System.Windows.Forms.ComboBox();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtChassi = new System.Windows.Forms.TextBox();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblCategoria = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(38, 49);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(40, 13);
			this.lblMarca.TabIndex = 0;
			this.lblMarca.Text = "Marca:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(255, 49);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(38, 78);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(37, 13);
			this.lblPlaca.TabIndex = 2;
			this.lblPlaca.Text = "Placa:";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(255, 78);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(41, 13);
			this.lblChassi.TabIndex = 3;
			this.lblChassi.Text = "Chassi:";
			// 
			// cbMarca
			// 
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Volkswagen",
            "FIAT"});
			this.cbMarca.Location = new System.Drawing.Point(84, 46);
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(124, 21);
			this.cbMarca.TabIndex = 4;
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(84, 75);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(124, 20);
			this.txtPlaca.TabIndex = 6;
			// 
			// txtChassi
			// 
			this.txtChassi.Location = new System.Drawing.Point(298, 75);
			this.txtChassi.Name = "txtChassi";
			this.txtChassi.Size = new System.Drawing.Size(121, 20);
			this.txtChassi.TabIndex = 7;
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(391, 376);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 8;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(298, 46);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(120, 20);
			this.txtNome.TabIndex = 9;
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(84, 106);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(124, 20);
			this.txtKm.TabIndex = 11;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(38, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(25, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Km:";
			// 
			// lblCategoria
			// 
			this.lblCategoria.AutoSize = true;
			this.lblCategoria.Location = new System.Drawing.Point(41, 139);
			this.lblCategoria.Name = "lblCategoria";
			this.lblCategoria.Size = new System.Drawing.Size(55, 13);
			this.lblCategoria.TabIndex = 12;
			this.lblCategoria.Text = "Categoria:";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
			this.cbCategoria.Location = new System.Drawing.Point(103, 139);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(121, 21);
			this.cbCategoria.TabIndex = 13;
			// 
			// frmIncluirVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(478, 411);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.lblCategoria);
			this.Controls.Add(this.txtKm);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.txtChassi);
			this.Controls.Add(this.txtPlaca);
			this.Controls.Add(this.cbMarca);
			this.Controls.Add(this.lblChassi);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblNome);
			this.Controls.Add(this.lblMarca);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmIncluirVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Incluir Veiculo";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}