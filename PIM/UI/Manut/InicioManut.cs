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

namespace PIM.UI.Manut
{
    public partial class frmInicioManut : Form
    {
        private ManterManut utilManut;
        private EncVeiculos veiculo;
        private EncManut manut;
        private string id, nome, marca, placa, chassi, km, categ, saida, entrada, idManut, observ;

        public frmInicioManut()
        {
            InitializeComponent();
            utilManut = new ManterManut();
            AtualizarListar();
        }

        private void chekManut_CheckedChanged(object sender, EventArgs e)
        {
            if (chekManut.Checked)
            {
                try
                {
                    DataTable dtResultado = utilManut.Listar().Tables[0].Select("Saida=''").CopyToDataTable();
                    dgManut.DataSource = dtResultado;
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
                DataTable dtResultado = utilManut.Listar().Tables[0].Select("Placa='" + txt + "'").CopyToDataTable();
                dgManut.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("Não Localizado");
            }
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
            dgManut.DataSource = utilManut.Listar().Tables[0];
            dgManut.Columns["Categoria"].Visible = false;
            dgManut.Columns["Chassi"].Visible = false;
            dgManut.Columns["Marca"].Visible = false;
            dgManut.Columns["Id_Manut"].Visible = false;
            dgManut.Columns["Observacao"].Visible = false;
        }

        private void dgManut_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgManut.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                marca = row.Cells[2].Value + string.Empty;
                placa = row.Cells[3].Value + string.Empty;
                chassi = row.Cells[4].Value + string.Empty;
                km = row.Cells[5].Value + string.Empty;
                categ = row.Cells[6].Value + string.Empty;
                observ = row.Cells[7].Value + string.Empty;
                idManut = row.Cells[8].Value + string.Empty;
                saida = row.Cells[9].Value + string.Empty;
                entrada = row.Cells[10].Value + string.Empty;
            }

            veiculo = new EncVeiculos(id, nome, marca, placa, chassi, km, categ);
            manut = new EncManut(entrada, saida, observ, idManut);
        }

        private void dgManut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           //Não Uitilizado
        }
        private void dgManut_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormulario(new frmAtulizarManut(veiculo, manut));
        }

    }
}
