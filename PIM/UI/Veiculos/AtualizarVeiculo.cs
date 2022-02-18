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

namespace PIM.UI.Veiculos
{
    public partial class frmAtualizarVeiculo : Form
    {
        private EncVeiculos veiculos;
        private ManterVeiculo utilVeiculos;

        public frmAtualizarVeiculo(EncVeiculos v)
        {
            InitializeComponent();
            this.veiculos = v;
            plAtualizar.Visible = false;
            AtualizarCampos(); //Atualiza os campos permanentes
        }

        public void AtualizarCampos() //recebe os campos permanentes
        {
            lblIdEX.Text = veiculos.IdV;
            lblNomeEX.Text = veiculos.NomeV;
            lblMarcaEX.Text = veiculos.MarcaV;
            lblPlacaEX.Text = veiculos.PlacaV;
            lblChassiEX.Text = veiculos.ChassiV;
            lblKmEX.Text = veiculos.KmV;
            lblDisponibilidadeEX.Text = veiculos.DispV;
            lblCategoriaEX.Text = veiculos.CategV;
        }

        private void btnAtualizar_Click(object sender, EventArgs e) //botão atualizar
        {
            {
                if (txtNome.Text != "")
                {
                    veiculos.NomeV = txtNome.Text;
                }
                if (cbMarca.Text != "")
                {
                    veiculos.MarcaV = cbMarca.Text;
                }
                if (txtPlaca.Text != "")
                {
                    veiculos.PlacaV = txtPlaca.Text;
                }
                if (txtChassi.Text != "")
                {
                    veiculos.ChassiV = txtChassi.Text;
                }
                if (txtKm.Text != "")
                {
                    veiculos.KmV = txtKm.Text;
                }
                if (cbCategoria.Text != "")
                {
                    veiculos.CategV = cbCategoria.Text;
                }
                utilVeiculos = new ManterVeiculo();

                if (utilVeiculos.Atualizar(veiculos))
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
        }

        private void lblkExcluir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão excluir
        {

            if (MessageBox.Show("Deseja Excluir o Veiculo", "Confirmação", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utilVeiculos = new ManterVeiculo();
                string chassi = veiculos.ChassiV;
                if (utilVeiculos.Excluir(chassi))
                {
                    MessageBox.Show("O Veiculo foi Deletado");
                    Close();
                }
                else
                {
                    MessageBox.Show("O Veiculo não foi Deletado");
                    Close();
                }
            }
        }

        private void lblkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão que abre aba de editar
        {
            plAtualizar.Visible = true;
        }

        private void addManut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAdicionarManut(veiculos).ShowDialog();
            AtualizarCampos();
        }

        private void btnFecharEdit_Click(object sender, EventArgs e)
        {
            plAtualizar.Visible = false;
        }

        private void AddDestino_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmAdicionarDestino(veiculos).ShowDialog();
            AtualizarCampos();
        }
    }
}
