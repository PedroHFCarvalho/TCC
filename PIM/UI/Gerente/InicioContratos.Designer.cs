namespace PIM.UI.Gerente
{
    partial class frmIncioContratos
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
			this.btnLocalizar = new System.Windows.Forms.Button();
			this.txtLocalizar = new System.Windows.Forms.TextBox();
			this.btnIncluir = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAtualizar = new System.Windows.Forms.Button();
			this.dgContratos = new System.Windows.Forms.DataGridView();
			this.plManterContrato = new System.Windows.Forms.Panel();
			this.lblVagas = new System.Windows.Forms.Label();
			this.lblNome = new System.Windows.Forms.Label();
			this.dgVeiculosR = new System.Windows.Forms.DataGridView();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratos)).BeginInit();
			this.plManterContrato.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculosR)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnLocalizar);
			this.panel1.Controls.Add(this.txtLocalizar);
			this.panel1.Controls.Add(this.btnIncluir);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.btnAtualizar);
			this.panel1.Controls.Add(this.dgContratos);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(476, 423);
			this.panel1.TabIndex = 7;
			// 
			// btnLocalizar
			// 
			this.btnLocalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLocalizar.Location = new System.Drawing.Point(372, 12);
			this.btnLocalizar.Name = "btnLocalizar";
			this.btnLocalizar.Size = new System.Drawing.Size(75, 23);
			this.btnLocalizar.TabIndex = 11;
			this.btnLocalizar.Text = "Localizar";
			this.btnLocalizar.UseVisualStyleBackColor = true;
			this.btnLocalizar.Click += new System.EventHandler(this.btnLocalizar_Click);
			// 
			// txtLocalizar
			// 
			this.txtLocalizar.Location = new System.Drawing.Point(264, 14);
			this.txtLocalizar.Name = "txtLocalizar";
			this.txtLocalizar.Size = new System.Drawing.Size(100, 20);
			this.txtLocalizar.TabIndex = 10;
			this.txtLocalizar.TextChanged += new System.EventHandler(this.txtLocalizar_TextChanged);
			// 
			// btnIncluir
			// 
			this.btnIncluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncluir.Location = new System.Drawing.Point(12, 12);
			this.btnIncluir.Name = "btnIncluir";
			this.btnIncluir.Size = new System.Drawing.Size(75, 23);
			this.btnIncluir.TabIndex = 1;
			this.btnIncluir.Text = "Incluir";
			this.btnIncluir.UseVisualStyleBackColor = true;
			this.btnIncluir.Visible = false;
			this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(174, 16);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(84, 13);
			this.label1.TabIndex = 9;
			this.label1.Text = "Localizar por ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
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
			// dgContratos
			// 
			this.dgContratos.AllowUserToAddRows = false;
			this.dgContratos.AllowUserToDeleteRows = false;
			this.dgContratos.AllowUserToResizeColumns = false;
			this.dgContratos.AllowUserToResizeRows = false;
			this.dgContratos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgContratos.BackgroundColor = System.Drawing.Color.White;
			this.dgContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgContratos.Location = new System.Drawing.Point(12, 41);
			this.dgContratos.MultiSelect = false;
			this.dgContratos.Name = "dgContratos";
			this.dgContratos.ReadOnly = true;
			this.dgContratos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgContratos.Size = new System.Drawing.Size(435, 342);
			this.dgContratos.TabIndex = 0;
			this.dgContratos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContratos_CellClick);
			this.dgContratos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgContratos_CellDoubleClick);
			// 
			// plManterContrato
			// 
			this.plManterContrato.Controls.Add(this.lblVagas);
			this.plManterContrato.Controls.Add(this.lblNome);
			this.plManterContrato.Controls.Add(this.dgVeiculosR);
			this.plManterContrato.Dock = System.Windows.Forms.DockStyle.Fill;
			this.plManterContrato.Location = new System.Drawing.Point(476, 0);
			this.plManterContrato.Name = "plManterContrato";
			this.plManterContrato.Size = new System.Drawing.Size(478, 423);
			this.plManterContrato.TabIndex = 8;
			// 
			// lblVagas
			// 
			this.lblVagas.AutoSize = true;
			this.lblVagas.Location = new System.Drawing.Point(19, 74);
			this.lblVagas.Name = "lblVagas";
			this.lblVagas.Size = new System.Drawing.Size(91, 13);
			this.lblVagas.TabIndex = 102;
			this.lblVagas.Text = "Vagas Restantes:";
			// 
			// lblNome
			// 
			this.lblNome.AutoSize = true;
			this.lblNome.Location = new System.Drawing.Point(19, 52);
			this.lblNome.Name = "lblNome";
			this.lblNome.Size = new System.Drawing.Size(38, 13);
			this.lblNome.TabIndex = 101;
			this.lblNome.Text = "Nome:";
			// 
			// dgVeiculosR
			// 
			this.dgVeiculosR.AllowUserToAddRows = false;
			this.dgVeiculosR.AllowUserToDeleteRows = false;
			this.dgVeiculosR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgVeiculosR.BackgroundColor = System.Drawing.Color.White;
			this.dgVeiculosR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgVeiculosR.Location = new System.Drawing.Point(18, 233);
			this.dgVeiculosR.MultiSelect = false;
			this.dgVeiculosR.Name = "dgVeiculosR";
			this.dgVeiculosR.ReadOnly = true;
			this.dgVeiculosR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgVeiculosR.Size = new System.Drawing.Size(447, 150);
			this.dgVeiculosR.TabIndex = 97;
			// 
			// frmIncioContratos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(954, 423);
			this.Controls.Add(this.plManterContrato);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmIncioContratos";
			this.Text = "Contratos";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgContratos)).EndInit();
			this.plManterContrato.ResumeLayout(false);
			this.plManterContrato.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgVeiculosR)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridView dgContratos;
        private System.Windows.Forms.Panel plManterContrato;
        private System.Windows.Forms.Button btnLocalizar;
        private System.Windows.Forms.TextBox txtLocalizar;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgVeiculosR;
		private System.Windows.Forms.Label lblVagas;
		private System.Windows.Forms.Label lblNome;
	}
}