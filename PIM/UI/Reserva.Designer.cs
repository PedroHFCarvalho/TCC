namespace PIM.UI
{
	partial class Reserva
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reserva));
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.cdDisp = new System.Windows.Forms.CheckBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgReserva = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgReserva)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(205, 13);
			this.label1.TabIndex = 10;
			this.label1.Text = "Selecione o Veiculo que deseja Reservar:";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Location = new System.Drawing.Point(13, 399);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 9;
			this.btnAdicionar.Text = "Reservar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// cdDisp
			// 
			this.cdDisp.AutoSize = true;
			this.cdDisp.Location = new System.Drawing.Point(16, 44);
			this.cdDisp.Name = "cdDisp";
			this.cdDisp.Size = new System.Drawing.Size(80, 17);
			this.cdDisp.TabIndex = 19;
			this.cdDisp.Text = "Disponiveis";
			this.cdDisp.UseVisualStyleBackColor = true;
			this.cdDisp.Click += new System.EventHandler(this.chekDispo_CheckedChanged);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Location = new System.Drawing.Point(396, 42);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 16;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(152, 44);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(100, 20);
			this.txtLocalizar.TabIndex = 18;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 47);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 17;
			this.label2.Text = "Placa:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(269, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 15;
			this.label3.Text = "Categoria:";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
			this.cbCategoria.Location = new System.Drawing.Point(326, 43);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(52, 21);
			this.cbCategoria.TabIndex = 14;
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizar.Location = new System.Drawing.Point(399, 399);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
			this.btnAtualizar.TabIndex = 20;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// dgReserva
			// 
			this.dgReserva.AllowUserToAddRows = false;
			this.dgReserva.AllowUserToDeleteRows = false;
			this.dgReserva.AllowUserToResizeColumns = false;
			this.dgReserva.AllowUserToResizeRows = false;
			this.dgReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgReserva.BackgroundColor = System.Drawing.Color.White;
			this.dgReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgReserva.Location = new System.Drawing.Point(14, 71);
			this.dgReserva.MultiSelect = false;
			this.dgReserva.Name = "dgReserva";
			this.dgReserva.ReadOnly = true;
			this.dgReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgReserva.Size = new System.Drawing.Size(457, 320);
			this.dgReserva.TabIndex = 21;
			this.dgReserva.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReserva_CellClick);
			this.dgReserva.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgReserva_CellDoubleClick);
			// 
			// Reserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(485, 433);
			this.Controls.Add(this.dgReserva);
			this.Controls.Add(this.btnAtualizar);
			this.Controls.Add(this.cdDisp);
			this.Controls.Add(this.btnPesquisar);
			this.Controls.Add(this.txtLocalizar);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.cbCategoria);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdicionar);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Reserva";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Reserva";
			((System.ComponentModel.ISupportInitialize)(this.dgReserva)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAdicionar;
		private System.Windows.Forms.CheckBox cdDisp;
		private System.Windows.Forms.Button btnPesquisar;
		private System.Windows.Forms.TextBox txtLocalizar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cbCategoria;
		private System.Windows.Forms.Button btnAtualizar;
		private System.Windows.Forms.DataGridView dgReserva;
	}
}