namespace PIM.UI.Motorista
{
    partial class frmAddMotoristaVeiculo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddMotoristaVeiculo));
			this.lblIMotoristaEX = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.addMotorista = new System.Windows.Forms.Button();
			this.dgAddVeiculo = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgAddVeiculo)).BeginInit();
			this.SuspendLayout();
			// 
			// lblIMotoristaEX
			// 
			this.lblIMotoristaEX.AutoSize = true;
			this.lblIMotoristaEX.Location = new System.Drawing.Point(14, 11);
			this.lblIMotoristaEX.Name = "lblIMotoristaEX";
			this.lblIMotoristaEX.Size = new System.Drawing.Size(77, 13);
			this.lblIMotoristaEX.TabIndex = 7;
			this.lblIMotoristaEX.Text = "lblIMotoristaEX";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(10, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(259, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Selecione o Veiculo que deseja vincular ao motorista:";
			// 
			// addMotorista
			// 
			this.addMotorista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addMotorista.Location = new System.Drawing.Point(13, 399);
			this.addMotorista.Name = "addMotorista";
			this.addMotorista.Size = new System.Drawing.Size(75, 23);
			this.addMotorista.TabIndex = 5;
			this.addMotorista.Text = "Adicionar";
			this.addMotorista.UseVisualStyleBackColor = true;
			this.addMotorista.Click += new System.EventHandler(this.addMotorista_Click);
			// 
			// dgAddVeiculo
			// 
			this.dgAddVeiculo.AllowUserToAddRows = false;
			this.dgAddVeiculo.AllowUserToDeleteRows = false;
			this.dgAddVeiculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgAddVeiculo.BackgroundColor = System.Drawing.Color.White;
			this.dgAddVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgAddVeiculo.Location = new System.Drawing.Point(13, 72);
			this.dgAddVeiculo.Name = "dgAddVeiculo";
			this.dgAddVeiculo.ReadOnly = true;
			this.dgAddVeiculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgAddVeiculo.Size = new System.Drawing.Size(461, 321);
			this.dgAddVeiculo.TabIndex = 4;
			this.dgAddVeiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAddVeiculo_CellClick);
			// 
			// frmAddMotoristaVeiculo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(485, 433);
			this.Controls.Add(this.lblIMotoristaEX);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.addMotorista);
			this.Controls.Add(this.dgAddVeiculo);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmAddMotoristaVeiculo";
			this.Text = "Adicionar Motorista ao Veiculo";
			((System.ComponentModel.ISupportInitialize)(this.dgAddVeiculo)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIMotoristaEX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addMotorista;
        private System.Windows.Forms.DataGridView dgAddVeiculo;
    }
}