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
    public partial class frmAtualizarFuncionario : Form
    {
        private EncFuncionario funcionario;
        ManterFuncionario utilFuncionario;
        

        public frmAtualizarFuncionario(EncFuncionario f)
        {
            InitializeComponent();
            this.funcionario = f;
            plEditar.Visible = false;
            AtualizarCampos();  //Ataualiza os Camapos Permanantes
        }

        public void AtualizarCampos() //Recebe os Camapos Permanantes
        {
            lblNomeEX.Text = funcionario.NomeF;
            lblLoginEX.Text = funcionario.LoginF;
            lblSenhaEX.Text = funcionario.SenhaF;
            lblAcessoEX.Text = funcionario.AcessoF;
            lblCpfEX.Text = funcionario.CpFF;
            lblRgEX.Text = funcionario.RgF;
            lblCargoEX.Text = funcionario.CargoF;
            lblSalarioEX.Text = funcionario.SalarioF;
            lblEnderecoEX.Text = funcionario.EnderecoF;
            lblIdEX.Text = funcionario.IdF;
        }


        private void lblkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Botão Excluir
        {
            if (MessageBox.Show("Deseja Excluir o Funcionario", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utilFuncionario = new ManterFuncionario();
                if (utilFuncionario.Excluir(funcionario.LoginF))
                {
                    MessageBox.Show("O Funcionario Foi Deletado");
                    Close();
                }
                else
                {
                    MessageBox.Show("O Funcionario Foi Deletado");
                    Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) //Botão que faz a atualização dos campos 
        {
            if (txtNome.Text != "")
            {
                funcionario.NomeF = txtNome.Text;
            }
            if (txtLogin.Text != "")
            {
                funcionario.LoginF = txtLogin.Text;
            }
            if (txtSenha.Text != "")
            {
                funcionario.SenhaF = txtSenha.Text;
            }
            if (txtAcesso.Text != "")
            {
                funcionario.AcessoF = txtAcesso.Text;
            }
            if (txtCpf.Text != "")
            {
                funcionario.CpFF = txtCpf.Text;
            }
            if (txtRg.Text != "")
            {
                funcionario.RgF = txtRg.Text;
            }
            if (txtCargo.Text != "")
            {
                funcionario.CargoF = txtCargo.Text;
            }
            if (txtSalario.Text != "")
            {
                funcionario.SalarioF = txtSalario.Text;
            }
            if (txtEndereco.Text != "")
            {
                funcionario.EnderecoF = txtEndereco.Text;
            }

            utilFuncionario = new ManterFuncionario();

            if (utilFuncionario.Atualizar(funcionario))
            {
                MessageBox.Show("Os campos foram atualizado");
                AtualizarCampos();
            }
            else
            {
                MessageBox.Show("Os campos não foram atualizado");
                AtualizarCampos();
            }
        }

        private void lblkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão que abre os campos editar
        {
            plEditar.Visible = true;
        }

        private void btnFecharEdit_Click(object sender, EventArgs e)
        {
            plEditar.Visible = false;
        }
    }
}
