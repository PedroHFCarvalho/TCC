using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.BLL
{
    public class EncFuncionario
    {
        private string id;
        private string nome;
        private string login;
        private string senha;
        private string acesso;
        private string cpf;
        private string rg;
        private string cargo;
        private string salario;
        private string endereco;

        public EncFuncionario(string nome, string login, string senha, string acesso, string cpf, string rg, string cargo, string salario, string endereco)
        {
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.acesso = acesso;
            this.cpf = cpf;
            this.rg = rg;
            this.cargo = cargo;
            this.salario = salario;
            this.endereco = endereco;
        }

        public EncFuncionario(string id, string nome, string login, string senha, string acesso, string cpf, string rg, string cargo, string salario, string endereco)
        {
            this.id = id;
            this.nome = nome;
            this.login = login;
            this.senha = senha;
            this.acesso = acesso;
            this.cpf = cpf;
            this.rg = rg;
            this.cargo = cargo;
            this.salario = salario;
            this.endereco = endereco;
        }

        public string IdF
        {
            get { return id; }
            set { id = value; }
        }

        public string LoginF
        {
            get { return login; }
            set { login = value; }
        }

        public string SenhaF
        {
            get { return senha; }
            set { senha = value; }
        }
        public string NomeF
        {
            get { return nome; }
            set { nome = value; }
        }
        public string AcessoF
        {
            get { return acesso; }
            set { acesso = value; }
        }
        public string CpFF
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string RgF
        {
            get { return rg; }
            set { rg = value; }
        }
        public string CargoF
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string SalarioF
        {
            get { return salario; }
            set { salario = value; }
        }
        public string EnderecoF
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
