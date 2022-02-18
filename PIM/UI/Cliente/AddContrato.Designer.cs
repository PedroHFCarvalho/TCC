namespace PIM.UI.Cliente
{
    partial class frmAddContrato
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddContrato));
			this.lblIdEX = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnAdicionar = new System.Windows.Forms.Button();
			this.dgAddContrato = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgAddContrato)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIdEX
			// 
			this.lblIdEX.AutoSize = true;
			this.lblIdEX.Location = new System.Drawing.Point(13, 10);
			this.lblIdEX.Name = "lblIdEX";
			this.lblIdEX.Size = new System.Drawing.Size(40, 13);
			this.lblIdEX.TabIndex = 7;
			this.lblIdEX.Text = "lblIdEX";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(261, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Selecione o Contrato que deseja vincular ao contrato:";
			// 
			// btnAdicionar
			// 
			this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdicionar.Location = new System.Drawing.Point(12, 398);
			this.btnAdicionar.Name = "btnAdicionar";
			this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
			this.btnAdicionar.TabIndex = 5;
			this.btnAdicionar.Text = "Adicionar";
			this.btnAdicionar.UseVisualStyleBackColor = true;
			this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
			// 
			// dgAddContrato
			// 
			this.dgAddContrato.AllowUserToAddRows = false;
			this.dgAddContrato.AllowUserToDeleteRows = false;
			this.dgAddContrato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAddContrato.BackgroundColor = System.Drawing.Color.White;
			this.dgAddContrato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAddContrato.Location = new System.Drawing.Point(12, 71);
			this.dgAddContrato.Name = "dgAddContrato";
			this.dgAddContrato.ReadOnly = true;
			this.dgAddContrato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAddContrato.Size = new System.Drawing.Size(461, 321);
			this.dgAddContrato.TabIndex = 4;
			this.dgAddContrato.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddContrato_CellClick);
			// 
			// frmAddContrato
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(485, 433);
			this.Controls.Add(this.lblIdEX);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAdicionar);
			this.Controls.Add(this.dgAddContrato);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAddContrato";
			this.Text = "Adicionar Contrato";
			((System.ComponentModel.ISupportInitialize)(this.dgAddContrato)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdEX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.DataGridView dgAddContrato;
    }
}