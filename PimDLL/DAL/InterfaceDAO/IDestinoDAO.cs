using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL.InterfaceDAO
{
	interface IDestinoDAO
	{
		bool Inserir(EncDestino d);

		DataSet Listar();

		DataSet ListarWeb(string l);

		bool Atualizar(EncDestino d);

		//bool Excluir(string id);
	}
}
