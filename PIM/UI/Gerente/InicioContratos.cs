using PIM.UI.Gerente;
using PIM.UI.Gerente.Contratos;
using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIM.UI.Gerente
{
    public partial class frmIncioContratos : Form
    {
        private EncContrato contrato;
        private ManterContrato utilContrato;
		private string id, nome, vagas , idCliente, nomeCliente;

        public frmIncioContratos()
        {
            InitializeComponent();
            utilContrato = new ManterContrato();
            AtualizarTabela(); // Aualiza O DataGrid com todos os contratos
        }

        private void dgContratos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //função que abre os campos especificos do contrato
        {
            AbrirFormulario(new frmAtualizarContrato(contrato));
        }

        private void btnIncluir_Click(object sender, EventArgs e) //Botão que chama a aba incluir
        {
           // AbrirFormulario(new frmIncluirContrato().FormBorderStyle = FormBorderStyle.None);
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string txt = txtLocalizar.Text;
            try
            {
                DataTable dtResultado = utilContrato.Listar().Tables[0].Select("Id =" + txt).CopyToDataTable();
                dgContratos.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ID Não Localizado");
            }

        }

        private void txtLocalizar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgContratos_CellClick(object sender, DataGridViewCellEventArgs e) //Função que recebe todos os dados ao click no DataGrid e cria uma class com os dados
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgContratos.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                vagas = row.Cells[2].Value + string.Empty;
				idCliente = row.Cells[3].Value + string.Empty;
				nomeCliente = row.Cells[4].Value + string.Empty;
			}
            contrato = new EncContrato(id, nome, vagas, idCliente, nomeCliente);
        }

        private void AtualizarTabela() //função que chama o DataSet e coloca do DataGrid
        {
            dgContratos.DataSource = utilContrato.Listar().Tables[0];
			dgContratos.Columns["Nome Cliente"].Visible = false;
        }
        private void btnAtualizar_Click(object sender, EventArgs e) //botão que ataualiza o DataGrid
        {
            AtualizarTabela();
        }
        private void AbrirFormulario(object formulario) //função que abre outra aba no mesmo forms
        {
            if (this.plManterContrato.Controls.Count > 0)
            {
                this.plManterContrato.Controls.RemoveAt(0);
            }
			plManterContrato.Controls.Clear();
            Form novo = formulario as Form;
            novo.TopLevel = false;
            novo.Dock = DockStyle.Fill;
            this.plManterContrato.Controls.Add(novo);
            this.plManterContrato.Tag = novo;
            novo.Show();
        }
    }
}
