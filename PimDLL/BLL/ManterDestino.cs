using PimDLL.DAL;
using PimDLL.DAL.InterfaceDAO;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
	public class ManterDestino
	{
		IDestinoDAO dao;

		public ManterDestino()
		{
			dao = DAOFactory.CriarDestinoDAO();
		}
		public bool Incluir(EncDestino d)
		{
			return dao.Inserir(d);
		}
		public DataSet Listar()
		{
			return dao.Listar();
		}
		public bool Atualizar(EncDestino d)
		{
			return dao.Atualizar(d);
		}
		public DataSet ListarWeb(string l)
		{
			return dao.ListarWeb(l);
		}

	}
}
