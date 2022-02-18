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
using PimDLL.DTO;

namespace PIM.UI.Veiculos
{
    public partial class frmAdicionarDestino : Form
    {
        private string ruaDestino, ruaSaida, dataSaida;
        private EncVeiculos veiculos;
        private EncDestino destino;
        private DataAtual data;
        private ManterVeiculo utilVeiculos;
        private ManterDestino utilDestino;
		private ValidaForm valida;

        public frmAdicionarDestino(EncVeiculos veiculos)
        {
			InitializeComponent();
			this.veiculos = veiculos;
			lblIdEX.Text = veiculos.IdV;
			data = new DataAtual();
			txtDataSaida.Text = data.Data();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dataSaida = txtDataSaida.Text;
            ruaDestino = txtRuaDestino.Text;
            ruaSaida = txtRuaSaida.Text;

            destino = new EncDestino(dataSaida, veiculos.IdV, ruaDestino, ruaSaida);
            utilDestino = new ManterDestino();
            utilVeiculos = new ManterVeiculo();
			valida = new ValidaForm();

			if (valida.ValidaF(destino))
			{
				txtDataSaida.Focus();
			}
            else if (utilDestino.Incluir(destino))
            {
                MessageBox.Show("O Veiculo foi Adicionado a um destino");
                utilVeiculos.AtualizarDisp(veiculos, false);
                Close();
            }
            else
            {
                MessageBox.Show("O Veiculo não Adicionado a um destino");
            }
        }
    }
}
