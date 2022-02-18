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

namespace PIM.UI.Motorista
{
    public partial class frmAddMotoristaVeiculo : Form
    {
        private EncMotorista motorista;
        private EncVeiculos veiculos;
        ManterVeiculo utilVeiculo;
        private string idVeiculo, idMotorista, nome;


        public frmAddMotoristaVeiculo(EncMotorista motorista)
        {
            this.motorista = motorista;
            InitializeComponent();
            AtualizarLista(); //Atualiza o DataGrid
            lblIMotoristaEX.Text = motorista.idMotorista;
            idMotorista = motorista.idMotorista;
        }

        private void addMotorista_Click(object sender, EventArgs e)
        {
			try
			{
				utilVeiculo = new ManterVeiculo();

				if (utilVeiculo.AtualizarMotorista(veiculos))
				{
					MessageBox.Show("O motorista foi vinculado ao motorista");
				}
				else
				{
					MessageBox.Show("O motorista não foi vinculado ao motorista");

				}
			}
			catch (Exception)
			{
				MessageBox.Show("Selecione antes de continuar");
			}
        }

        private void dgAddVeiculo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgAddVeiculo.Rows[e.RowIndex];
                idVeiculo = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
            }
            veiculos = new EncVeiculos(idVeiculo, idMotorista , nome);
        }

        public void AtualizarLista() //função que revebe o dataset e coloca no datagrid
        {
            utilVeiculo = new ManterVeiculo();
            dgAddVeiculo.DataSource = utilVeiculo.Listar().Tables[0];
        }
    }
}
