using PimDLL.BLL;
using System;
using System.Data;
using System.Data.OleDb;

namespace PimDLL.DAL
{
    class FuncionarioDAOAccess : IFuncionarioDAO
    {
        private ConexaoAccess conexao;

        public FuncionarioDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool Inserir(EncFuncionario f)// primeiro cadastro do funcionario
        {

            string sql = "INSERT INTO tblFuncionario (Nome, Login, Senha, Acesso, Cpf, Rg, Endereço, Cargo, Salario)" +
                    "VALUES (@Nome, @Login, @Senha, @Acesso, @Cpf, @Rg, @Endereco, @Cargo ,@Salario)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = f.NomeF;
            cmd.Parameters.Add(pmtNome);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = f.LoginF;
            cmd.Parameters.Add(pmtLogin);

            var pmtSenha = cmd.CreateParameter();
            pmtSenha.ParameterName = "@Senha";
            pmtSenha.DbType = DbType.String;
            pmtSenha.Value = f.SenhaF;
            cmd.Parameters.Add(pmtSenha);

            var pmtAcesso = cmd.CreateParameter();
            pmtAcesso.ParameterName = "@Acesso";
            pmtAcesso.DbType = DbType.String;
            pmtAcesso.Value = f.AcessoF;
            cmd.Parameters.Add(pmtAcesso);

            var pmtCpf = cmd.CreateParameter();
            pmtCpf.ParameterName = "@Cpf";
            pmtCpf.DbType = DbType.String;
            pmtCpf.Value = f.CpFF;
            cmd.Parameters.Add(pmtCpf);

            var pmtRg = cmd.CreateParameter();
            pmtRg.ParameterName = "@Rg";
            pmtRg.DbType = DbType.String;
            pmtRg.Value = f.RgF;
            cmd.Parameters.Add(pmtRg);

            var pmtEndereco = cmd.CreateParameter();
            pmtEndereco.ParameterName = "@Endereco";
            pmtEndereco.DbType = DbType.String;
            pmtEndereco.Value = f.EnderecoF;
            cmd.Parameters.Add(pmtEndereco);

            var pmtCargo = cmd.CreateParameter();
            pmtCargo.ParameterName = "@Cargo";
            pmtCargo.DbType = DbType.String;
            pmtCargo.Value = f.CargoF;
            cmd.Parameters.Add(pmtCargo);

            var pmtSalario = cmd.CreateParameter();
            pmtSalario.ParameterName = "@Salario";
            pmtSalario.DbType = DbType.String;
            pmtSalario.Value = f.SalarioF;
            cmd.Parameters.Add(pmtSalario);


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

        public bool Atualizar(EncFuncionario f) // atualiza os campos do funcionario
        {
            string sql = "UPDATE tblFuncionario SET Nome = @Nome, Login = @Login, Senha = @Senha, Acesso = @Acesso, Cpf = @Cpf, Rg = @Rg, Endereço = @Endereco, Cargo = @Cargo, Salario = @Salario WHERE id = @Id";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = f.NomeF;
            cmd.Parameters.Add(pmtNome);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = f.LoginF;
            cmd.Parameters.Add(pmtLogin);

            var pmtSenha = cmd.CreateParameter();
            pmtSenha.ParameterName = "@Senha";
            pmtSenha.DbType = DbType.String;
            pmtSenha.Value = f.SenhaF;
            cmd.Parameters.Add(pmtSenha);

            var pmtAcesso = cmd.CreateParameter();
            pmtAcesso.ParameterName = "@Acesso";
            pmtAcesso.DbType = DbType.String;
            pmtAcesso.Value = f.AcessoF;
            cmd.Parameters.Add(pmtAcesso);

            var pmtCpf = cmd.CreateParameter();
            pmtCpf.ParameterName = "@Cpf";
            pmtCpf.DbType = DbType.String;
            pmtCpf.Value = f.CpFF;
            cmd.Parameters.Add(pmtCpf);

            var pmtRg = cmd.CreateParameter();
            pmtRg.ParameterName = "@Rg";
            pmtRg.DbType = DbType.String;
            pmtRg.Value = f.RgF;
            cmd.Parameters.Add(pmtRg);

            var pmtEndereco = cmd.CreateParameter();
            pmtEndereco.ParameterName = "@Endereco";
            pmtEndereco.DbType = DbType.String;
            pmtEndereco.Value = f.EnderecoF;
            cmd.Parameters.Add(pmtEndereco);

            var pmtCargo = cmd.CreateParameter();
            pmtCargo.ParameterName = "@Cargo";
            pmtCargo.DbType = DbType.String;
            pmtCargo.Value = f.CargoF;
            cmd.Parameters.Add(pmtCargo);

            var pmtSalario = cmd.CreateParameter();
            pmtSalario.ParameterName = "@Salario";
            pmtSalario.DbType = DbType.String;
            pmtSalario.Value = f.SalarioF;
            cmd.Parameters.Add(pmtSalario);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = f.IdF;
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

        public bool Excluir(string login)// faz a exclução do funcionario
        {
            string sql = "DELETE FROM tblFuncionario WHERE Login = @Login;";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);
            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = login;
            cmd.Parameters.Add(pmtLogin);

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

        public DataSet Listar()// ista todos os funcionarios
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet funcionarios = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Funcionario");
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
            funcionarios.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT * FROM tblFuncionario";
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
                // adiciona a nova linha a tabela
                funcionarios.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return funcionarios;






        }
    }
}
