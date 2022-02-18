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

namespace PIM.UI.Destino
{
    public partial class frmAtualizarDestino : Form
    {
        private EncDestino destino;
        private EncVeiculos veiculos;
        private DataAtual data;
        private ManterVeiculo utilVeiculo;
        private ManterDestino utilDestino;

        public frmAtualizarDestino(EncVeiculos veiculo, EncDestino destino)
        {
            InitializeComponent();
            this.veiculos = veiculo;
            this.destino = destino;
            AtualizarCampos();
            if (destino.DataChegada != "")
            {
                plEntregar.Visible = false;
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
            lblDtChegadaEX.Text = destino.DataChegada;
            lblDtSaidaEX.Text = destino.DataSaida;
            lblRuaDestinoEX.Text = destino.RuaDestino;
            lblRuaSaidaEX.Text = destino.RuaSaida;
            lblKmChegadaEX.Text = destino.Km;
        }

        private void btnEntregar_Click(object sender, EventArgs e)
        {
            if (txtKmChegada.Text != "")
            {
                data = new DataAtual();
                destino.DataChegada = data.Data();
                destino.IdVeiculo = veiculos.IdV;
                utilDestino = new ManterDestino();
                utilVeiculo = new ManterVeiculo();
                destino.Km = txtKmChegada.Text;
                int attKmDestno = Convert.ToInt32(destino.Km);
                int attKmVeiculo = Convert.ToInt32(veiculos.KmV);
                veiculos.KmV = Convert.ToString(attKmDestno + attKmVeiculo);   

                if (utilDestino.Atualizar(destino))
                {
                    MessageBox.Show("O Destino foi Finalizada");
                    utilVeiculo.AtualizarDisp(veiculos, true);
                    utilVeiculo.AtualizarKm(veiculos);
                    AtualizarCampos();
                }
                else
                {
                    MessageBox.Show("o Destino não foi Finalizada");
                    AtualizarCampos();
                }
            }
            else
            {
                MessageBox.Show("Preencha o campo de quilometragem");
            }
        }
    }
}
