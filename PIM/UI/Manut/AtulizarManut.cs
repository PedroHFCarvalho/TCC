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
using PimDLL.DTO;

namespace PIM.UI.Manut
{
    public partial class frmAtulizarManut : Form
    {
        private EncManut manut;
        private EncVeiculos veiculos;
        private ManterManut utilManut;
        private ManterVeiculo utilVeiculo;
        private DataAtual data;

        public frmAtulizarManut(EncVeiculos veiculo, EncManut manut)
        {
            this.veiculos = veiculo;
            this.manut = manut;
            InitializeComponent();
            AtualizarCampos();
            if (manut.DataSaida != "")
            {
                btnAtualizar.Visible = false;
            }
                        
        }

        public void AtualizarCampos() //recebe os campos permanentes
        {
            lblIdEX.Text = veiculos.IdV;
            lblNomeEX.Text = veiculos.NomeV;
            lblMarcaEX.Text = veiculos.MarcaV;
            lblPlacaEX.Text = veiculos.PlacaV;
            lblChassiEX.Text = veiculos.ChassiV;
            lblKmEX.Text = veiculos.KmV;
            lblCategoriaEX.Text = veiculos.CategV;
            lblDtEntradaEX.Text = manut.DataEntrada;
            lblDtSaidaEX.Text = manut.DataSaida;
            txtObserv.Text = manut.Observ;
        }

        private void lblkEditar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) //botão que abre aba de editar
        {
            //plAtualizar.Visible = true;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            data = new DataAtual();
            manut.DataSaida = data.Data();
            manut.IdVeiculo = veiculos.IdV;
            utilManut = new ManterManut();
            utilVeiculo = new ManterVeiculo();
          

                if (utilManut.Atualizar(manut))
                {
                    MessageBox.Show("A Manutenção foi Finalizada");
                    utilVeiculo.AtualizarDisp(veiculos, true);
                    

                    AtualizarCampos();
                }
                else
                {
                    MessageBox.Show("A Manutenção não foi Finalizada");
                    AtualizarCampos();
                }           
        }
    }
}
