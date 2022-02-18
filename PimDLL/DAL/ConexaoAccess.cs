using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace PimDLL.DAL
{
    class ConexaoAccess
    {
        public ConexaoAccess() // classe que faz a conexão do diretorio com o banco de dados
        {
            InicializarAccess();
        }
        public string InicializarAccess()
        {
            string conexaoAccess = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\PC_Gamer\Desktop\Nova pasta\Projeto PIM 2.0\PIM Access 4.0\PIM\BancoAccess\bdPim.accdb";
            return conexaoAccess;
        }
    }
}

