namespace PIM.UI
{
    partial class frmTabelasInicio
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
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.dgDisp = new System.Windows.Forms.DataGridView();
			this.dgManut = new System.Windows.Forms.DataGridView();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.btnReserva = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgDisp)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgManut)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(652, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Veiculos Disponiveis:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(330, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(131, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Veiculos Em Manutenção:";
			// 
			// dgDisp
			// 
			this.dgDisp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgDisp.BackgroundColor = System.Drawing.Color.White;
			this.dgDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgDisp.Location = new System.Drawing.Point(652, 44);
			this.dgDisp.Name = "dgDisp";
			this.dgDisp.ReadOnly = true;
			this.dgDisp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgDisp.Size = new System.Drawing.Size(270, 356);
			this.dgDisp.TabIndex = 5;
			this.dgDisp.TabStop = false;
			// 
			// dgManut
			// 
			this.dgManut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgManut.BackgroundColor = System.Drawing.Color.White;
			this.dgManut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgManut.Location = new System.Drawing.Point(330, 44);
			this.dgManut.MultiSelect = false;
			this.dgManut.Name = "dgManut";
			this.dgManut.ReadOnly = true;
			this.dgManut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgManut.Size = new System.Drawing.Size(270, 356);
			this.dgManut.TabIndex = 4;
			this.dgManut.TabStop = false;
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(40, 56);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(248, 97);
			this.btnIncluir.TabIndex = 1;
			this.btnIncluir.Text = "Incluir Novo Cliente";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// btnReserva
			// 
			this.btnReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReserva.Location = new System.Drawing.Point(40, 169);
			this.btnReserva.Name = "btnReserva";
			this.btnReserva.Size = new System.Drawing.Size(248, 97);
			this.btnReserva.TabIndex = 2;
			this.btnReserva.Text = "Reserva Veiculo";
			this.btnReserva.UseVisualStyleBackColor = true;
			this.btnReserva.Click += new System.EventHandler(this.btnReserva_Click);
			// 
			// button2
			// 
			this.button2.Enabled = false;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(40, 289);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(248, 97);
			this.button2.TabIndex = 3;
			this.button2.Text = "...";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// frmTabelasInicio
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(957, 424);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnReserva);
			this.Controls.Add(this.btnIncluir);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgDisp);
			this.Controls.Add(this.dgManut);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmTabelasInicio";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TabelasInicio";
			((System.ComponentModel.ISupportInitialize)(this.dgDisp)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgManut)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgDisp;
        private System.Windows.Forms.DataGridView dgManut;
		private System.Windows.Forms.Button btnIncluir;
		private System.Windows.Forms.Button btnReserva;
		private System.Windows.Forms.Button button2;
	}
}