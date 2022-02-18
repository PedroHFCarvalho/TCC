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

namespace PIM.UI.Funcionario
{
    public partial class frmIncluirFuncionario : Form
    {
        private EncFuncionario funcionario;
        private ManterFuncionario utilFuncionario;
		private ValidaForm valida;

        public frmIncluirFuncionario()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, EventArgs e) //Botão que recebe e envia os campos para cadastrar
        {
            string nome = txtNome.Text;
            string login = txtLogin.Text;
            string senha = txtSenha.Text;
            string acesso = txtAcesso.Text;
            string cpf = txtCPF.Text;
            string rg = txtRG.Text;
            string cargo = txtCargo.Text;
            string salario = txtSalario.Text;
            string endereco = txtEndereco.Text;

			valida = new ValidaForm();
            funcionario = new EncFuncionario(nome, login, senha, acesso, cpf, rg, cargo, salario, endereco);
            utilFuncionario = new ManterFuncionario();

			if (valida.ValidaF(funcionario))
			{
				txtNome.Focus();
			}
            else if (utilFuncionario.IncluirFuncionario(funcionario))
            {
                MessageBox.Show("O Funcionario foi Incluido");
                Close();
            }
            else
            {
                MessageBox.Show("O Funcionario não foi Incluido");
                txtNome.Focus();
            }          
        }
    }
}
