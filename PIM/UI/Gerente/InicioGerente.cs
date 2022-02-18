using PimDLL.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace PIM.UI.Funcionario
{
    public partial class frmInicioGerente : Form
    {
        private EncFuncionario funcionario;
        private ManterFuncionario utilFuncionario;
        private string id, nome, login, senha, acesso, cpf, rg, cargo, salario, endereco;

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            string txt = txtLocalizar.Text;
            try
            {
                DataTable dtResultado = utilFuncionario.Listar().Tables[0].Select("RG ='"+txt+"'").CopyToDataTable();
                dgFuncionario.DataSource = dtResultado;
            }
            catch (Exception)
            {
                MessageBox.Show("ID Não Localizado");
            }
        }

        public frmInicioGerente()
        {
            InitializeComponent();
            utilFuncionario = new ManterFuncionario();
            AtualizarTabela();  // Aualiza O DataGrid com todos os funcionarios
        }

        private void frmInicioFuncionario_Click(object sender, EventArgs e)
        {
            //não utilizado
        }
        private void dgFuncionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)  //função que abre os campos especificos do funcionario
        {
            AbrirFormulario(new frmAtualizarFuncionario(funcionario));
        }

        private void AtualizarTabela()  //função que chama o DataSet e coloca do DataGrid
        {
            dgFuncionario.DataSource = utilFuncionario.Listar().Tables[0];
            dgFuncionario.Columns["Senha"].Visible = false;
            //dgFuncionario.Columns["RG"].Visible = false;
            //dgFuncionario.Columns["CPF"].Visible = false;
            dgFuncionario.Columns["Acesso"].Visible = false;
            dgFuncionario.Columns["Login"].Visible = false;
            dgFuncionario.Columns["Salario"].Visible = false;
            dgFuncionario.Columns["Endereço"].Visible = false;
            dgFuncionario.Columns["Senha"].Visible = false;
        }

        private void btnIncluir_Click(object sender, EventArgs e) //Botão que chama a aba incluir
        {
            AbrirFormulario(new frmIncluirFuncionario());
        }

        private void btnAtualizar_Click(object sender, EventArgs e) //botão que ataualiza o DataGrid
        {
            AtualizarTabela();
        }

        private void dgFuncionario_CellClick(object sender, DataGridViewCellEventArgs e) //Função que recebe todos os dados ao click no DataGrid e cria uma class com os dados
        {          
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgFuncionario.Rows[e.RowIndex];
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
            }
            funcionario = new EncFuncionario(id, nome, login, senha, acesso, cpf , rg , cargo, salario ,endereco);
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
