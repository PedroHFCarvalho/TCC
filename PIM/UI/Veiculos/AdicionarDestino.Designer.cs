namespace PIM.UI.Veiculos
{
    partial class frmAdicionarDestino
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarDestino));
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.txtDataSaida = new System.Windows.Forms.TextBox();
			this.lblSaida = new System.Windows.Forms.Label();
			this.lblIdEX = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRuaSaida = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRuaDestino = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Location = new System.Drawing.Point(227, 135);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 10;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// txtDataSaida
			// 
			this.txtDataSaida.Location = new System.Drawing.Point(115, 41);
			this.txtDataSaida.Name = "txtDataSaida";
			this.txtDataSaida.ReadOnly = true;
			this.txtDataSaida.Size = new System.Drawing.Size(187, 20);
			this.txtDataSaida.TabIndex = 9;
			// 
			// lblSaida
			// 
			this.lblSaida.AutoSize = true;
			this.lblSaida.Location = new System.Drawing.Point(36, 44);
			this.lblSaida.Name = "lblSaida";
			this.lblSaida.Size = new System.Drawing.Size(63, 13);
			this.lblSaida.TabIndex = 8;
			this.lblSaida.Text = "Data Saida:";
			// 
			// lblIdEX
			// 
			this.lblIdEX.AutoSize = true;
			this.lblIdEX.Location = new System.Drawing.Point(36, 20);
			this.lblIdEX.Name = "lblIdEX";
			this.lblIdEX.Size = new System.Drawing.Size(40, 13);
			this.lblIdEX.TabIndex = 7;
			this.lblIdEX.Text = "lblIdEX";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(36, 72);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Rua Saida:";
			// 
			// txtRuaSaida
			// 
			this.txtRuaSaida.Location = new System.Drawing.Point(115, 69);
			this.txtRuaSaida.Name = "txtRuaSaida";
			this.txtRuaSaida.Size = new System.Drawing.Size(187, 20);
			this.txtRuaSaida.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(36, 98);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Rua Destino:";
			// 
			// txtRuaDestino
			// 
			this.txtRuaDestino.Location = new System.Drawing.Point(115, 95);
			this.txtRuaDestino.Name = "txtRuaDestino";
			this.txtRuaDestino.Size = new System.Drawing.Size(187, 20);
			this.txtRuaDestino.TabIndex = 14;
			// 
			// frmAdicionarDestino
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(345, 181);
			this.Controls.Add(this.txtRuaDestino);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRuaSaida);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.txtDataSaida);
			this.Controls.Add(this.lblSaida);
			this.Controls.Add(this.lblIdEX);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAdicionarDestino";
			this.Text = "Adicionar Destino";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtDataSaida;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblIdEX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRuaSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRuaDestino;
    }
}