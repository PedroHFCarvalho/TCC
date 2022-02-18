using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DTO
{
    public class EncCliente
    {
        private string id;
        private string nome;
        private string login;
        private string senha;
        private string rg;
        private string cpf;
        private string endereco;

        public EncCliente(string id, string nome, string login , string senha, string rg, string cpf, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.rg = rg;
            this.cpf = cpf;
            this.endereco = endereco;
        }

        public EncCliente(string nome, string login, string senha, string rg, string cpf, string endereco)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.rg = rg;
            this.cpf = cpf;
            this.endereco = endereco;
        }

        public string Idcl
        {
            get { return id; }
            set { id = value; }
        }

        public string NomeCl
        {
            get { return nome; }
            set { nome = value; }
        }

        public string LoginCl
        {
            get { return login; }
            set { login = value; }
        }

        public string SenhaCl
        {
            get { return senha; }
            set { senha = value; }
        }

        public string RgCl
        {
            get { return rg; }
            set { rg = value; }
        }

        public string CpfCl
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string EnderecoCl
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
