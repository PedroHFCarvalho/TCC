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

namespace PIM.UI.Cliente
{
    public partial class frmInicioCliente : Form
    {
        private EncCliente cliente;
        private ManterCliente utilCliente;
        private string id, nome, login, senha, endereco, rg, cpf;

        public frmInicioCliente()
        {
            InitializeComponent();
            utilCliente = new ManterCliente();
            AtualizarTabela(); // Aualiza O DataGrid com todos os clientes
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string txt = txtLocalizar.Text;
            try
            {
                DataTable dtResultado = utilCliente.Listar().Tables[0].Select("Id =" + txt).CopyToDataTable();
                dgCliente.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ID Não Localizado");
            }

            
        }

		private void lblRg_Click(object sender, EventArgs e)
		{

		}

		private void lblCPF_Click(object sender, EventArgs e)
		{

		}

		private void lblSenha_Click(object sender, EventArgs e)
		{

		}

		private void lblLogin_Click(object sender, EventArgs e)
		{

		}

		private void lblNome_Click(object sender, EventArgs e)
		{

		}

		private void dgContratoR_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void lblEndereco_Click(object sender, EventArgs e)
		{

		}

		private void dgCliente_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //função que abre os campos especificos do cliente
        {
            AbrirFormulario(new frmAtualizarCliente(cliente));
        }

        private void btnIncluir_Click(object sender, EventArgs e) //Botão que chama a aba incluir
        {
            AbrirFormulario(new frmIncluirCliente().FormBorderStyle = FormBorderStyle.None);
		}

        private void btnAtualizar_Click(object sender, EventArgs e) //botão que ataualiza o DataGrid
        {
            AtualizarTabela();
        }

        private void dgCliente_CellClick(object sender, DataGridViewCellEventArgs e) //Função que recebe todos os dados ao click no DataGrid e cria uma class com os dados
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgCliente.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                login = row.Cells[2].Value + string.Empty;
                senha = row.Cells[3].Value + string.Empty;
                cpf = row.Cells[4].Value + string.Empty;
                rg = row.Cells[5].Value + string.Empty;
                endereco = row.Cells[6].Value + string.Empty;
                
            }
            cliente = new EncCliente(id, nome, login, senha, rg, cpf, endereco);
        }

        private void AbrirFormulario(object formulario) //função que abre outra aba no mesmo forms
        {
            if (this.plManterCliente.Controls.Count > 0)
            {
                this.plManterCliente.Controls.RemoveAt(0);
            }
			plManterCliente.Controls.Clear();
            Form novo = formulario as Form;
            novo.TopLevel = false;
            novo.Dock = DockStyle.Fill;
            this.plManterCliente.Controls.Add(novo);
            this.plManterCliente.Tag = novo;
            novo.Show();
			
		}
        private void AtualizarTabela() //função que chama o DataSet e coloca do DataGrid
        {
            dgCliente.DataSource = utilCliente.Listar().Tables[0];
            dgCliente.Columns["Login"].Visible = false;
            dgCliente.Columns["Senha"].Visible = false;
            dgCliente.Columns["Endereço"].Visible = false;
        }
    }
}
