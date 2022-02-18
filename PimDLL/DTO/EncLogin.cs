using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimDLL.DAL;

namespace PimDLL.BLL
{
	public class EncLogin // classe que transporta os atributos necessarios para realizar o login
	{
		private string login, senha, id;

		public EncLogin(string login, string senha)
		{
			this.login = login;
			this.senha = senha;
		}

		public string LoginU
		{
			get { return login; }
		}

		public string SenhaU
		{
			get { return senha; }
		}
		public string IdU
		{
			get { return id; }
			set { id = value; }
		}
	}
}
