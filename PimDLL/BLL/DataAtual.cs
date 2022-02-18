using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class DataAtual
    {
        public string Data() //Classe retorna a data formatada do dia atual do sistema
        {
           string data = DateTime.Now.ToString("dd/MM/y");
           return data;
        }
    }
}
