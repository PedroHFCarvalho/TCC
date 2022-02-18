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

namespace PIM.UI.Gerente.Contratos
{
    public partial class frmAtualizarContrato : Form
    {
        private EncContrato contrato;
        ManterContrato utilContrato;

        public frmAtualizarContrato(EncContrato c)
        {
            this.contrato = c;
            InitializeComponent();
            AtualizarCampos(); //Ataualiza os Campos Permanantes
            AtualizarVeiculos(); //Atualiza o DataGrid dos veiculos
            plEditar.Visible = false;

        }

        public void AtualizarCampos() //Recebe os Camapos Permanantes
        {
            lblNomeEX.Text = contrato.NomeC;
            lblVagasEX.Text = contrato.VagasC;
            lblIdEX.Text = contrato.IdC;
			lblClienteEX.Text = contrato.NomeClienteC;
		}

        private void lblkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //Botão Excluir
        {
            if (MessageBox.Show("Deseja Excluir o Contrato", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utilContrato = new ManterContrato();
                string id = contrato.IdC;
                if (utilContrato.Excluir(id))
                {
                    MessageBox.Show("O Contrato Foi Deletado");
                    Close();
                }
                else
                {
                    MessageBox.Show("O Contrato Foi Deletado");
                    Close();
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e) //Botão que faz a atualização dos campos 
        {
            if (txtNome.Text != "")
            {
                contrato.NomeC = txtNome.Text;
            }
            if (txtVagas.Text != "")
            {
                contrato.VagasC = txtVagas.Text;
            }
            utilContrato = new ManterContrato();

            if (utilContrato.Atualizar(contrato))
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

        private void lblkVeisculosR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão que atualiza o DataGrid dos veiculos
        {
            AtualizarVeiculos();
        }

        private void AtualizarVeiculos()
        {
            utilContrato = new ManterContrato();
            dgVeiculosR.DataSource = utilContrato.ListarVeiculo(contrato.IdC).Tables[0];
        }

        private void lblkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão que abre os campos editar
        {
            plEditar.Visible = true;
        }

        private void lblkAddVeiculo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // botão que abre a aba de add veiculo
        {
            new frmAddVeiculo(contrato).ShowDialog();
        }

        private void btnFecharEdit_Click(object sender, EventArgs e)
        {
            plEditar.Visible = false;
        }
    }
}
