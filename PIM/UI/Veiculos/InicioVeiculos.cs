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

namespace PIM.UI.Veiculos
{
    public partial class frmInicioVeiculos : Form
    {
        private EncVeiculos veiculos;
        private ManterVeiculo utilVeiculos;
        private string id, nome, marca, placa, chassi, km, disp , categ;

        public frmInicioVeiculos()
        {
            InitializeComponent();
            utilVeiculos = new ManterVeiculo();
            AtualizarTabela(); //atualizar o datagrid 
        }

        private void dgVeiculos_CellClick(object sender, DataGridViewCellEventArgs e) //recebe os dados da linha do datagrid e cria uma classe
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgVeiculos.Rows[e.RowIndex];
                id = row.Cells[0].Value + string.Empty;
                nome = row.Cells[1].Value + string.Empty;
                marca = row.Cells[2].Value + string.Empty;
                placa = row.Cells[3].Value + string.Empty;
                chassi = row.Cells[4].Value + string.Empty;
                km = row.Cells[5].Value + string.Empty;
                disp = row.Cells[6].Value + string.Empty;
                categ = row.Cells[7].Value + string.Empty;
            }
            veiculos = new EncVeiculos(id, nome, marca, placa, chassi , km ,disp , categ);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string txt = txtLocalizar.Text;
            string cbBox = cbCategoria.Text;

            if (cbBox != "")
            {
                if (txt != "")
                {
                    try
                    {
                        DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Placa='"+txt+"'AND Categoria='"+cbBox+"'").CopyToDataTable();
                        dgVeiculos.DataSource = dtResultado;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não Localizado");
                    }
                }
                else
                {
                    try
                    {
                        DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Categoria='"+cbBox+"'").CopyToDataTable();
                        dgVeiculos.DataSource = dtResultado;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Não Localizado");
                    }
                }
            }
            else
            {
                try
                {
                    DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Placa='"+txt+"'").CopyToDataTable();
                    dgVeiculos.DataSource = dtResultado;
                }
                catch (Exception)
                {
                    MessageBox.Show("Não Localizado");
                }
            }
        }

        private void chekDispo_CheckedChanged(object sender, EventArgs e)
        {
            if (chekDispo.Checked)
            {                
                string txt = "Disponivel";
                try
                {
                    DataTable dtResultado = utilVeiculos.Listar().Tables[0].Select("Disponibilidade='" + txt + "'").CopyToDataTable();
                    dgVeiculos.DataSource = dtResultado;
                }
                catch (Exception)
                {                  
                }
            }
            else
            {
                AtualizarTabela();
            }
        }

        private void dgVeiculos_CellDoubleClick(object sender, DataGridViewCellEventArgs e) //abre a aba específica do dado 
        {
            AbrirFormulario(new frmAtualizarVeiculo(veiculos));
        }

        private void frmInicioVeiculos_Load(object sender, EventArgs e)
        {
            //Não Utilizado
        }

        private void frmInicioVeiculos_Click(object sender, EventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e) //botão atualizar
        {
            AtualizarTabela();
        }

        private void btnIncluir_Click(object sender, EventArgs e) //botão incluir
        {
            AbrirFormulario(new frmIncluirVeiculo());
        }

        private void AtualizarTabela() //recebe o dataset e envia para datagrid
        {
            dgVeiculos.DataSource = utilVeiculos.Listar().Tables[0];
            dgVeiculos.Columns["Km"].Visible = false;
            dgVeiculos.Columns["Chassi"].Visible = false;
            dgVeiculos.Columns["Id_Contrato"].Visible = false;
            dgVeiculos.Columns["Id_Motorista"].Visible = false;
        }

        private void AbrirFormulario(object formulario) //abre um aba dentro do forms
        {
            if (this.plManterVeiculo.Controls.Count > 0)
            {
                this.plManterVeiculo.Controls.RemoveAt(0);
            }
			plManterVeiculo.Controls.Clear();
            Form novo = formulario as Form;
            novo.TopLevel = false;
            novo.Dock = DockStyle.Fill;
            this.plManterVeiculo.Controls.Add(novo);
            this.plManterVeiculo.Tag = novo;
            novo.Show();
        }
    }
}
