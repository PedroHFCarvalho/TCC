using PIM.UI.Veiculos;
using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.UI
{
	public partial class Reserva : Form
	{
		private EncVeiculos veiculos;
		private ManterVeiculo utilVeiculos;
		private string id, nome, marca, placa, chassi, km, disp, categ;

		public Reserva()
		{
			InitializeComponent();
			utilVeiculos = new ManterVeiculo();
			AtualizarTabela();
		}

		private void btnPesquisar_Click_1(object sender, EventArgs e)
		{

			string txt = txtLocalizar.Text;
			string cbBox = cbCategoria.Text;

			if (cbBox != "")
			{
				if (txt != "")
				{
					try
					{
						DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Placa='" + txt + "'AND Categoria='" + cbBox + "'").CopyToDataTable();
						dgReserva.DataSource = dtResultado;
					}
					catch (Exception)
					{
						MessageBox.Show("Não Localizado");
					}
				}
				else
				{
					try
					{
						DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Categoria='" + cbBox + "'").CopyToDataTable();
						dgReserva.DataSource = dtResultado;
					}
					catch (Exception)
					{
						MessageBox.Show("Não Localizado");
					}
				}
			}
			else
			{
				try
				{
					DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Placa='" + txt + "'").CopyToDataTable();
					dgReserva.DataSource = dtResultado;
				}
				catch (Exception)
				{
					MessageBox.Show("Não Localizado");
				}
			}
		}

		private void dgReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			new frmAdicionarDestino(veiculos).ShowDialog();
		}

		private void btnAdicionar_Click(object sender, EventArgs e)
		{
			try
			{
				new frmAdicionarDestino(veiculos).ShowDialog();
			}
			catch (Exception)
			{
				MessageBox.Show("Selecione antes de continuar");
			}
		}

		private void btnAtualizar_Click(object sender, EventArgs e)
		{
			AtualizarTabela();
		}

		private void dgReserva_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dgReserva.Rows[e.RowIndex];
				id = row.Cells[0].Value + string.Empty;
				nome = row.Cells[1].Value + string.Empty;
				marca = row.Cells[2].Value + string.Empty;
				placa = row.Cells[3].Value + string.Empty;
				chassi = row.Cells[4].Value + string.Empty;
				km = row.Cells[5].Value + string.Empty;
				disp = row.Cells[6].Value + string.Empty;
				categ = row.Cells[7].Value + string.Empty;
			}
			veiculos = new EncVeiculos(id, nome, marca, placa, chassi, km, disp, categ);
		}

		private void AtualizarTabela() //recebe o dataset e envia para datagrid
		{
			dgReserva.DataSource = utilVeiculos.Listar().Tables[0];
			dgReserva.Columns["Km"].Visible = false;
			dgReserva.Columns["Chassi"].Visible = false;
			dgReserva.Columns["Id_Contrato"].Visible = false;
			dgReserva.Columns["Id_Motorista"].Visible = false;
		}

		private void chekDispo_CheckedChanged(object sender, EventArgs e)
		{
			if (cdDisp.Checked == true)
			{
				string txt = "Disponivel";
				try
				{
					DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Disponibilidade='" + txt + "'").CopyToDataTable();
					dgReserva.DataSource = dtResultado;
				}
				catch (Exception)
				{

				}
			}
			else
			{
				AtualizarTabela();
			}
		}

		private void btnPesquisar_Click(object sender, EventArgs e)
		{

		}
	}
}
