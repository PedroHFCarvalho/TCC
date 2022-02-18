using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class EncContrato
    {
		private string id, nome, vagas, nomeCliente;
		
        private string idCliente;

        public EncContrato(string nome, string vagas)
        {
            this.nome = nome;
			this.vagas = vagas;
        }

        public EncContrato(string id, string nome, string vagas, string idCliente , string nomeCliente)
        {
			this.vagas = vagas;
			this.id = id;
			this.nome = nome;
			this.idCliente = idCliente;
			this.nomeCliente = nomeCliente;
		}

        public EncContrato(string id, string nome, string vagas, string idCliente)
        {
            this.id = id;
            this.nome = nome;
			this.idCliente = idCliente;
			this.vagas = vagas;

		}
        public string IdC
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeC
        {
            get { return nome; }
            set { nome = value; }
        }

		public string NomeClienteC
		{
			get { return nomeCliente; }
			set { nomeCliente = value; }
		}

        public string VagasC
        {
            get { return vagas; }
            set { vagas = value; }
        }

        public string IdClienteC
        {
            get { return idCliente; }
            set { idCliente = value; }
        }
    }
}

