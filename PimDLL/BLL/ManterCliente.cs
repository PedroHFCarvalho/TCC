using PimDLL.DAL;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class ManterCliente
    {
        IClienteDAO dao;

        public ManterCliente()
        {
            dao = DAOFactory.CriarClienteDAO();
        }
        public bool IncluirCliente(EncCliente c)
        {
            return dao.Inserir(c);
        }
        public DataSet Listar()
        {
            return dao.Listar();
        }
        public bool Atualizar(EncCliente c)
        {
            return dao.Atualizar(c);
        }
        public bool Excluir(string id)
        {
            return dao.Excluir(id);
        }

    }
}
