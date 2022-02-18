using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimDLL.DTO;
using PimDLL.BLL;

namespace PIM.UI.Cliente
{
    public partial class frmAddContrato : Form
    {
        private EncCliente cliente;
        private EncContrato contrato;
        ManterContrato utilContrato;
        private string id,nome, vagas, idcontrato;

        public frmAddContrato(EncCliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            AtualizarLista(); //Atualiza o DataGrid
            lblIdEX.Text = cliente.Idcl;
            idcontrato = cliente.Idcl;
        }

        public void AtualizarLista() //função que revebe o dataset e coloca no datagrid
        {
            utilContrato = new ManterContrato();
            dgAddContrato.DataSource = utilContrato.Listar().Tables[0];
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
			try
			{
				utilContrato = new ManterContrato();

				if (utilContrato.AtualizarCliente(contrato))
				{
					MessageBox.Show("Contrato do Cliente foi atualizado");
				}
				else
				{
					MessageBox.Show("Contrato não foi Atualizado");

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Selecione antes de continuar");
			}
        }

        private void dgAddContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAddContrato.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
				nome = row.Cells[0].Value + string.Empty;
				vagas = row.Cells[0].Value + string.Empty;
			}
            contrato = new EncContrato(id,nome,vagas,idcontrato);
        }
    }
}
