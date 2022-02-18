using PimDLL.BLL;
using PimDLL.DTO;
using System;
using System.Data;
using System.Windows.Forms;

namespace PIM.UI.Motorista
{
    public partial class frmInicioMotorista : Form
    {
        private EncMotorista motorista;
        private ManterMotorista utilMotorista;
        private string id, nome, login, senha, acesso, cpf, rg, cargo, salario, endereco , cnh, idVeiculo;

        private void btnLocalizar_Click(object sender, System.EventArgs e)
        {
            string txt = txtLocalizar.Text;
            try
            {
                DataTable dtResultado = utilMotorista.ListarMotorista().Tables[0].Select("RG ='" + txt + "'").CopyToDataTable();
                dgMotorista.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ID Não Localizado");
            }
        }

        public frmInicioMotorista()
        {
            utilMotorista = new ManterMotorista();
            InitializeComponent();
            AtualizarTabela();
        }

        private void dgMotorista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AbrirFormulario(new frmAtualizarMotorista(motorista));
        }

        private void dgMotorista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgMotorista.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                login = row.Cells[2].Value + string.Empty;
                senha = row.Cells[3].Value + string.Empty;
                acesso = row.Cells[4].Value + string.Empty;
                cpf = row.Cells[5].Value + string.Empty;
                rg = row.Cells[6].Value + string.Empty;
                cargo = row.Cells[7].Value + string.Empty;
                salario = row.Cells[8].Value + string.Empty;
                endereco = row.Cells[9].Value + string.Empty;
                cnh = row.Cells[10].Value + string.Empty;
                idVeiculo = row.Cells[11].Value + string.Empty;
            }
            motorista = new EncMotorista(id, nome, login, senha, acesso, cpf, rg, cargo, salario, endereco, cnh , idVeiculo);
        }

        private void AtualizarTabela()  //função que chama o DataSet e coloca do DataGrid
        {
            dgMotorista.DataSource = utilMotorista.ListarMotorista().Tables[0];
            dgMotorista.Columns["Senha"].Visible = false;
            //dgFuncionario.Columns["RG"].Visible = false;
            //dgFuncionario.Columns["CPF"].Visible = false;
            dgMotorista.Columns["Acesso"].Visible = false;
            dgMotorista.Columns["Login"].Visible = false;
            dgMotorista.Columns["Salario"].Visible = false;
            dgMotorista.Columns["Endereço"].Visible = false;
            dgMotorista.Columns["Cnh"].Visible = false;
        }

        private void btnIncluir_Click(object sender, System.EventArgs e)
        {
            AbrirFormulario(new frmIncluirMotorista());
        }

        private void btnAtualizar_Click(object sender, System.EventArgs e)
        {
            AtualizarTabela();
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
    }
}
