using PIM.UI.Gerente.Contratos;
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

namespace PIM.UI.Cliente
{
    public partial class frmIncluirCliente : Form
    {
        EncCliente cliente;
        ManterCliente utilcliente;
		ValidaForm valida;
		private int rec;

        public frmIncluirCliente()
        {
			this.rec = 0;
            InitializeComponent();
        }
		private void btnIncluir_Click(object sender, EventArgs e) //Botão que recebe e envia os campos para cadastrar
        {
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            string endereco = txtEndereco.Text;

			valida = new ValidaForm();
            cliente = new EncCliente(nome, login, senha, rg, cpf, endereco);
            utilcliente = new ManterCliente();

			if (valida.ValidaF(cliente))
			{
				txtNome.Focus();
			}
            if (utilcliente.IncluirCliente(cliente))
            {
                MessageBox.Show("O Cliente foi Incluido");
				Close();
			}
            else
            {
                MessageBox.Show("O Cliente não foi Incluido");
                txtNome.Focus();
            }
        }
    }
}
