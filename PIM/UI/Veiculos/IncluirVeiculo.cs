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

namespace PIM.UI.Veiculos
{
    public partial class frmIncluirVeiculo : Form
    {
		private ValidaForm valida;
        private EncVeiculos veiculos;
        private ManterVeiculo utilVeiculos;
		private int rec;
 
		public frmIncluirVeiculo()
		{
			InitializeComponent();
		}

		private void btnIncluir_Click(object sender, EventArgs e) //botão que recebe e inclui no cadastro
        {
            string nome = txtNome.Text;
            string marca = cbMarca.Text;
            string placa = txtPlaca.Text;
            string chassi = txtChassi.Text;
            string km = txtKm.Text;
            string categ = cbCategoria.Text;

			valida = new ValidaForm();
            veiculos = new EncVeiculos(nome ,marca ,placa ,chassi ,km ,categ);
            utilVeiculos = new ManterVeiculo();
			if (valida.ValidaF(veiculos))
			{
				txtNome.Focus();
			}
			else if (utilVeiculos.Incluir(veiculos))
			{
				MessageBox.Show("O Veiculo foi Incluido");
				veiculos.DispV = "Disponivel";
				utilVeiculos.AtualizarDisp(veiculos, true);
				Close();
			}
			else
			{
				MessageBox.Show("O Veiculo não foi Incluido");
				txtNome.Focus();
			}
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
