using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    interface IVeiculosDAO
    {
        bool Inserir(EncVeiculos v);

        DataSet Listar();

        bool Atualizar(EncVeiculos v);

        bool Excluir(string chassi);

        bool AtualizarContrato(EncVeiculos v);

        bool AtualizarDisp(EncVeiculos v);

        DataSet ListarCategoria(string categ);

        bool AtualizarMotorista(EncVeiculos v);

        bool AtualizarKm(EncVeiculos v);

		DataSet ListarWeb(string id);

	}
}
