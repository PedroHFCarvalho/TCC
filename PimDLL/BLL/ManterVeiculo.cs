using PimDLL.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class ManterVeiculo
    {
        IVeiculosDAO dao;

        public ManterVeiculo()
        {
            dao = DAOFactory.CriarVeiculoDAO();
        }
        public bool Incluir(EncVeiculos v)
        {
            return dao.Inserir(v);
        }
        public DataSet Listar()
        {
            return dao.Listar();
        }
        public bool Atualizar(EncVeiculos v)
        {
            return dao.Atualizar(v);
        }
        public bool Excluir(string chassi)
        {
            return dao.Excluir(chassi);
        }
        public bool AtualizaContrato(EncVeiculos v)
        {
            return dao.AtualizarContrato(v);
        }
        public bool AtualizarDisp(EncVeiculos v,bool disp)
        {
            if (disp) // determina a disponibilidade do veiculo
            {
                v.DispV = "Disponivel";
                return dao.AtualizarDisp(v);
            }
            else
            {
                v.DispV = "Indisponivel";
                return dao.AtualizarDisp(v);
            }
        }
        public DataSet ListarCategoria(string categ)
        {
            return dao.ListarCategoria(categ);
        }

        public bool AtualizarMotorista(EncVeiculos v)
        {
            return dao.AtualizarMotorista(v);
        }

        public bool AtualizarKm(EncVeiculos v)
        {
            return dao.AtualizarKm(v);
        }

		public DataSet ListarWeb(string id)
		{
			return dao.ListarWeb(id);
		}
	}
}
