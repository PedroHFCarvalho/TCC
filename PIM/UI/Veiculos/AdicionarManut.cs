using PimDLL.DTO;
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

namespace PIM.UI.Veiculos
{
    public partial class frmAdicionarManut : Form
    {
        private string entrada, observ;
        private EncManut manut;
        private ManterManut utilManut;
        private ManterVeiculo utilVeiculos;
        private DataAtual data;
        private EncVeiculos veiculos;
		private ValidaForm valida;

        public frmAdicionarManut(EncVeiculos veiculos)
        {
            InitializeComponent();
            this.veiculos = veiculos;
            lblIdEX.Text = veiculos.IdV;
            data = new DataAtual();
            txtEntrada.Text = data.Data();         
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           
            entrada = txtEntrada.Text;
            observ = txtObserv.Text;

            manut = new EncManut(entrada, veiculos.IdV, observ);
            utilManut = new ManterManut();
            utilVeiculos = new ManterVeiculo();
			valida = new ValidaForm();

			if (valida.ValidaF(manut))
			{
				txtObserv.Focus();
			}
            else if (utilManut.Incluir(manut))
            {
                MessageBox.Show("O Veiculo foi Adicionado a Lista de Manutenção");
                utilVeiculos.AtualizarDisp(veiculos , false);
                Close();
            }
            else
            {
                MessageBox.Show("O Veiculo não Adicionado a Lista de Manutenção");
            }
        }
    }
}
