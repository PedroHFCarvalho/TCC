using PIM.UI.Funcionario;
using PIM.UI.Veiculos;
using System;
using System.Windows.Forms;
using PIM.UI.Gerente;
using PIM.UI.Cliente;
using PIM.UI.Motorista;
using PIM.UI.Manut;
using PIM.UI.Destino;
using PimDLL.BLL;
using System.Data;

namespace PIM.UI
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
            AbrirFormulario(new frmTabelasInicio());        
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
			AbrirFormulario(new frmInicioGerente());
            btnContratos.Visible = true;
            btnFuncionario.Visible = true;
        }

        private void btnVaiculos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioVeiculos());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }
        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioCliente());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }
        private void AbrirFormulario(object formulario)
        {
            if (this.plConteiner.Controls.Count>0)
            {
                this.plConteiner.Controls.RemoveAt(0);
            }
            Form novo = formulario as Form;
            novo.TopLevel = false;
            novo.Dock = DockStyle.Fill;
            this.plConteiner.Controls.Add(novo);
            this.plConteiner.Tag = novo;
            novo.Show();
        }

        private void btnContratos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmIncioContratos());
        }

        private void btnFuncionario_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioGerente());
        }

        private void btnMotorista_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioMotorista());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }

        private void btnManut_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioManut());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmInicioDestino());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmTabelasInicio());
            btnContratos.Visible = false;
            btnFuncionario.Visible = false;
        }
    }
}
