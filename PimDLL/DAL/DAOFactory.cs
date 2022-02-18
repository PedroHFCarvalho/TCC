using PimDLL.DAL.InterfaceDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    class DAOFactory //classe que cria outra classe que ira enviar o comando SQL
    {
        public static IValidaLoginDAO CriarLoginDAO()
        {
            return new LoginDAOAccess();
        }
        public static IFuncionarioDAO CriarFuncDAO()
        {
            return new FuncionarioDAOAccess();
        }
        public static IVeiculosDAO CriarVeiculoDAO()
        {
            return new VeiculosDAOAccess();
        }
        public static IContratoDAO CriarContratoDAO()
        {
            return new ContratoDAOAccess();
        }
        public static IClienteDAO CriarClienteDAO()
        {
            return new ClienteDAOAccess();
        }
        public static IMotoristaDAO CriarMotoristaDAO()
        {
            return new MotoristaDAOAccess();
        }
        public static IManutDAO CriarManutDAO()
        {
            return new ManutDAOAccess();
        }
        public static IDestinoDAO CriarDestinoDAO()
        {
            return new DestinoDAOAccess();
        }
        
    }
}

