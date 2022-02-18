namespace PIM.UI.Veiculos
{
    partial class frmInicioVeiculos
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
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgVeiculos = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.chekDispo = new System.Windows.Forms.CheckBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.plManterVeiculo = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).BeginInit();
			this.panel1.SuspendLayout();
			this.plManterVeiculo.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(372, 389);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 2;
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
			this.btnAtualizar.TabIndex = 5;
			this.btnAtualizar.Text = "Atualizar Lista";
			this.btnAtualizar.UseVisualStyleBackColor = true;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// dgVeiculos
			// 
			this.dgVeiculos.AllowUserToAddRows = false;
			this.dgVeiculos.AllowUserToDeleteRows = false;
			this.dgVeiculos.AllowUserToResizeColumns = false;
			this.dgVeiculos.AllowUserToResizeRows = false;
			this.dgVeiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgVeiculos.BackgroundColor = System.Drawing.Color.White;
			this.dgVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgVeiculos.Location = new System.Drawing.Point(12, 41);
			this.dgVeiculos.MultiSelect = false;
			this.dgVeiculos.Name = "dgVeiculos";
			this.dgVeiculos.ReadOnly = true;
			this.dgVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgVeiculos.Size = new System.Drawing.Size(435, 342);
			this.dgVeiculos.TabIndex = 7;
			this.dgVeiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculos_CellClick);
			this.dgVeiculos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgVeiculos_CellDoubleClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chekDispo);
			this.panel1.Controls.Add(this.btnPesquisar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbCategoria);
			this.panel1.Controls.Add(this.dgVeiculos);
			this.panel1.Controls.Add(this.btnIncluir);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 8;
			// 
			// chekDispo
			// 
			this.chekDispo.AutoSize = true;
			this.chekDispo.Location = new System.Drawing.Point(13, 14);
			this.chekDispo.Name = "chekDispo";
			this.chekDispo.Size = new System.Drawing.Size(80, 17);
			this.chekDispo.TabIndex = 13;
			this.chekDispo.Text = "Disponiveis";
			this.chekDispo.UseVisualStyleBackColor = true;
			this.chekDispo.CheckedChanged += new System.EventHandler(this.chekDispo_CheckedChanged);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Location = new System.Drawing.Point(374, 12);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 10;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(138, 14);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(100, 20);
			this.txtLocalizar.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(98, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "Placa";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(255, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Categoria:";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
			this.cbCategoria.Location = new System.Drawing.Point(316, 13);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(52, 21);
			this.cbCategoria.TabIndex = 8;
			// 
			// plManterVeiculo
			// 
			this.plManterVeiculo.Controls.Add(this.label4);
			this.plManterVeiculo.Controls.Add(this.label7);
			this.plManterVeiculo.Controls.Add(this.label5);
			this.plManterVeiculo.Controls.Add(this.lblChassi);
			this.plManterVeiculo.Controls.Add(this.lblPlaca);
			this.plManterVeiculo.Controls.Add(this.lblMarca);
			this.plManterVeiculo.Controls.Add(this.lblNome);
			this.plManterVeiculo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plManterVeiculo.Location = new System.Drawing.Point(476, 0);
			this.plManterVeiculo.Name = "plManterVeiculo";
			this.plManterVeiculo.Size = new System.Drawing.Size(478, 423);
			this.plManterVeiculo.TabIndex = 9;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 112;
			this.label4.Text = "Categoria:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(7, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 108;
			this.label7.Text = "Disp:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 106;
			this.label5.Text = "Km:";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(7, 112);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(41, 13);
			this.lblChassi.TabIndex = 98;
			this.lblChassi.Text = "Chassi:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(7, 89);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(37, 13);
			this.lblPlaca.TabIndex = 97;
			this.lblPlaca.Text = "Placa:";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(7, 67);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(40, 13);
			this.lblMarca.TabIndex = 96;
			this.lblMarca.Text = "Marca:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(7, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 95;
			this.lblNome.Text = "Nome:";
			// 
			// frmInicioVeiculos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterVeiculo);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInicioVeiculos";
			this.Text = "Inicio Veiculos";
			this.Load += new System.EventHandler(this.frmInicioVeiculos_Load);
			this.Click += new System.EventHandler(this.frmInicioVeiculos_Click);
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculos)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.plManterVeiculo.ResumeLayout(false);
			this.plManterVeiculo.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgVeiculos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plManterVeiculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chekDispo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblChassi;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblNome;
	}
}