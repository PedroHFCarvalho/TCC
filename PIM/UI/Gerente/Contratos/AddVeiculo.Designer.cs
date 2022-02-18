namespace PIM.UI.Gerente.Contratos
{
    partial class frmAddVeiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddVeiculo));
			this.dgAddVeiculo = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lblIContratoEX = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgAddVeiculo)).BeginInit();
			this.SuspendLayout();
			// 
			// dgAddVeiculo
			// 
			this.dgAddVeiculo.AllowUserToAddRows = false;
			this.dgAddVeiculo.AllowUserToDeleteRows = false;
			this.dgAddVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAddVeiculo.BackgroundColor = System.Drawing.Color.White;
			this.dgAddVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAddVeiculo.Location = new System.Drawing.Point(12, 74);
			this.dgAddVeiculo.Name = "dgAddVeiculo";
			this.dgAddVeiculo.ReadOnly = true;
			this.dgAddVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAddVeiculo.Size = new System.Drawing.Size(461, 321);
			this.dgAddVeiculo.TabIndex = 0;
			this.dgAddVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddVeiculo_CellClick);
			// 
			// button1
			// 
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Location = new System.Drawing.Point(12, 401);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Adicionar";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(262, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Selecione o Veiculo que deseja adicionar ao contrato:";
			// 
			// lblIContratoEX
			// 
			this.lblIContratoEX.AutoSize = true;
			this.lblIContratoEX.Location = new System.Drawing.Point(13, 13);
			this.lblIContratoEX.Name = "lblIContratoEX";
			this.lblIContratoEX.Size = new System.Drawing.Size(74, 13);
			this.lblIContratoEX.TabIndex = 3;
			this.lblIContratoEX.Text = "lblIContratoEX";
			// 
			// frmAddVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(485, 433);
			this.Controls.Add(this.lblIContratoEX);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.dgAddVeiculo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAddVeiculo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Adicionar Veiculos";
			((System.ComponentModel.ISupportInitialize)(this.dgAddVeiculo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAddVeiculo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIContratoEX;
    }
}