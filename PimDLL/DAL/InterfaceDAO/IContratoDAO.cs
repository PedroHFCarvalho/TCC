using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    interface IContratoDAO
    {
        bool Inserir(EncContrato c);

        DataSet Listar();

        bool Atualizar(EncContrato c);

        bool Excluir(string id);

        DataSet ListarVeiculo(string id);

        DataSet AtualizarContrato(string id);

        bool AtualizarCliente(EncContrato c);
    }
}
