using PimDLL.BLL;
using PimDLL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PimDLL.DAL
{
    class ClienteDAOAccess : IClienteDAO
    {
        private ConexaoAccess conexao;

        public ClienteDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool Inserir(EncCliente c) // faz a primeria inclução do cliente 
        {

            string sql = "INSERT INTO tblCliente (Nome, Login, Senha, RG, CPF, Endereco)" +
                    "VALUES (@Nome, @Login, @Senha, @rg, @Cpf, @Endereco)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = c.NomeCl;
            cmd.Parameters.Add(pmtNome);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = c.LoginCl;
            cmd.Parameters.Add(pmtLogin);

            var pmtSenha = cmd.CreateParameter();
            pmtSenha.ParameterName = "@Senha";
            pmtSenha.DbType = DbType.String;
            pmtSenha.Value = c.SenhaCl;
            cmd.Parameters.Add(pmtSenha);

            var pmtRg = cmd.CreateParameter();
            pmtRg.ParameterName = "@Rg";
            pmtRg.DbType = DbType.String;
            pmtRg.Value = c.RgCl;
            cmd.Parameters.Add(pmtRg);

            var pmtCpf = cmd.CreateParameter();
            pmtCpf.ParameterName = "@Cpf";
            pmtCpf.DbType = DbType.String;
            pmtCpf.Value = c.CpfCl;
            cmd.Parameters.Add(pmtCpf);

            var pmtEndereco = cmd.CreateParameter();
            pmtEndereco.ParameterName = "@Endereco";
            pmtEndereco.DbType = DbType.String;
            pmtEndereco.Value = c.EnderecoCl;
            cmd.Parameters.Add(pmtEndereco);

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

        public bool Atualizar(EncCliente c) // faz a att de todos os campos do cliente 
        {
            string sql = "UPDATE tblCliente SET Nome = @Nome, Login = @Login, Senha = @Senha,  Rg = @Rg, Cpf = @Cpf, Endereco = @Endereco"
                + " WHERE Id_Cliente = @Id";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = c.NomeCl;
            cmd.Parameters.Add(pmtNome);

            var pmtLogin = cmd.CreateParameter();
            pmtLogin.ParameterName = "@Login";
            pmtLogin.DbType = DbType.String;
            pmtLogin.Value = c.LoginCl;
            cmd.Parameters.Add(pmtLogin);

            var pmtSenha = cmd.CreateParameter();
            pmtSenha.ParameterName = "@Senha";
            pmtSenha.DbType = DbType.String;
            pmtSenha.Value = c.SenhaCl;
            cmd.Parameters.Add(pmtSenha);

            var pmtRg = cmd.CreateParameter();
            pmtRg.ParameterName = "@Rg";
            pmtRg.DbType = DbType.String;
            pmtRg.Value = c.RgCl;
            cmd.Parameters.Add(pmtRg);

            var pmtCpf = cmd.CreateParameter();
            pmtCpf.ParameterName = "@Cpf";
            pmtCpf.DbType = DbType.String;
            pmtCpf.Value = c.CpfCl;
            cmd.Parameters.Add(pmtCpf);

            var pmtEndereco = cmd.CreateParameter();
            pmtEndereco.ParameterName = "@Endereco";
            pmtEndereco.DbType = DbType.String;
            pmtEndereco.Value = c.EnderecoCl;
            cmd.Parameters.Add(pmtEndereco);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = c.Idcl;
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

        public bool Excluir(string id) // faz a excluição do cliente 
        {
            string sql = "DELETE FROM tblCliente WHERE Id_Cliente = @id;";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);
            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@id";
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

        public DataSet Listar() //lista todos os clientes do banco de dados
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet Cliente = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Cliente");
            tb.Columns.Add("Id", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Login", typeof(string));
            tb.Columns.Add("Senha", typeof(string));       
            tb.Columns.Add("CPF", typeof(string));
            tb.Columns.Add("RG", typeof(string));
            tb.Columns.Add("Endereço", typeof(string));
            Cliente.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT * FROM tblCliente";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);
            OleDbDataReader reader = cmd.ExecuteReader();
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = Cliente.Tables[0].NewRow();

                linha["Id"] = Convert.ToInt32(reader["Id_Cliente"]);
                linha["Nome"] = reader["Nome"].ToString();
                linha["Login"] = reader["Login"].ToString();
                linha["Senha"] = reader["Senha"].ToString();
                linha["CPF"] = reader["CPF"].ToString();
                linha["RG"] = reader["RG"].ToString();
                linha["Endereço"] = reader["Endereco"].ToString();
                // adiciona a nova linha a tabela
                Cliente.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return Cliente;






        }
    }
}
