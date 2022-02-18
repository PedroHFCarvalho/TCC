using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimDLL.BLL
{
    public class ValidaForm //Classe que realiza todas as validações de formulario Forms
    {
        public bool ValidaF(EncLogin l)
        {
            if (l.LoginU == "") 
            {
                MessageBox.Show("Voce não digitou o Login", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else if (l.SenhaU == "")
            {
                MessageBox.Show("Voce não digitou a Senha", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                return false;
            }
        }

		public bool ValidaF(EncCliente c)
		{
			if (c.NomeCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.LoginCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.SenhaCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.RgCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.CpfCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.EnderecoCl == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidaF(EncContrato c)
		{
			if (c.NomeC == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (c.VagasC == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidaF(EncFuncionario f)
		{
			if (f.NomeF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.LoginF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.SenhaF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.AcessoF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.CpFF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.RgF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.CargoF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.SalarioF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (f.EnderecoF== "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidaF(EncMotorista m)
		{
			if (m.NomeF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.LoginF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.SenhaF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.AcessoF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.CpFF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.RgF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.CargoF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.SalarioF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.EnderecoF == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (m.Cnh == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidaF(EncManut m)
		{
			if (m.Observ == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidaF(EncDestino d)
		{
			if (d.DataChegada == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (d.DataSaida == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}

		public bool ValidaF(EncVeiculos v)
		{
			if (v.NomeV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (v.MarcaV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (v.PlacaV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (v.ChassiV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (v.KmV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else if (v.CategV == "")
			{
				MessageBox.Show("Voce não digitou um campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return true;
			}
			else
			{
				return false;
			}
		}
    }
}
