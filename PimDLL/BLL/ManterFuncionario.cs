using PimDLL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class ManterFuncionario
    {
        IFuncionarioDAO dao;

        public ManterFuncionario()
        {
            dao = DAOFactory.CriarFuncDAO();
        }
        public bool IncluirFuncionario(EncFuncionario f)
        {
            return dao.Inserir(f);
        }
        public DataSet Listar()
        {
            return dao.Listar();
        }
        public bool Atualizar(EncFuncionario f)
        {
            return dao.Atualizar(f);
        }
        public bool Excluir(string login)
        {
            return dao.Excluir(login);
        }
    }
}
