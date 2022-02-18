using PIM.UI.Veiculos;
using PimDLL.BLL;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.UI.Gerente.Contratos
{
    public partial class frmIncluirContrato : Form
    {
        EncContrato contrato;
		EncCliente cliente;
        ManterContrato utilContrato;
		ValidaForm valida;


		public frmIncluirContrato(EncCliente cliente)
		{
			this.cliente = cliente;
			InitializeComponent();
			txtVagas.ReadOnly = true;
			
		}

	private void btnIncluir_Click(object sender, EventArgs e) //Botão que recebe e envia os campos para cadastrar
        {
            string nome = cbPlano.Text;
			string vagas = txtVagas.Text;
			string rg = cliente.RgCl;

			valida = new ValidaForm();
            contrato = new EncContrato(nome,vagas);
			utilContrato = new ManterContrato();
			if (valida.ValidaF(contrato))
			{
				cbPlano.Focus();

			}
            else if (utilContrato.Inserir(contrato))
            {
				MessageBox.Show("O Contrato foi Incluido");

				contrato.IdClienteC = cliente.Idcl;
				utilContrato.AtualizarCliente(contrato);
				Close();
			}
            else
            {
                MessageBox.Show("O Contrato não foi Incluido");
                cbPlano.Focus();
            }
         }

		private void cbPlano_SelectedIndexChanged(object sender, EventArgs e)
		{
			string plano = cbPlano.Text;

			if (plano == "Personalizado")
			{
				txtVagas.ReadOnly = false;
			}
			else if (plano == "10 Vagas")
			{
				txtVagas.ReadOnly = true;
				txtVagas.Text = "10";
			}
			else if (plano == "20 Vagas")
			{
				txtVagas.ReadOnly = true;
				txtVagas.Text = "20";
			}
			else if (plano == "30 Vagas")
			{
				txtVagas.ReadOnly = true;
				txtVagas.Text = "30";
			}
		}
	}
}
