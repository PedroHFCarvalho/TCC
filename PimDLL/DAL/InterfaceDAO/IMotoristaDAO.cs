using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL.InterfaceDAO
{
    interface IMotoristaDAO
    {
        bool InserirIdMotorista(EncMotorista m);

        DataSet ListarMotorista();

        bool Excluir(string id);

        bool Atualizar(EncMotorista m);

        string IdentificarVeiculo(EncMotorista m);
    }
}
