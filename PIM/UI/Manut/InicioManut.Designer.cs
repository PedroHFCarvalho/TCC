namespace PIM.UI.Manut
{
    partial class frmInicioManut
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
			this.chekManut = new System.Windows.Forms.CheckBox();
			this.btnPesquisar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.dgManut = new System.Windows.Forms.DataGridView();
			this.lblNome = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.label13 = new System.Windows.Forms.Label();
			this.txtObserv = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.plManterFuncionario = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgManut)).BeginInit();
			this.plManterFuncionario.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.chekManut);
			this.panel1.Controls.Add(this.btnPesquisar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.dgManut);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 8;
			// 
			// chekManut
			// 
			this.chekManut.AutoSize = true;
			this.chekManut.Location = new System.Drawing.Point(12, 16);
			this.chekManut.Name = "chekManut";
			this.chekManut.Size = new System.Drawing.Size(104, 17);
			this.chekManut.TabIndex = 14;
			this.chekManut.Text = "Em Manutenção";
			this.chekManut.UseVisualStyleBackColor = true;
			this.chekManut.CheckedChanged += new System.EventHandler(this.chekManut_CheckedChanged);
			// 
			// btnPesquisar
			// 
			this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPesquisar.Location = new System.Drawing.Point(372, 12);
			this.btnPesquisar.Name = "btnPesquisar";
			this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.btnPesquisar.TabIndex = 15;
			this.btnPesquisar.Text = "Pesquisar";
			this.btnPesquisar.UseVisualStyleBackColor = true;
			this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(266, 14);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(100, 20);
			this.txtLocalizar.TabIndex = 14;
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(226, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "Placa";
			// 
			// dgManut
			// 
			this.dgManut.AllowUserToAddRows = false;
			this.dgManut.AllowUserToDeleteRows = false;
			this.dgManut.AllowUserToResizeColumns = false;
			this.dgManut.AllowUserToResizeRows = false;
			this.dgManut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgManut.BackgroundColor = System.Drawing.Color.White;
			this.dgManut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgManut.Location = new System.Drawing.Point(12, 41);
			this.dgManut.MultiSelect = false;
			this.dgManut.Name = "dgManut";
			this.dgManut.ReadOnly = true;
			this.dgManut.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgManut.Size = new System.Drawing.Size(435, 342);
			this.dgManut.TabIndex = 0;
			this.dgManut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManut_CellClick);
			this.dgManut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManut_CellContentClick);
			this.dgManut.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManut_CellDoubleClick);
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(7, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 122;
			this.lblNome.Text = "Nome:";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(7, 67);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(40, 13);
			this.lblMarca.TabIndex = 123;
			this.lblMarca.Text = "Marca:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(7, 89);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(37, 13);
			this.lblPlaca.TabIndex = 124;
			this.lblPlaca.Text = "Placa:";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(7, 112);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(41, 13);
			this.lblChassi.TabIndex = 125;
			this.lblChassi.Text = "Chassi:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(7, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 131;
			this.label5.Text = "Km:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(7, 157);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 133;
			this.label4.Text = "Categoria:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 250);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(73, 13);
			this.label11.TabIndex = 135;
			this.label11.Text = "Data Entrada:";
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(17, 322);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(127, 23);
			this.button1.TabIndex = 121;
			this.button1.Text = "Finalizar Manutenção";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(14, 275);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(63, 13);
			this.label13.TabIndex = 137;
			this.label13.Text = "Data Saida:";
			// 
			// txtObserv
			// 
			this.txtObserv.BackColor = System.Drawing.Color.White;
			this.txtObserv.Location = new System.Drawing.Point(205, 55);
			this.txtObserv.Multiline = true;
			this.txtObserv.Name = "txtObserv";
			this.txtObserv.ReadOnly = true;
			this.txtObserv.Size = new System.Drawing.Size(233, 149);
			this.txtObserv.TabIndex = 139;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(202, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(68, 13);
			this.label1.TabIndex = 140;
			this.label1.Text = "Observação:";
			// 
			// plManterFuncionario
			// 
			this.plManterFuncionario.Controls.Add(this.label1);
			this.plManterFuncionario.Controls.Add(this.txtObserv);
			this.plManterFuncionario.Controls.Add(this.label13);
			this.plManterFuncionario.Controls.Add(this.button1);
			this.plManterFuncionario.Controls.Add(this.label11);
			this.plManterFuncionario.Controls.Add(this.label4);
			this.plManterFuncionario.Controls.Add(this.label5);
			this.plManterFuncionario.Controls.Add(this.lblChassi);
			this.plManterFuncionario.Controls.Add(this.lblPlaca);
			this.plManterFuncionario.Controls.Add(this.lblMarca);
			this.plManterFuncionario.Controls.Add(this.lblNome);
			this.plManterFuncionario.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plManterFuncionario.Location = new System.Drawing.Point(476, 0);
			this.plManterFuncionario.Name = "plManterFuncionario";
			this.plManterFuncionario.Size = new System.Drawing.Size(478, 423);
			this.plManterFuncionario.TabIndex = 9;
			// 
			// frmInicioManut
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterFuncionario);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmInicioManut";
			this.Text = "InicioManut";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgManut)).EndInit();
			this.plManterFuncionario.ResumeLayout(false);
			this.plManterFuncionario.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgManut;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.CheckBox chekManut;
		private System.Windows.Forms.Label lblNome;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.Label lblPlaca;
		private System.Windows.Forms.Label lblChassi;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txtObserv;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel plManterFuncionario;
	}
}