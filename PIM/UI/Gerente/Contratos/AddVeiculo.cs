using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimDLL.BLL;

namespace PIM.UI.Gerente.Contratos
{
    public partial class frmAddVeiculo : Form
    {
        private EncContrato contrato;
        private EncVeiculos veiculos;
        ManterVeiculo utilVeiculo;
		ManterContrato utilContrato;
        private string id, idcont;

        public frmAddVeiculo(EncContrato contrato)
        {
			utilContrato = new ManterContrato();
            InitializeComponent();
            this.contrato = contrato;
            AtualizarLista(); //Atualiza o DataGrid
            lblIContratoEX.Text = contrato.IdC;
            idcont = contrato.IdC;
        }

        public void AtualizarLista() //função que revebe o dataset e coloca no datagrid
        {
            utilVeiculo = new ManterVeiculo();
            dgAddVeiculo.DataSource = utilVeiculo.Listar().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e) //botão adicionar
        {
			try
			{
				utilVeiculo = new ManterVeiculo();

				if (utilVeiculo.AtualizaContrato(veiculos))
				{
					int vagas = Convert.ToInt32(contrato.VagasC);
					vagas = vagas - 1;
					contrato.VagasC = vagas.ToString();

					utilContrato.Atualizar(contrato);

					MessageBox.Show("Contrato do Veiculo foi atualizado");
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

        private void dgAddVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)// botão que recebe os dados da linha do datagrid
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAddVeiculo.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
            }
            veiculos = new EncVeiculos(id, idcont);
        }
    }
}
