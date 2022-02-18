using PimDLL.BLL;
using PimDLL.DTO;
using System.Windows.Forms;

namespace PIM.UI.Motorista
{
    public partial class frmIncluirMotorista : Form
    {
        private EncMotorista motorista;
        private ManterFuncionario utilFuncionario;
        private ManterMotorista utilMotorista;
		private ValidaForm valida;

        public frmIncluirMotorista()
        {
            InitializeComponent();
        }

        private void btnIncluir_Click(object sender, System.EventArgs e)
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
            string cnh = txtCnh.Text;

			valida = new ValidaForm();
            motorista = new EncMotorista(nome, login, senha, acesso, cpf, rg, cargo, salario, endereco,cnh);
            utilFuncionario = new ManterFuncionario();
            utilMotorista = new ManterMotorista();

			if (valida.ValidaF(motorista))
			{
				txtNome.Focus();
			}
            else if (utilFuncionario.IncluirFuncionario(motorista))
            {
                if (utilMotorista.InserirIdMotorista(motorista))
                {
                    MessageBox.Show("O Motorista foi Incluido");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("O Motorista não foi Incluido");
                txtNome.Focus();
            }
        }
    }
}
