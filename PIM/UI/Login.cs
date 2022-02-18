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
using PIM.UI;

namespace PIM
{
    public partial class frmLogin : Form
    {
        private EncLogin Login;
        private LiberacaoLogin Lib;
        private ValidaForm VForm;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            Login = new EncLogin(login, senha); //Encapsula os dados da tela na classe 
            Lib = new LiberacaoLogin(Login); //Executa a classe de validação do login retorna um bool
            VForm = new ValidaForm(); //Faz a validação do campos retorna um bool
                
            if (VForm.ValidaF(Login))
            {
                txtLogin.Focus();
            }
            else if (Lib.Liberacao())
            {

                new frmMenuPrincipal().ShowDialog();
            }
            else
            {
                MessageBox.Show("A senha ou o login estão errados");
            }
        }
    }
}
