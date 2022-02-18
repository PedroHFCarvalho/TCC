using PimDLL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimDLL.BLL
{
	public class LiberacaoLogin //classe que executa a criação da classe de Conexão com o banco de dados e Executa a Validação do login
	{
		private EncLogin loginEntrada;
		IValidaLoginDAO dao;

		public LiberacaoLogin(EncLogin l)
		{
			loginEntrada = l;
			dao = DAOFactory.CriarLoginDAO();
		}

		public bool Liberacao()
		{
			return dao.Valida(loginEntrada);
		}

		public bool ValidaCliente()
		{
			return dao.ValidaCliente(loginEntrada);
		}

	}
}
