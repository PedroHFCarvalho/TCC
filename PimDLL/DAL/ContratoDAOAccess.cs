using PimDLL.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PimDLL.DAL
{
    class ContratoDAOAccess : IContratoDAO
    {
        private ConexaoAccess conexao;

		public ContratoDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool Inserir(EncContrato c) //faz a primeira inclução do contrato
        {

            string sql = "INSERT INTO tblContrato (Nome, Vagas)" +
					"VALUES (@Nome, @Vaga)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = c.NomeC;
            cmd.Parameters.Add(pmtNome);

            var pmtVagas = cmd.CreateParameter();
			pmtVagas.ParameterName = "@Vaga";
			pmtVagas.DbType = DbType.String;
			pmtVagas.Value = c.VagasC;
            cmd.Parameters.Add(pmtVagas);

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

        public bool Atualizar(EncContrato c) // faz a atualização de todos os campos do cantrato
        {
            string sql = "UPDATE tblContrato SET Nome = @Nome, Vagas = @Vaga WHERE id = @Id";  

               OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = c.NomeC;
            cmd.Parameters.Add(pmtNome);

			var pmtVagas = cmd.CreateParameter();
			pmtVagas.ParameterName = "@Vaga";
			pmtVagas.DbType = DbType.String;
			pmtVagas.Value = c.VagasC;
			cmd.Parameters.Add(pmtVagas);

			var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = c.IdC;
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

        public bool Excluir(string id) // faz a exclução do contrato
        {
            string sql = "DELETE FROM tblContrato WHERE id = @Id;";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);
            var pmtLogin = cmd.CreateParameter();

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
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

        public DataSet Listar() // lista todos os contratos
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet contrato = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Contrato");
            tb.Columns.Add("iD", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Vagas", typeof(string));
			tb.Columns.Add("Id Cliente", typeof(string));
			tb.Columns.Add("Nome Cliente", typeof(string));
			contrato.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT tblContrato.Id_Cliente, tblContrato.Vagas, tblContrato.Nome, tblContrato.Id, tblCliente.Nome AS Expr1 FROM(tblContrato INNER JOIN tblCliente ON tblContrato.Id_Cliente = tblCliente.Id_Cliente)";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);
            OleDbDataReader reader = cmd.ExecuteReader();
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = contrato.Tables[0].NewRow();

                linha["Id"] = Convert.ToInt32(reader["Id"]);
                linha["Nome"] = reader["Nome"].ToString();
                linha["Vagas"] = reader["Vagas"].ToString();
				linha["Id Cliente"] = reader["Id_Cliente"].ToString();
				linha["Nome Cliente"] = reader["Expr1"].ToString();
				// adiciona a nova linha a tabela
				contrato.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return contrato;
        }

        public DataSet AtualizarContrato(string id) //lista o contrato de um cliente especifico 
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet contrato = new DataSet();
			// cria um DataTable para ser adicionado ao DataSet
			DataTable tb = new DataTable("Contrato");
			tb.Columns.Add("iD", typeof(Int32));
			tb.Columns.Add("Nome", typeof(string));
			tb.Columns.Add("Vagas", typeof(string));
			contrato.Tables.Add(tb);

			// consulta o banco de dados, o retorno é um objeto DataReader
			string query = "SELECT * FROM tblContrato WHERE Id_Cliente = @id";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = id;
            cmd.Parameters.Add(pmtId);

            OleDbDataReader reader = cmd.ExecuteReader();
            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = contrato.Tables[0].NewRow();

				linha["Id"] = Convert.ToInt32(reader["Id"]);
				linha["Nome"] = reader["Nome"].ToString();
				linha["Vagas"] = reader["Vagas"].ToString();
				// adiciona a nova linha a tabela
				contrato.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return contrato;
        }

        public DataSet ListarVeiculo(string id) //lista todos os veiculos de um contrato
        {
            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet veiculoscontrato = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Veiculo");
            tb.Columns.Add("iD", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Marca", typeof(string));
            tb.Columns.Add("Placa", typeof(string));
            tb.Columns.Add("Chassi", typeof(string));
            veiculoscontrato.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto DataReader
            string query = "SELECT tblVeiculos.* FROM  (tblContrato INNER JOIN tblVeiculos ON tblContrato.Id = tblVeiculos.Id_Contrato) WHERE Id_Contrato = @Id";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = id;
            cmd.Parameters.Add(pmtId);

            OleDbDataReader reader = cmd.ExecuteReader();



            // pecorre o objeto DataReader lendo linha a linha
            while (reader.Read())
            {
                // obtém os dados da linha atual
                DataRow linha = veiculoscontrato.Tables[0].NewRow();

				linha["Id"] = Convert.ToInt32(reader["Id"]);
				linha["Nome"] = reader["Nome"].ToString();
				linha["Marca"] = reader["Marca"].ToString();
				linha["Placa"] = reader["Placa"].ToString();
				linha["Chassi"] = reader["Chassi"].ToString();

				// adiciona a nova linha a tabela
				veiculoscontrato.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return veiculoscontrato;
        }

        public bool AtualizarCliente(EncContrato c) //atualiza o contrato de um cliente 
        {
			

            string sql = "UPDATE tblContrato SET Id_Cliente = @IdCliente WHERE tblContrato.Id = @IdCont";

			c.IdC = idContrato;

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@IdCliente";
            pmtId.DbType = DbType.String;
            pmtId.Value = c.IdClienteC;
            cmd.Parameters.Add(pmtId);

            var pmtIdCont = cmd.CreateParameter();
            pmtIdCont.ParameterName = "@IdCont";
            pmtIdCont.DbType = DbType.String;
            pmtIdCont.Value = c.IdC;
            cmd.Parameters.Add(pmtIdCont);

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

