namespace PIM.UI.Veiculos
{
    partial class frmAdicionarManut
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarManut));
			this.lblIdEX = new System.Windows.Forms.Label();
			this.lblEntrada = new System.Windows.Forms.Label();
			this.txtEntrada = new System.Windows.Forms.TextBox();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.txtObserv = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lblIdEX
			// 
			this.lblIdEX.AutoSize = true;
			this.lblIdEX.Location = new System.Drawing.Point(34, 27);
			this.lblIdEX.Name = "lblIdEX";
			this.lblIdEX.Size = new System.Drawing.Size(40, 13);
			this.lblIdEX.TabIndex = 0;
			this.lblIdEX.Text = "lblIdEX";
			// 
			// lblEntrada
			// 
			this.lblEntrada.AutoSize = true;
			this.lblEntrada.Location = new System.Drawing.Point(34, 51);
			this.lblEntrada.Name = "lblEntrada";
			this.lblEntrada.Size = new System.Drawing.Size(73, 13);
			this.lblEntrada.TabIndex = 2;
			this.lblEntrada.Text = "Data Entrada:";
			// 
			// txtEntrada
			// 
			this.txtEntrada.Location = new System.Drawing.Point(113, 48);
			this.txtEntrada.Name = "txtEntrada";
			this.txtEntrada.ReadOnly = true;
			this.txtEntrada.Size = new System.Drawing.Size(187, 20);
			this.txtEntrada.TabIndex = 4;
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Location = new System.Drawing.Point(225, 209);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 5;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// txtObserv
			// 
			this.txtObserv.Location = new System.Drawing.Point(37, 90);
			this.txtObserv.Multiline = true;
			this.txtObserv.Name = "txtObserv";
			this.txtObserv.Size = new System.Drawing.Size(263, 99);
			this.txtObserv.TabIndex = 6;
			// 
			// frmAdicionarManut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(345, 244);
			this.Controls.Add(this.txtObserv);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtEntrada);
			this.Controls.Add(this.lblEntrada);
			this.Controls.Add(this.lblIdEX);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAdicionarManut";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Manutenção";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEX;
        private System.Windows.Forms.Label lblEntrada;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtObserv;
    }
}