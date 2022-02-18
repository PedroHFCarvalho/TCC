using PimDLL.DAL.InterfaceDAO;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    class MotoristaDAOAccess : IMotoristaDAO
    {
        private ConexaoAccess conexao;
        private string IdMotorista;
        private string IdVeiculo;

        public MotoristaDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool InserirIdMotorista(EncMotorista m)// faz o casatro do id do motorsita
        {

            string sql = "INSERT INTO tblMotorista (Id_Funcionario)" +
                    "VALUES (@idFunc)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            Identificar(m);

            var pmtIdM = cmd.CreateParameter();
            pmtIdM.ParameterName = "@idFunc";
            pmtIdM.DbType = DbType.String;
            pmtIdM.Value = IdMotorista;
            cmd.Parameters.Add(pmtIdM);

            Inserir(m);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexaodb.Close();
                return true;
            }
            else
            {
                conexaodb.Close();
                return false;
            }
        }

        public bool Atualizar(EncMotorista m)// atualiza os campos do motorista
        {
            string sql = "UPDATE tblMotorista SET Cnh = @Cnh WHERE id = @Id";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtCnh = cmd.CreateParameter();
            pmtCnh.ParameterName = "@Cnh";
            pmtCnh.DbType = DbType.String;
            pmtCnh.Value = m.Cnh;
            cmd.Parameters.Add(pmtCnh);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = m.IdF;
            cmd.Parameters.Add(pmtId);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexaodb.Close();
                return true;
            }
            else
            {
                conexaodb.Close();
                return false;
            }
        }

        public bool Excluir(string id)//faz a exlução do motorista
        {
            string sql = "DELETE FROM tblMotoriosta WHERE Id_Funcionario = @idFunc;";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);
            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@idFunc";
            pmtId.DbType = DbType.String;
            pmtId.Value = id;
            cmd.Parameters.Add(pmtId);

            if (cmd.ExecuteNonQuery() > 0)
            {
                conexaodb.Close();
                return true;
            }
            else
            {
                conexaodb.Close();
                return false;
            }
        }

        public void Inserir(EncMotorista m)//faz o cadastro da cnh
        {

            string sql = "INSERT INTO tblMotorista (Cnh)" +
                    "VALUES (@Cnh)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtCnh = cmd.CreateParameter();
            pmtCnh.ParameterName = "@Cnh";
            pmtCnh.DbType = DbType.String;
            pmtCnh.Value = m.Cnh;
            cmd.Parameters.Add(pmtCnh);
        }

        public DataSet ListarMotorista() //lista todos os motorista
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet funcionarios = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Motorista");
            tb.Columns.Add("iD", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Login", typeof(string));
            tb.Columns.Add("Senha", typeof(string));
            tb.Columns.Add("Acesso", typeof(string));
            tb.Columns.Add("CPF", typeof(string));
            tb.Columns.Add("RG", typeof(string));
            tb.Columns.Add("Cargo", typeof(string));
            tb.Columns.Add("Salario", typeof(string));
            tb.Columns.Add("Endereço", typeof(string));
            tb.Columns.Add("CNH", typeof(string));
            tb.Columns.Add("Veiculo Atual", typeof(string));
            funcionarios.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT tblFuncionario.*, tblMotorista.* FROM"
                +"(tblFuncionario INNER JOIN  tblMotorista ON tblFuncionario.Id = tblMotorista.Id_Funcionario)";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            OleDbDataReader reader = cmd.ExecuteReader();
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = funcionarios.Tables[0].NewRow();

                linha["Id"] = Convert.ToInt32(reader["Id"]);
                linha["Nome"] = reader["Nome"].ToString();
                linha["Login"] = reader["Login"].ToString();
                linha["Senha"] = reader["Senha"].ToString();
                linha["Acesso"] = reader["Acesso"].ToString();
                linha["CPF"] = reader["CPF"].ToString();
                linha["RG"] = reader["RG"].ToString();
                linha["Cargo"] = reader["Cargo"].ToString();
                linha["Salario"] = reader["Salario"].ToString();
                linha["Endereço"] = reader["Endereço"].ToString();
                linha["CNH"] = reader["Cnh"].ToString();
                // adiciona a nova linha a tabela
                funcionarios.Tables[0].Rows.Add(linha);

            }

            conexaodb.Close();
            return funcionarios; 
        }


        public string Identificar(EncMotorista m) //faz a identificação do id do motorista 
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            string query = "SELECT Id FROM tblFuncionario WHERE Login = @Login";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = m.LoginF;
            cmd.Parameters.Add(pmtLogin);

            OleDbDataReader reader = cmd.ExecuteReader();


            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                IdMotorista = reader["Id"].ToString();
            }
            return IdMotorista;
        }

        public string IdentificarVeiculo(EncMotorista m)// identifica o veiculo do motorista
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            string query = "SELECT Id FROM tblVeiculos WHERE Id_Motorista = @IdMotorista";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            var pmtIdMotorista = cmd.CreateParameter();
            pmtIdMotorista.ParameterName = "@IdMotorista";
            pmtIdMotorista.DbType = DbType.String;
            pmtIdMotorista.Value = m.IdMotorista;
            cmd.Parameters.Add(pmtIdMotorista);

            OleDbDataReader reader = cmd.ExecuteReader();


            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                m.IdVeiculo = reader["Id"].ToString();
            }
            return IdVeiculo;
        }
    }
}
