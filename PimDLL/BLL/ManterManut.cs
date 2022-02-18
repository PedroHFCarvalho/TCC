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
    public class ManterManut
    {
        IManutDAO dao;

        public ManterManut()
        {
            dao = DAOFactory.CriarManutDAO();
        }
        public bool Incluir(EncManut m)
        {
            return dao.Inserir(m);
        }
        public DataSet Listar()
        {
            return dao.Listar();
        }
        public bool Atualizar(EncManut m)
        {
            return dao.Atualizar(m);
        }
    }
}
