using PimDLL.BLL;

namespace PimDLL.DTO
{
    public class EncMotorista : EncFuncionario
    {
        public string cnh;
        public string idVeiculo;
        public string idMotorista;

         public EncMotorista(string nome, string login, string senha, string acesso, string cpf, string rg, string cargo, string salario, string endereco, string cnh) 
            : base(nome, login , senha , acesso, cpf, rg , cargo, salario, endereco)
        {
            this.cnh = cnh;
        }

        public EncMotorista(string id, string nome, string login, string senha, string acesso, string cpf, string rg, string cargo, string salario, string endereco, string cnh , string idVeiculo)
            : base(id, nome, login, senha, acesso, cpf, rg, cargo, salario, endereco)
        {
            this.idMotorista = id;
            this.cnh = cnh;
            this.idVeiculo = idVeiculo;
        }

        public string Cnh
        {
            get { return cnh; }
            set { cnh = value; }
        }

        public string IdVeiculo
        {
            get { return idVeiculo; }
            set { idVeiculo = value; }
        }

        public string IdMotorista
        {
            get { return idMotorista; }
            set { idMotorista = value; }
        }
    }
}
