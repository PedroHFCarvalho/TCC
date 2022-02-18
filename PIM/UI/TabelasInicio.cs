using PIM.UI.Cliente;
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
    public partial class frmTabelasInicio : Form
    {
        ManterVeiculo utilVeiculos;
        ManterDestino utilDestino;
        ManterManut utilManut;

        public frmTabelasInicio()
        {
            InitializeComponent();
            AtualizarDisp();
            AtualizarManut();
           //AtualizarRodando();
        }

        private void AtualizarDisp()
        {
            try
            {
                dgDisp.Columns.Clear();
                utilVeiculos = new ManterVeiculo();
                DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Disponibilidade='Disponivel'").CopyToDataTable();
                dgDisp.DataSource = dtResultado;
                dgDisp.Columns["Nome"].Visible = false;
                dgDisp.Columns["Marca"].Visible = false;
                dgDisp.Columns["Chassi"].Visible = false;
                dgDisp.Columns["Km"].Visible = false;
                dgDisp.Columns["Categoria"].Visible = false;
                dgDisp.Columns["Disponibilidade"].Visible = false;
                dgDisp.Columns["Id_Motorista"].Visible = false;
            }
            catch (Exception)
            {
                dgManut.Columns.Add("id", "Id");
                dgManut.Columns.Add("placa", "Placa");
            }
        }
        private void AtualizarManut()
        {
            try
            {
                dgManut.Columns.Clear();
                utilManut = new ManterManut();
                DataTable dtResultado = utilManut.Listar().Tables[0].Select("Saida=''").CopyToDataTable();
                dgManut.DataSource = dtResultado;
                dgManut.Columns["Nome"].Visible = false;
                dgManut.Columns["Marca"].Visible = false;
                dgManut.Columns["Chassi"].Visible = false;
                dgManut.Columns["Km"].Visible = false;
                dgManut.Columns["Categoria"].Visible = false;
                dgManut.Columns["Observacao"].Visible = false;
                dgManut.Columns["Id_Manut"].Visible = false;
                dgManut.Columns["Saida"].Visible = false;
                dgManut.Columns["Entrada"].Visible = false;

            }
            catch (Exception)
            {
                dgManut.Columns.Add("id", "Id");
                dgManut.Columns.Add("placa", "Placa");
            }
        }

		private void btnIncluir_Click(object sender, EventArgs e)
		{
			frmIncluirCliente f = new frmIncluirCliente();
			f.FormBorderStyle = FormBorderStyle.Sizable;
			f.ShowDialog();
		}

		private void btnReserva_Click(object sender, EventArgs e)
		{
			new Reserva().ShowDialog();
		}
	}
}
