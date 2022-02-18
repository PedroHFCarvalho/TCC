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
	class DestinoDAOAccess : IDestinoDAO
	{
		private ConexaoAccess conexao;

		public DestinoDAOAccess()
		{
			conexao = new ConexaoAccess();
		}

		public bool Inserir(EncDestino d) //faz a primeira inclução de um destino
		{
			string sql = "INSERT INTO tblDestino (Saida, Id_Veiculo, Rua_Destino, Rua_Saida)" +
					   "VALUES (@Saida, @IdVeiculo, @Rua_Destino , @Rua_Saida )";

			OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
			conexaodb.Open();

			OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

			var pmtDataSaida = cmd.CreateParameter();
			pmtDataSaida.ParameterName = "@Saida";
			pmtDataSaida.DbType = DbType.String;
			pmtDataSaida.Value = d.DataSaida;
			cmd.Parameters.Add(pmtDataSaida);

			var pmtIdVeiculo = cmd.CreateParameter();
			pmtIdVeiculo.ParameterName = "@IdVeiculo";
			pmtIdVeiculo.DbType = DbType.String;
			pmtIdVeiculo.Value = d.IdVeiculo;
			cmd.Parameters.Add(pmtIdVeiculo);

			var pmtRuaDestino = cmd.CreateParameter();
			pmtRuaDestino.ParameterName = "@Rua_Destino";
			pmtRuaDestino.DbType = DbType.String;
			pmtRuaDestino.Value = d.RuaDestino;
			cmd.Parameters.Add(pmtRuaDestino);

			var pmtRuaSaida = cmd.CreateParameter();
			pmtRuaSaida.ParameterName = "@Rua_Saida";
			pmtRuaSaida.DbType = DbType.String;
			pmtRuaSaida.Value = d.RuaSaida;
			cmd.Parameters.Add(pmtRuaSaida);

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

		public DataSet Listar() //lista todos os destinos
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
			tb.Columns.Add("Categ", typeof(string));
			tb.Columns.Add("Id_Rota", typeof(string));
			tb.Columns.Add("Saida", typeof(string));
			tb.Columns.Add("Chegada", typeof(string));
			tb.Columns.Add("Km_Chegada", typeof(string));
			tb.Columns.Add("Rua_Saida", typeof(string));
			tb.Columns.Add("Rua_Destino", typeof(string));
			veiculo.Tables.Add(tb);

			// consulta o banco de dados, o retorno é um objeto DataReader
			string query = "SELECT * FROM (tblVeiculos INNER JOIN tblDestino ON tblVeiculos.Id = tblDestino.Id_Veiculo AND tblVeiculos.Id = tblDestino.Id_Veiculo)";
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
				linha["Categ"] = reader["Categoria"].ToString();
				linha["Id_Rota"] = reader["Id_Rota"].ToString();
				linha["Saida"] = reader["Saida"].ToString();
				linha["Chegada"] = reader["Chegada"].ToString();
				linha["Km_Chegada"] = reader["Km_Chegada"].ToString();
				linha["Rua_Saida"] = reader["Rua_Saida"].ToString();
				linha["Rua_Destino"] = reader["Rua_Destino"].ToString();

				// adiciona a nova linha a tabela
				veiculo.Tables[0].Rows.Add(linha);
			}
			conexaodb.Close();
			return veiculo;
		}

		public bool Atualizar(EncDestino d) //atualiza a quilometragem e a data de chegada de um destino
		{
			string sql = "UPDATE tblDestino SET Chegada = @DtChegada, Km_Chegada = @Km  WHERE id_Veiculo = @Id_Veiculo AND Id_Rota = @Id_Rota";

			OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
			conexaodb.Open();
			OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

			var pmtDataChegada = cmd.CreateParameter();
			pmtDataChegada.ParameterName = "@DtChegada";
			pmtDataChegada.DbType = DbType.String;
			pmtDataChegada.Value = d.DataChegada;
			cmd.Parameters.Add(pmtDataChegada);

			var pmtKm = cmd.CreateParameter();
			pmtKm.ParameterName = "@Km";
			pmtKm.DbType = DbType.String;
			pmtKm.Value = d.Km;
			cmd.Parameters.Add(pmtKm);

			var pmtId = cmd.CreateParameter();
			pmtId.ParameterName = "@Id_Veiculo";
			pmtId.DbType = DbType.String;
			pmtId.Value = d.IdVeiculo;
			cmd.Parameters.Add(pmtId);

			var pmtIdDestino = cmd.CreateParameter();
			pmtIdDestino.ParameterName = "@Id_Rota";
			pmtIdDestino.DbType = DbType.String;
			pmtIdDestino.Value = d.IdRota;
			cmd.Parameters.Add(pmtIdDestino);

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

		public DataSet ListarWeb(string l) // lista todos os destino dos veiculos de um cliente 
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
			tb.Columns.Add("Categ", typeof(string));
			tb.Columns.Add("Id_Rota", typeof(string));
			tb.Columns.Add("Saida", typeof(string));
			tb.Columns.Add("Chegada", typeof(string));
			tb.Columns.Add("Km_Chegada", typeof(string));
			tb.Columns.Add("Rua_Saida", typeof(string));
			tb.Columns.Add("Rua_Destino", typeof(string));
			veiculo.Tables.Add(tb);

			// consulta o banco de dados, o retorno é um objeto DataReader
			string query = "SELECT tblDestino.* , tblVeiculos.* FROM " +
				"(((tblDestino INNER JOIN tblVeiculos ON tblDestino.Id_Veiculo = tblVeiculos.Id)" +
				" INNER JOIN tblContrato ON tblVeiculos.Id_Contrato = tblContrato.Id)" +
				" INNER JOIN tblCliente ON tblContrato.Id_Cliente = tblCliente.Id_Cliente)" +
				" WHERE(tblContrato.Id_Cliente = @id)";

			OleDbCommand cmd = new OleDbCommand(query, conexaodb);

			var pmtID = cmd.CreateParameter();
			pmtID.ParameterName = "@id";
			pmtID.DbType = DbType.String;
			pmtID.Value = l;
			cmd.Parameters.Add(pmtID);

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
				linha["Categ"] = reader["Categoria"].ToString();
				linha["Id_Rota"] = reader["Id_Rota"].ToString();
				linha["Saida"] = reader["Saida"].ToString();
				linha["Chegada"] = reader["Chegada"].ToString();
				linha["Km_Chegada"] = reader["Km_Chegada"].ToString();
				linha["Rua_Saida"] = reader["Rua_Saida"].ToString();
				linha["Rua_Destino"] = reader["Rua_Destino"].ToString();

				// adiciona a nova linha a tabela
				veiculo.Tables[0].Rows.Add(linha);
			}
			conexaodb.Close();
			return veiculo;
		}
	}
}
