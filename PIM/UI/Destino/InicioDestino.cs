using PimDLL.BLL;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.UI.Destino
{
    public partial class frmInicioDestino : Form
    {
        private ManterDestino utilDestino;
        private EncVeiculos veiculo;
        private EncDestino destino;
        private string id, nome, marca, placa, chassi, km, categ, idRota, dataSaida, dataChegada, kmChegada, ruaSaida, RuaDestino;

        private void chekRodando_CheckedChanged(object sender, EventArgs e)
        {
            if (chekRodando.Checked)
            {
                try
                {
                    DataTable dtResultado = utilDestino.Listar().Tables[0].Select("Chegada=''").CopyToDataTable();
                    dgDestino.DataSource = dtResultado;
                }
                catch (Exception)
                {
                }
            }
            else
            {
                AtualizarListar();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string txt = txtLocalizar.Text;
            try
            {
                DataTable dtResultado = utilDestino.Listar().Tables[0].Select("Placa='" + txt + "'").CopyToDataTable();
                dgDestino.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Não Localizado");
            }
        }

        public frmInicioDestino()
        {
            InitializeComponent();
            utilDestino = new ManterDestino();
            AtualizarListar();
        }
        private void AbrirFormulario(object formulario) //função que abre outra aba no mesmo forms
        {
            if (this.plManterFuncionario.Controls.Count > 0)
            {
                this.plManterFuncionario.Controls.RemoveAt(0);
            }
			plManterFuncionario.Controls.Clear();
			Form novo = formulario as Form;
            novo.TopLevel = false;
            novo.Dock = DockStyle.Fill;
            this.plManterFuncionario.Controls.Add(novo);
            this.plManterFuncionario.Tag = novo;
            novo.Show();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarListar();
        }

        private void AtualizarListar()
        {
            dgDestino.DataSource = utilDestino.Listar().Tables[0];
            dgDestino.Columns["Chassi"].Visible = false;
            dgDestino.Columns["Id_Rota"].Visible = false;
            dgDestino.Columns["Km_Chegada"].Visible = false;
            dgDestino.Columns["Km"].Visible = false;
            dgDestino.Columns["Rua_Saida"].Visible = false;
            dgDestino.Columns["Rua_Destino"].Visible = false;
        }

        private void dgDestino_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormulario(new frmAtualizarDestino(veiculo, destino));
        }

        private void dgDestino_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgDestino.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                marca = row.Cells[2].Value + string.Empty;
                placa = row.Cells[3].Value + string.Empty;
                chassi = row.Cells[4].Value + string.Empty;
                km = row.Cells[5].Value + string.Empty;
                categ = row.Cells[6].Value + string.Empty;
                idRota = row.Cells[7].Value + string.Empty;
                dataSaida = row.Cells[8].Value + string.Empty;
                dataChegada = row.Cells[9].Value + string.Empty;
                kmChegada = row.Cells[10].Value + string.Empty;
                ruaSaida = row.Cells[11].Value + string.Empty;
                RuaDestino = row.Cells[12].Value + string.Empty;
            }

            veiculo = new EncVeiculos(id, nome, marca, placa, chassi, km, categ);
            destino = new EncDestino(idRota, dataSaida, dataChegada, ruaSaida, RuaDestino, kmChegada);
        }
    }
}
