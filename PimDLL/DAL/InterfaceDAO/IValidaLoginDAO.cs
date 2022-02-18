using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
	interface IValidaLoginDAO // Classe que faz a interface da camada de dados com a camada de negocios
	{
		bool Valida(EncLogin l);

		bool ValidaCliente(EncLogin l);

	}
}
