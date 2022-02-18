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
    public class ManutDAOAccess : IManutDAO
    {
        private ConexaoAccess conexao;

        public ManutDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool Inserir(EncManut m)// faz o cadastro da manutenção
        { 
         string sql = "INSERT INTO tblManut (Entrada, Id_Veiculo, Observacao)" +
                    "VALUES (@DataEntrada, @IdVeiculo, @Observ)";

        OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
        conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtDataEntrada = cmd.CreateParameter();
            pmtDataEntrada.ParameterName = "@DataEntrada";
            pmtDataEntrada.DbType = DbType.String;
            pmtDataEntrada.Value = m.DataEntrada;
            cmd.Parameters.Add(pmtDataEntrada);

            var pmtIdVeiculo = cmd.CreateParameter();
            pmtIdVeiculo.ParameterName = "@IdVeiculo";
            pmtIdVeiculo.DbType = DbType.String;
            pmtIdVeiculo.Value = m.IdVeiculo;
            cmd.Parameters.Add(pmtIdVeiculo);

            var pmtObserv = cmd.CreateParameter();
            pmtObserv.ParameterName = "@Observ";
            pmtObserv.DbType = DbType.String;
            pmtObserv.Value = m.Observ;
            cmd.Parameters.Add(pmtObserv);

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

        public DataSet Listar()// lista todas as manutenções 
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet veiculo = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Veiculo");
            tb.Columns.Add("Id", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Marca", typeof(string));
            tb.Columns.Add("Placa", typeof(string));
            tb.Columns.Add("Chassi", typeof(string));
            tb.Columns.Add("Km", typeof(string));
            tb.Columns.Add("Categoria", typeof(string));
            tb.Columns.Add("Observacao", typeof(string));
            tb.Columns.Add("Id_Manut", typeof(string));
            tb.Columns.Add("Saida", typeof(string));
            tb.Columns.Add("Entrada", typeof(string));
            veiculo.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT * FROM (tblVeiculos INNER JOIN tblManut ON tblVeiculos.Id = tblManut.Id_Veiculo AND tblVeiculos.Id = tblManut.Id_Veiculo)";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);
            OleDbDataReader reader = cmd.ExecuteReader();
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = veiculo.Tables[0].NewRow();

                linha["Id"] = Convert.ToInt32(reader["Id"]);
                linha["Nome"] = reader["Nome"].ToString();
                linha["Marca"] = reader["Marca"].ToString();
                linha["Placa"] = reader["Placa"].ToString();
                linha["Chassi"] = reader["Chassi"].ToString();
                linha["Km"] = reader["Km"].ToString();
                linha["Categoria"] = reader["Categoria"].ToString();
                linha["Observacao"] = reader["Observacao"].ToString();
                linha["Id_Manut"] = reader["Id_Manut"].ToString();
                linha["Saida"] = reader["Saida"].ToString();
                linha["Entrada"] = reader["Entrada"].ToString();

                // adiciona a nova linha a tabela
                veiculo.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return veiculo;
        }

        public bool Atualizar(EncManut m)// faz aatualização da saida da manutenção
        {
            string sql = "UPDATE tblManut SET Saida = @DtSaida WHERE id_Veiculo = @Id_Veiculo AND Id_Manut = @Id_Manut";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtDtSaida = cmd.CreateParameter();
            pmtDtSaida.ParameterName = "@DtSaida";
            pmtDtSaida.DbType = DbType.String;
            pmtDtSaida.Value = m.DataSaida;
            cmd.Parameters.Add(pmtDtSaida);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id_Veiculo";
            pmtId.DbType = DbType.String;
            pmtId.Value = m.IdVeiculo;
            cmd.Parameters.Add(pmtId);

            var pmtIdManut = cmd.CreateParameter();
            pmtIdManut.ParameterName = "@Id_Manut";
            pmtIdManut.DbType = DbType.String;
            pmtIdManut.Value = m.IdManut;
            cmd.Parameters.Add(pmtIdManut);

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
    }
}
