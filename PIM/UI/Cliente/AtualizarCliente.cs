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
using PIM.UI.Gerente.Contratos;

namespace PIM.UI.Cliente
{
    public partial class frmAtualizarCliente : Form
    {
        private EncCliente cliente;
        ManterCliente utilCliente;
        ManterContrato utilContrato;

        public frmAtualizarCliente(EncCliente c)
        {
            this.cliente = c;
            InitializeComponent();
            AtualizarCampos(); //Ataualiza os Camapos Permanantes do cliente
            AtaualizarContrato(); //Atualiza o DataGrid dos contratos
            plEditar.Visible = false;
        }

        public void AtualizarCampos() //Recebe os Camapos Permanantes do cliente
        {
            lblNomeEX.Text = cliente.NomeCl;
            lblLoginEX.Text = cliente.LoginCl;
            lblSenhaEX.Text = cliente.SenhaCl;          
            lblCpfEX.Text = cliente.CpfCl;
            lblRgEX.Text = cliente.RgCl;        
            lblEnderecoEX.Text = cliente.EnderecoCl;
            lblIdEX.Text = cliente.Idcl;
        }

        private void lblkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Botão Excluir Cliente
        {
            if (MessageBox.Show("Deseja Excluir o Cliente", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utilCliente = new ManterCliente();
                string id = cliente.Idcl;
                if (utilCliente.Excluir(id))
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
                cliente.NomeCl = txtNome.Text;
            }
            if (txtLogin.Text != "")
            {
                cliente.LoginCl = txtLogin.Text;
            }
            if (txtSenha.Text != "")
            {
                cliente.SenhaCl = txtSenha.Text;
            }
            if (txtCpf.Text != "")
            {
                cliente.CpfCl = txtCpf.Text;
            }
            if (txtRg.Text != "")
            {
                cliente.RgCl = txtRg.Text;
            }           
            if (txtEndereco.Text != "")
            {
                cliente.EnderecoCl = txtEndereco.Text;
            }

            utilCliente = new ManterCliente();

            if (utilCliente.Atualizar(cliente))
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

        private void AtaualizarContrato() //função que chamas o dataset
        {
            utilContrato = new ManterContrato();
            dgContratoR.DataSource = utilContrato.AtualizarContrato(cliente.Idcl).Tables[0];
        }

        private void lblkAddVeiculo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
			new frmAddContrato(cliente).ShowDialog();
		}

        private void btnFecharEdit_Click(object sender, EventArgs e)
        {
            plEditar.Visible = false;
        }
    }
}
