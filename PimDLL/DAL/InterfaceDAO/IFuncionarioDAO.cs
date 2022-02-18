using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    interface IFuncionarioDAO
    {
        bool Inserir(EncFuncionario f);

        DataSet Listar();

        bool Atualizar(EncFuncionario f);

        bool Excluir(string login);
    }
}
