namespace PIM.UI.Veiculos
{
    partial class frmAtualizarVeiculo
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
			this.lblNome = new System.Windows.Forms.Label();
			this.lblMarca = new System.Windows.Forms.Label();
			this.lblPlaca = new System.Windows.Forms.Label();
			this.lblChassi = new System.Windows.Forms.Label();
			this.lblNomeEX = new System.Windows.Forms.Label();
			this.lblMarcaEX = new System.Windows.Forms.Label();
			this.lblPlacaEX = new System.Windows.Forms.Label();
			this.lblChassiEX = new System.Windows.Forms.Label();
			this.cbMarca = new System.Windows.Forms.ComboBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.lblIdEX = new System.Windows.Forms.Label();
			this.plAtualizar = new System.Windows.Forms.Panel();
			this.btnFecharEdit = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.cbCategoria = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtKm = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.label10 = new System.Windows.Forms.Label();
			this.txtPlaca = new System.Windows.Forms.TextBox();
			this.txtChassi = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lblkExcluir = new System.Windows.Forms.LinkLabel();
			this.lblkEditar = new System.Windows.Forms.LinkLabel();
			this.lblKmEX = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblDisponibilidadeEX = new System.Windows.Forms.Label();
			this.AddDestino = new System.Windows.Forms.LinkLabel();
			this.addManut = new System.Windows.Forms.LinkLabel();
			this.label4 = new System.Windows.Forms.Label();
			this.lblCategoriaEX = new System.Windows.Forms.Label();
			this.plAtualizar.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(13, 45);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 1;
			this.lblNome.Text = "Nome:";
			// 
			// lblMarca
			// 
			this.lblMarca.AutoSize = true;
			this.lblMarca.Location = new System.Drawing.Point(13, 67);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(40, 13);
			this.lblMarca.TabIndex = 2;
			this.lblMarca.Text = "Marca:";
			// 
			// lblPlaca
			// 
			this.lblPlaca.AutoSize = true;
			this.lblPlaca.Location = new System.Drawing.Point(13, 89);
			this.lblPlaca.Name = "lblPlaca";
			this.lblPlaca.Size = new System.Drawing.Size(37, 13);
			this.lblPlaca.TabIndex = 3;
			this.lblPlaca.Text = "Placa:";
			// 
			// lblChassi
			// 
			this.lblChassi.AutoSize = true;
			this.lblChassi.Location = new System.Drawing.Point(13, 112);
			this.lblChassi.Name = "lblChassi";
			this.lblChassi.Size = new System.Drawing.Size(41, 13);
			this.lblChassi.TabIndex = 4;
			this.lblChassi.Text = "Chassi:";
			// 
			// lblNomeEX
			// 
			this.lblNomeEX.AutoSize = true;
			this.lblNomeEX.Location = new System.Drawing.Point(73, 45);
			this.lblNomeEX.Name = "lblNomeEX";
			this.lblNomeEX.Size = new System.Drawing.Size(59, 13);
			this.lblNomeEX.TabIndex = 5;
			this.lblNomeEX.Text = "lblNomeEX";
			// 
			// lblMarcaEX
			// 
			this.lblMarcaEX.AutoSize = true;
			this.lblMarcaEX.Location = new System.Drawing.Point(73, 67);
			this.lblMarcaEX.Name = "lblMarcaEX";
			this.lblMarcaEX.Size = new System.Drawing.Size(61, 13);
			this.lblMarcaEX.TabIndex = 6;
			this.lblMarcaEX.Text = "lblMarcaEX";
			// 
			// lblPlacaEX
			// 
			this.lblPlacaEX.AutoSize = true;
			this.lblPlacaEX.Location = new System.Drawing.Point(73, 89);
			this.lblPlacaEX.Name = "lblPlacaEX";
			this.lblPlacaEX.Size = new System.Drawing.Size(58, 13);
			this.lblPlacaEX.TabIndex = 7;
			this.lblPlacaEX.Text = "lblPlacaEX";
			// 
			// lblChassiEX
			// 
			this.lblChassiEX.AutoSize = true;
			this.lblChassiEX.Location = new System.Drawing.Point(73, 112);
			this.lblChassiEX.Name = "lblChassiEX";
			this.lblChassiEX.Size = new System.Drawing.Size(62, 13);
			this.lblChassiEX.TabIndex = 8;
			this.lblChassiEX.Text = "lblChassiEX";
			// 
			// cbMarca
			// 
			this.cbMarca.FormattingEnabled = true;
			this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Volkswagen",
            "FIAT"});
			this.cbMarca.Location = new System.Drawing.Point(81, 67);
			this.cbMarca.Name = "cbMarca";
			this.cbMarca.Size = new System.Drawing.Size(174, 21);
			this.cbMarca.TabIndex = 25;
			// 
			// txtNome
			// 
			this.txtNome.Location = new System.Drawing.Point(71, 41);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(184, 20);
			this.txtNome.TabIndex = 26;
			// 
			// lblIdEX
			// 
			this.lblIdEX.AutoSize = true;
			this.lblIdEX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblIdEX.Location = new System.Drawing.Point(12, 9);
			this.lblIdEX.Name = "lblIdEX";
			this.lblIdEX.Size = new System.Drawing.Size(60, 20);
			this.lblIdEX.TabIndex = 74;
			this.lblIdEX.Text = "lblIdEX";
			// 
			// plAtualizar
			// 
			this.plAtualizar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.plAtualizar.Controls.Add(this.btnFecharEdit);
			this.plAtualizar.Controls.Add(this.label8);
			this.plAtualizar.Controls.Add(this.cbCategoria);
			this.plAtualizar.Controls.Add(this.label6);
			this.plAtualizar.Controls.Add(this.txtKm);
			this.plAtualizar.Controls.Add(this.label3);
			this.plAtualizar.Controls.Add(this.label2);
			this.plAtualizar.Controls.Add(this.label1);
			this.plAtualizar.Controls.Add(this.btnAtualizar);
			this.plAtualizar.Controls.Add(this.label10);
			this.plAtualizar.Controls.Add(this.txtPlaca);
			this.plAtualizar.Controls.Add(this.txtChassi);
			this.plAtualizar.Controls.Add(this.cbMarca);
			this.plAtualizar.Controls.Add(this.txtNome);
			this.plAtualizar.Controls.Add(this.label9);
			this.plAtualizar.Location = new System.Drawing.Point(197, 9);
			this.plAtualizar.Name = "plAtualizar";
			this.plAtualizar.Size = new System.Drawing.Size(264, 306);
			this.plAtualizar.TabIndex = 81;
			// 
			// btnFecharEdit
			// 
			this.btnFecharEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFecharEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnFecharEdit.Location = new System.Drawing.Point(241, 2);
			this.btnFecharEdit.Name = "btnFecharEdit";
			this.btnFecharEdit.Size = new System.Drawing.Size(18, 25);
			this.btnFecharEdit.TabIndex = 87;
			this.btnFecharEdit.Text = "X";
			this.btnFecharEdit.UseVisualStyleBackColor = true;
			this.btnFecharEdit.Click += new System.EventHandler(this.btnFecharEdit_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 178);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 86;
			this.label8.Text = "Categoria:";
			// 
			// cbCategoria
			// 
			this.cbCategoria.FormattingEnabled = true;
			this.cbCategoria.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
			this.cbCategoria.Location = new System.Drawing.Point(81, 175);
			this.cbCategoria.Name = "cbCategoria";
			this.cbCategoria.Size = new System.Drawing.Size(174, 21);
			this.cbCategoria.TabIndex = 85;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 150);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(25, 13);
			this.label6.TabIndex = 84;
			this.label6.Text = "Km:";
			// 
			// txtKm
			// 
			this.txtKm.Location = new System.Drawing.Point(71, 147);
			this.txtKm.Name = "txtKm";
			this.txtKm.Size = new System.Drawing.Size(184, 20);
			this.txtKm.TabIndex = 83;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(41, 13);
			this.label3.TabIndex = 82;
			this.label3.Text = "Chassi:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 97);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 82;
			this.label2.Text = "Placa:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(8, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 82;
			this.label1.Text = "Marca:";
			// 
			// btnAtualizar
			// 
			this.btnAtualizar.BackColor = System.Drawing.Color.WhiteSmoke;
			this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAtualizar.Location = new System.Drawing.Point(184, 264);
			this.btnAtualizar.Name = "btnAtualizar";
			this.btnAtualizar.Size = new System.Drawing.Size(71, 23);
			this.btnAtualizar.TabIndex = 60;
			this.btnAtualizar.Text = "Atualizar";
			this.btnAtualizar.UseVisualStyleBackColor = false;
			this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.Location = new System.Drawing.Point(8, 14);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 18);
			this.label10.TabIndex = 59;
			this.label10.Text = "Editar";
			// 
			// txtPlaca
			// 
			this.txtPlaca.Location = new System.Drawing.Point(71, 94);
			this.txtPlaca.Name = "txtPlaca";
			this.txtPlaca.Size = new System.Drawing.Size(184, 20);
			this.txtPlaca.TabIndex = 15;
			// 
			// txtChassi
			// 
			this.txtChassi.Location = new System.Drawing.Point(71, 120);
			this.txtChassi.Name = "txtChassi";
			this.txtChassi.Size = new System.Drawing.Size(184, 20);
			this.txtChassi.TabIndex = 16;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(8, 44);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(38, 13);
			this.label9.TabIndex = 50;
			this.label9.Text = "Nome:";
			// 
			// lblkExcluir
			// 
			this.lblkExcluir.AutoSize = true;
			this.lblkExcluir.Location = new System.Drawing.Point(94, 9);
			this.lblkExcluir.Name = "lblkExcluir";
			this.lblkExcluir.Size = new System.Drawing.Size(38, 13);
			this.lblkExcluir.TabIndex = 83;
			this.lblkExcluir.TabStop = true;
			this.lblkExcluir.Text = "Excluir";
			this.lblkExcluir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkExcluir_LinkClicked);
			// 
			// lblkEditar
			// 
			this.lblkEditar.AutoSize = true;
			this.lblkEditar.Location = new System.Drawing.Point(12, 302);
			this.lblkEditar.Name = "lblkEditar";
			this.lblkEditar.Size = new System.Drawing.Size(34, 13);
			this.lblkEditar.TabIndex = 84;
			this.lblkEditar.TabStop = true;
			this.lblkEditar.Text = "Editar";
			this.lblkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkEditar_LinkClicked);
			// 
			// lblKmEX
			// 
			this.lblKmEX.AutoSize = true;
			this.lblKmEX.Location = new System.Drawing.Point(73, 135);
			this.lblKmEX.Name = "lblKmEX";
			this.lblKmEX.Size = new System.Drawing.Size(46, 13);
			this.lblKmEX.TabIndex = 86;
			this.lblKmEX.Text = "lblKmEX";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(13, 135);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(25, 13);
			this.label5.TabIndex = 85;
			this.label5.Text = "Km:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(13, 160);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(31, 13);
			this.label7.TabIndex = 89;
			this.label7.Text = "Disp:";
			// 
			// lblDisponibilidadeEX
			// 
			this.lblDisponibilidadeEX.AutoSize = true;
			this.lblDisponibilidadeEX.Location = new System.Drawing.Point(73, 160);
			this.lblDisponibilidadeEX.Name = "lblDisponibilidadeEX";
			this.lblDisponibilidadeEX.Size = new System.Drawing.Size(102, 13);
			this.lblDisponibilidadeEX.TabIndex = 90;
			this.lblDisponibilidadeEX.Text = "lblDisponibilidadeEX";
			// 
			// AddDestino
			// 
			this.AddDestino.AutoSize = true;
			this.AddDestino.Location = new System.Drawing.Point(13, 237);
			this.AddDestino.Name = "AddDestino";
			this.AddDestino.Size = new System.Drawing.Size(90, 13);
			this.AddDestino.TabIndex = 91;
			this.AddDestino.TabStop = true;
			this.AddDestino.Text = "Adicionar Destino";
			this.AddDestino.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddDestino_LinkClicked);
			// 
			// addManut
			// 
			this.addManut.AutoSize = true;
			this.addManut.Location = new System.Drawing.Point(13, 260);
			this.addManut.Name = "addManut";
			this.addManut.Size = new System.Drawing.Size(112, 13);
			this.addManut.TabIndex = 92;
			this.addManut.TabStop = true;
			this.addManut.Text = "Adiconar Manutenção";
			this.addManut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.addManut_LinkClicked);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 188);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 13);
			this.label4.TabIndex = 93;
			this.label4.Text = "Categoria:";
			// 
			// lblCategoriaEX
			// 
			this.lblCategoriaEX.AutoSize = true;
			this.lblCategoriaEX.Location = new System.Drawing.Point(73, 188);
			this.lblCategoriaEX.Name = "lblCategoriaEX";
			this.lblCategoriaEX.Size = new System.Drawing.Size(76, 13);
			this.lblCategoriaEX.TabIndex = 94;
			this.lblCategoriaEX.Text = "lblCategoriaEX";
			// 
			// frmAtualizarVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(478, 411);
			this.Controls.Add(this.lblCategoriaEX);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.addManut);
			this.Controls.Add(this.AddDestino);
			this.Controls.Add(this.lblDisponibilidadeEX);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblKmEX);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblkEditar);
			this.Controls.Add(this.lblkExcluir);
			this.Controls.Add(this.plAtualizar);
			this.Controls.Add(this.lblIdEX);
			this.Controls.Add(this.lblChassiEX);
			this.Controls.Add(this.lblPlacaEX);
			this.Controls.Add(this.lblMarcaEX);
			this.Controls.Add(this.lblNomeEX);
			this.Controls.Add(this.lblChassi);
			this.Controls.Add(this.lblPlaca);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.lblNome);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmAtualizarVeiculo";
			this.Text = "Atualizar Veiculo";
			this.plAtualizar.ResumeLayout(false);
			this.plAtualizar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Label lblChassi;
        private System.Windows.Forms.Label lblNomeEX;
        private System.Windows.Forms.Label lblMarcaEX;
        private System.Windows.Forms.Label lblPlacaEX;
        private System.Windows.Forms.Label lblChassiEX;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblIdEX;
        private System.Windows.Forms.Panel plAtualizar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPlaca;
        private System.Windows.Forms.TextBox txtChassi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel lblkExcluir;
        private System.Windows.Forms.LinkLabel lblkEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Label lblKmEX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDisponibilidadeEX;
        private System.Windows.Forms.LinkLabel AddDestino;
        private System.Windows.Forms.LinkLabel addManut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCategoriaEX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Button btnFecharEdit;
    }
}