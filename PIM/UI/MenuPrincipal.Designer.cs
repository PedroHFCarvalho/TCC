namespace PIM.UI
{
    partial class frmMenuPrincipal
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
			this.btnGerente = new System.Windows.Forms.Button();
			this.btnVeiculos = new System.Windows.Forms.Button();
			this.Top = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.btnFuncionario = new System.Windows.Forms.Button();
			this.btnContratos = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnInicio = new System.Windows.Forms.Button();
			this.btnDestino = new System.Windows.Forms.Button();
			this.btnManut = new System.Windows.Forms.Button();
			this.btnMotorista = new System.Windows.Forms.Button();
			this.btnCliente = new System.Windows.Forms.Button();
			this.plConteiner = new System.Windows.Forms.Panel();
			this.Top.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnGerente
			// 
			this.btnGerente.BackColor = System.Drawing.Color.White;
			this.btnGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGerente.Location = new System.Drawing.Point(-8, 40);
			this.btnGerente.Name = "btnGerente";
			this.btnGerente.Size = new System.Drawing.Size(147, 35);
			this.btnGerente.TabIndex = 2;
			this.btnGerente.Text = "Gerente";
			this.btnGerente.UseVisualStyleBackColor = false;
			this.btnGerente.Click += new System.EventHandler(this.btnFuncionario_Click);
			// 
			// btnVeiculos
			// 
			this.btnVeiculos.BackColor = System.Drawing.Color.White;
			this.btnVeiculos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVeiculos.Location = new System.Drawing.Point(-8, 75);
			this.btnVeiculos.Name = "btnVeiculos";
			this.btnVeiculos.Size = new System.Drawing.Size(147, 35);
			this.btnVeiculos.TabIndex = 3;
			this.btnVeiculos.Text = "Veiculos";
			this.btnVeiculos.UseVisualStyleBackColor = false;
			this.btnVeiculos.Click += new System.EventHandler(this.btnVaiculos_Click);
			// 
			// Top
			// 
			this.Top.Controls.Add(this.pictureBox1);
			this.Top.Controls.Add(this.btnFuncionario);
			this.Top.Controls.Add(this.btnContratos);
			this.Top.Controls.Add(this.pictureBox2);
			this.Top.Dock = System.Windows.Forms.DockStyle.Top;
			this.Top.Location = new System.Drawing.Point(0, 0);
			this.Top.Name = "Top";
			this.Top.Size = new System.Drawing.Size(1097, 118);
			this.Top.TabIndex = 2;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(243, 68);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// btnFuncionario
			// 
			this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFuncionario.Location = new System.Drawing.Point(242, 89);
			this.btnFuncionario.Name = "btnFuncionario";
			this.btnFuncionario.Size = new System.Drawing.Size(75, 23);
			this.btnFuncionario.TabIndex = 8;
			this.btnFuncionario.Text = "Funcionario";
			this.btnFuncionario.UseVisualStyleBackColor = true;
			this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click_1);
			// 
			// btnContratos
			// 
			this.btnContratos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnContratos.Location = new System.Drawing.Point(152, 89);
			this.btnContratos.Name = "btnContratos";
			this.btnContratos.Size = new System.Drawing.Size(75, 23);
			this.btnContratos.TabIndex = 7;
			this.btnContratos.Text = "Contratos";
			this.btnContratos.UseVisualStyleBackColor = true;
			this.btnContratos.Click += new System.EventHandler(this.btnContratos_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(30, 12);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(1067, 83);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 10;
			this.pictureBox2.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.btnInicio);
			this.panel1.Controls.Add(this.btnDestino);
			this.panel1.Controls.Add(this.btnManut);
			this.panel1.Controls.Add(this.btnMotorista);
			this.panel1.Controls.Add(this.btnCliente);
			this.panel1.Controls.Add(this.btnGerente);
			this.panel1.Controls.Add(this.btnVeiculos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 118);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(140, 435);
			this.panel1.TabIndex = 3;
			// 
			// btnInicio
			// 
			this.btnInicio.BackColor = System.Drawing.Color.White;
			this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnInicio.Location = new System.Drawing.Point(-8, 5);
			this.btnInicio.Name = "btnInicio";
			this.btnInicio.Size = new System.Drawing.Size(147, 35);
			this.btnInicio.TabIndex = 1;
			this.btnInicio.Text = "Inicio";
			this.btnInicio.UseVisualStyleBackColor = false;
			this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
			// 
			// btnDestino
			// 
			this.btnDestino.BackColor = System.Drawing.Color.White;
			this.btnDestino.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDestino.Location = new System.Drawing.Point(-8, 215);
			this.btnDestino.Name = "btnDestino";
			this.btnDestino.Size = new System.Drawing.Size(147, 35);
			this.btnDestino.TabIndex = 7;
			this.btnDestino.Text = "Destinos";
			this.btnDestino.UseVisualStyleBackColor = false;
			this.btnDestino.Click += new System.EventHandler(this.btnDestino_Click);
			// 
			// btnManut
			// 
			this.btnManut.BackColor = System.Drawing.Color.White;
			this.btnManut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManut.Location = new System.Drawing.Point(-8, 180);
			this.btnManut.Name = "btnManut";
			this.btnManut.Size = new System.Drawing.Size(147, 35);
			this.btnManut.TabIndex = 6;
			this.btnManut.Text = "Manutenção";
			this.btnManut.UseVisualStyleBackColor = false;
			this.btnManut.Click += new System.EventHandler(this.btnManut_Click);
			// 
			// btnMotorista
			// 
			this.btnMotorista.BackColor = System.Drawing.Color.White;
			this.btnMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMotorista.Location = new System.Drawing.Point(-8, 145);
			this.btnMotorista.Name = "btnMotorista";
			this.btnMotorista.Size = new System.Drawing.Size(147, 35);
			this.btnMotorista.TabIndex = 5;
			this.btnMotorista.Text = "Motorista";
			this.btnMotorista.UseVisualStyleBackColor = false;
			this.btnMotorista.Click += new System.EventHandler(this.btnMotorista_Click);
			// 
			// btnCliente
			// 
			this.btnCliente.BackColor = System.Drawing.Color.White;
			this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCliente.Location = new System.Drawing.Point(-8, 110);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(147, 35);
			this.btnCliente.TabIndex = 4;
			this.btnCliente.Text = "Cliente";
			this.btnCliente.UseVisualStyleBackColor = false;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// plConteiner
			// 
			this.plConteiner.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plConteiner.Location = new System.Drawing.Point(140, 118);
			this.plConteiner.Name = "plConteiner";
			this.plConteiner.Size = new System.Drawing.Size(957, 435);
			this.plConteiner.TabIndex = 4;
			// 
			// frmMenuPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1097, 553);
			this.Controls.Add(this.plConteiner);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.Top);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "frmMenuPrincipal";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Menu Principal";
			this.Top.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerente;
        private System.Windows.Forms.Button btnVeiculos;
        private System.Windows.Forms.Panel Top;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel plConteiner;
        private System.Windows.Forms.Button btnContratos;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Button btnMotorista;
        private System.Windows.Forms.Button btnManut;
        private System.Windows.Forms.Button btnDestino;
        private System.Windows.Forms.Button btnInicio;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}