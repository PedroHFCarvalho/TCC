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
    public class ManterMotorista : IMotoristaDAO
    {
        IMotoristaDAO dao;

        public ManterMotorista()
        {
            dao = DAOFactory.CriarMotoristaDAO();
        }
        public bool InserirIdMotorista(EncMotorista m)
        {
            return dao.InserirIdMotorista(m);
        }
        public DataSet ListarMotorista()
        {
            return dao.ListarMotorista();
        }
        public bool Excluir(string id)
        {
            return dao.Excluir(id);
        }
        public bool Atualizar(EncMotorista m)
        {
            return dao.Atualizar(m);
        }
        public string IdentificarVeiculo(EncMotorista m)
        {
            return dao.IdentificarVeiculo(m);
        }
    }
}
