using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL.InterfaceDAO
{
    interface IManutDAO
    {
        bool Inserir(EncManut m);

        DataSet Listar();

        bool Atualizar(EncManut m);

        //bool Excluir(string id);
    }
}
