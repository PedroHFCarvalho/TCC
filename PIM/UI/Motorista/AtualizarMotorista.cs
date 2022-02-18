using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PimDLL.DTO;
using PimDLL.BLL;

namespace PIM.UI.Motorista
{
    public partial class frmAtualizarMotorista : Form
    {
        private EncMotorista motorista;
        private ManterFuncionario utilFuncionario;
        private ManterMotorista utilMotorista;

        public frmAtualizarMotorista(EncMotorista m)
        {
            InitializeComponent();
            plEditar.Visible = false;
            this.motorista = m;
            AtualizarCampos();
        }


        public void AtualizarCampos() //Recebe os Camapos Permanantes
        {
            lblNomeEX.Text = motorista.NomeF;
            lblLoginEX.Text = motorista.LoginF;
            lblSenhaEX.Text = motorista.SenhaF;
            lblAcessoEX.Text = motorista.AcessoF;
            lblCpfEX.Text = motorista.CpFF;
            lblRgEX.Text = motorista.RgF;
            lblCargoEX.Text = motorista.CargoF;
            lblSalarioEX.Text = motorista.SalarioF;
            lblEnderecoEX.Text = motorista.EnderecoF;
            lblCnhEX.Text = motorista.Cnh;
            lblIdEX.Text = motorista.IdF;
            utilMotorista = new ManterMotorista();
            utilMotorista.IdentificarVeiculo(motorista);
            lblVeicAtualEX.Text = motorista.IdVeiculo;

        }

        private void lblkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            plEditar.Visible = true;
        }

        private void lblkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Funcionario", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utilFuncionario = new ManterFuncionario();
                utilMotorista = new ManterMotorista();
                if (utilMotorista.Excluir(motorista.IdF)) {
                    if (utilFuncionario.Excluir(motorista.LoginF))
                    {
                        MessageBox.Show("O Funcionario Foi Deletado");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("O Funcionario Foi Deletado");
                    Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        { 
            if (txtNome.Text != "")
            {
                motorista.NomeF = txtNome.Text;
            }
            if (txtLogin.Text != "")
            {
                motorista.LoginF = txtLogin.Text;
            }
            if (txtSenha.Text != "")
            {
                motorista.SenhaF = txtSenha.Text;
            }
            if (txtAcesso.Text != "")
            {
                motorista.AcessoF = txtAcesso.Text;
            }
            if (txtCpf.Text != "")
            {
                motorista.CpFF = txtCpf.Text;
            }
            if (txtRg.Text != "")
            {
                motorista.RgF = txtRg.Text;
            }
            if (txtCargo.Text != "")
            {
                motorista.CargoF = txtCargo.Text;
            }
            if (txtSalario.Text != "")
            {
                motorista.SalarioF = txtSalario.Text;
            }
            if (txtEndereco.Text != "")
            {
                motorista.EnderecoF = txtEndereco.Text;
            }
            if (txtCnh.Text != "")
            {
                motorista.Cnh = txtCnh.Text;            
               
            }
            utilFuncionario = new ManterFuncionario();
            utilMotorista = new ManterMotorista();


            if (utilFuncionario.Atualizar(motorista))
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

        private void btnFecharEdit_Click(object sender, EventArgs e)
        {
            plEditar.Visible = false;
        }

        private void addVeiculo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAddMotoristaVeiculo(motorista).ShowDialog();
        }
    }
}
