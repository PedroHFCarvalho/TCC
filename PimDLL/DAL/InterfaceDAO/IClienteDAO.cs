using PimDLL.BLL;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    interface IClienteDAO
    {
        bool Inserir(EncCliente c);

        DataSet Listar();

        bool Atualizar(EncCliente f);

        bool Excluir(string id);
    }
}
