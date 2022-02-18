using PimDLL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class ManterContrato
    {
        IContratoDAO dao;

        public ManterContrato()
        {
            dao = DAOFactory.CriarContratoDAO();
        }
        public bool Inserir(EncContrato c)
        {
            return dao.Inserir(c);
        }
        public DataSet Listar()
        {
            return dao.Listar();
        }
        public bool Atualizar(EncContrato c)
        {
            return dao.Atualizar(c);
        }
        public bool Excluir(string id)
        {
            return dao.Excluir(id);
        }
        public DataSet ListarVeiculo(string id)
        {
            return dao.ListarVeiculo(id);
        }
        public DataSet AtualizarContrato(string id)
        {
            return dao.AtualizarContrato(id);
        }
        public bool AtualizarCliente(EncContrato c)
        {
            return dao.AtualizarCliente(c);
        }

    }
}
