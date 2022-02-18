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
    class VeiculosDAOAccess : IVeiculosDAO
    {
        private ConexaoAccess conexao;

        public VeiculosDAOAccess()
        {
            conexao = new ConexaoAccess();
        }

        public bool Inserir(EncVeiculos v)// faz o primeiro cadastro do veiculo
        {

            string sql = "INSERT INTO tblVeiculos (Nome, Marca, Placa, Chassi, Categoria, Km)" +
                    "VALUES (@Nome, @Marca, @Placa, @Chassi, @Categ ,@Km)";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = v.NomeV;
            cmd.Parameters.Add(pmtNome);

            var pmtMarca = cmd.CreateParameter();
            pmtMarca.ParameterName = "@Marca";
            pmtMarca.DbType = DbType.String;
            pmtMarca.Value = v.MarcaV;
            cmd.Parameters.Add(pmtMarca);

            var pmtPlaca = cmd.CreateParameter();
            pmtPlaca.ParameterName = "@Placa";
            pmtPlaca.DbType = DbType.String;
            pmtPlaca.Value = v.PlacaV;
            cmd.Parameters.Add(pmtPlaca);

            var pmtChassi = cmd.CreateParameter();
            pmtChassi.ParameterName = "@Chassi";
            pmtChassi.DbType = DbType.String;
            pmtChassi.Value = v.ChassiV;
            cmd.Parameters.Add(pmtChassi);

            var pmtCateg = cmd.CreateParameter();
            pmtCateg.ParameterName = "@Categ";
            pmtCateg.DbType = DbType.String;
            pmtCateg.Value = v.CategV;
            cmd.Parameters.Add(pmtCateg);

            var pmtKm = cmd.CreateParameter();
            pmtKm.ParameterName = "@Km";
            pmtKm.DbType = DbType.String;
            pmtKm.Value = v.KmV;
            cmd.Parameters.Add(pmtKm);

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

        public bool Atualizar(EncVeiculos v)//faz a atualização dos campos do veiculo
        {
            string sql = "UPDATE tblVeiculos SET Nome = @Nome, Marca = @Marca, Placa = @Placa, Chassi = @Chassi, Km = @km Categoria = @Categ WHERE id = @Id";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtNome = cmd.CreateParameter();
            pmtNome.ParameterName = "@Nome";
            pmtNome.DbType = DbType.String;
            pmtNome.Value = v.NomeV;
            cmd.Parameters.Add(pmtNome);

            var pmtMarca = cmd.CreateParameter();
            pmtMarca.ParameterName = "@Marca";
            pmtMarca.DbType = DbType.String;
            pmtMarca.Value = v.MarcaV;
            cmd.Parameters.Add(pmtMarca);

            var pmtPlaca = cmd.CreateParameter();
            pmtPlaca.ParameterName = "@Placa";
            pmtPlaca.DbType = DbType.String;
            pmtPlaca.Value = v.PlacaV;
            cmd.Parameters.Add(pmtPlaca);

            var pmtChassi = cmd.CreateParameter();
            pmtChassi.ParameterName = "@Chassi";
            pmtChassi.DbType = DbType.String;
            pmtChassi.Value = v.ChassiV;
            cmd.Parameters.Add(pmtChassi);

            var pmtKm = cmd.CreateParameter();
            pmtKm.ParameterName = "@Km";
            pmtKm.DbType = DbType.String;
            pmtKm.Value = v.KmV;
            cmd.Parameters.Add(pmtKm);

            var pmtCateg = cmd.CreateParameter();
            pmtCateg.ParameterName = "@Categ";
            pmtCateg.DbType = DbType.String;
            pmtCateg.Value = v.CategV;
            cmd.Parameters.Add(pmtCateg);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@Id";
            pmtId.DbType = DbType.String;
            pmtId.Value = v.IdV;
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

        public bool AtualizarDisp(EncVeiculos v) // faz a atualização da disponibilidade do veiculo
        {
            string sql = "UPDATE tblVeiculos SET Disponibilidade =  @Disp WHERE Placa = @Placa";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtDisp = cmd.CreateParameter();
            pmtDisp.ParameterName = "@Disp";
            pmtDisp.DbType = DbType.String;
            pmtDisp.Value = v.DispV;
            cmd.Parameters.Add(pmtDisp);

            var pmtPlacaV = cmd.CreateParameter();
			pmtPlacaV.ParameterName = "@Placa";
			pmtPlacaV.DbType = DbType.String;
			pmtPlacaV.Value = v.PlacaV;
            cmd.Parameters.Add(pmtPlacaV);



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


        public bool Excluir(string chassi) // faz a exclução do veiculo
        {
            string sql = "DELETE FROM tblVeiculos WHERE Chassi = @Chassi;";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();

            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);
            var pmtLogin = cmd.CreateParameter();

            var pmtChassi = cmd.CreateParameter();
            pmtChassi.ParameterName = "@Chassi";
            pmtChassi.DbType = DbType.String;
            pmtChassi.Value = chassi;
            cmd.Parameters.Add(pmtChassi);

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

        public DataSet Listar()// lista todos os veiculo
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet veiculo = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Veiculo");
            tb.Columns.Add("iD", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Marca", typeof(string));
            tb.Columns.Add("Placa", typeof(string));
            tb.Columns.Add("Chassi", typeof(string));
            tb.Columns.Add("Km", typeof(string));
            tb.Columns.Add("Disponibilidade", typeof(string));
            tb.Columns.Add("Categoria", typeof(string));
            tb.Columns.Add("Id_Contrato", typeof(string));
            tb.Columns.Add("Id_Motorista", typeof(string));
            veiculo.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto  SqlDataReader
            string query = "SELECT * FROM tblVeiculos";
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
                linha["Disponibilidade"] = reader["Disponibilidade"].ToString();
                linha["Categoria"] = reader["Categoria"].ToString();
                linha["Id_Contrato"] = reader["Id_Contrato"].ToString();
                linha["Id_Motorista"] = reader["Id_Motorista"].ToString();
                // adiciona a nova linha a tabela
                veiculo.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return veiculo;
        }

        public bool AtualizarContrato(EncVeiculos v) //faz a realação entre contrarto e veiculo
        {
            string sql = "UPDATE tblVeiculos SET Id_Contrato = @IdCont WHERE tblVeiculos.Id = @IdVeiculo";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtIdCont = cmd.CreateParameter();
            pmtIdCont.ParameterName = "@IdCont";
            pmtIdCont.DbType = DbType.String;
            pmtIdCont.Value = v.IdCont;
            cmd.Parameters.Add(pmtIdCont);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@IdVeiculo";
            pmtId.DbType = DbType.String;
            pmtId.Value = v.IdV;
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
        public DataSet ListarCategoria(string categ)// lista as categorias do veiculo
        {

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            // criar uma instancia de DataSet
            DataSet veiculo = new DataSet();
            // cria um DataTable para ser adicionado ao DataSet
            DataTable tb = new DataTable("Veiculo");
            tb.Columns.Add("iD", typeof(Int32));
            tb.Columns.Add("Nome", typeof(string));
            tb.Columns.Add("Marca", typeof(string));
            tb.Columns.Add("Placa", typeof(string));
            tb.Columns.Add("Chassi", typeof(string));
            tb.Columns.Add("Km", typeof(string));
            tb.Columns.Add("Disponibilidade", typeof(string));
            tb.Columns.Add("Categoria", typeof(string));
            tb.Columns.Add("Id_Contrato", typeof(string));
            veiculo.Tables.Add(tb);

            // consulta o banco de dados, o retorno é um objeto  SqlDataReader
            string query = "SELECT * FROM tblVeiculos WHERE Categoria = @Categ";
            OleDbCommand cmd = new OleDbCommand(query, conexaodb);

            var pmtCateg = cmd.CreateParameter();
            pmtCateg.ParameterName = "@Categ";
            pmtCateg.DbType = DbType.String;
            pmtCateg.Value = categ;
            cmd.Parameters.Add(pmtCateg);

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
                linha["Disponibilidade"] = reader["Disponibilidade"].ToString();
                linha["Categoria"] = reader["Categoria"].ToString();
                linha["Id_Contrato"] = reader["Id_Contrato"].ToString();
                // adiciona a nova linha a tabela
                veiculo.Tables[0].Rows.Add(linha);
            }
            conexaodb.Close();
            return veiculo;
        }


        public bool AtualizarMotorista(EncVeiculos v) //atualiza motorista
        {
            string sql = "UPDATE tblVeiculos SET Id_Motorista = @IdMotorista WHERE tblVeiculos.Id = @IdVeiculo";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtIdMotorista = cmd.CreateParameter();
            pmtIdMotorista.ParameterName = "@IdMotorista";
            pmtIdMotorista.DbType = DbType.String;
            pmtIdMotorista.Value = v.IdMotorista;
            cmd.Parameters.Add(pmtIdMotorista);

            var pmtIdVeiculo = cmd.CreateParameter();
            pmtIdVeiculo.ParameterName = "@IdVeiculo";
            pmtIdVeiculo.DbType = DbType.String;
            pmtIdVeiculo.Value = v.IdV;
            cmd.Parameters.Add(pmtIdVeiculo);

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

        public bool AtualizarKm(EncVeiculos v)// atualiza o km do veiculo
        {
            string sql = "UPDATE tblVeiculos SET Km = @Km WHERE tblVeiculos.Id = @IdVeiculo";

            OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
            conexaodb.Open();
            OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

            var pmtKmV = cmd.CreateParameter();
            pmtKmV.ParameterName = "@KM";
            pmtKmV.DbType = DbType.String;
            pmtKmV.Value = v.KmV;
            cmd.Parameters.Add(pmtKmV);

            var pmtId = cmd.CreateParameter();
            pmtId.ParameterName = "@IdVeiculo";
            pmtId.DbType = DbType.String;
            pmtId.Value = v.IdV;
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

		public DataSet ListarWeb(string id)//lista dos os veiculos para web
		{

			OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
			conexaodb.Open();
			// criar uma instancia de DataSet
			DataSet veiculo = new DataSet();
			// cria um DataTable para ser adicionado ao DataSet
			DataTable tb = new DataTable("Veiculo");
			tb.Columns.Add("iD", typeof(Int32));
			tb.Columns.Add("Nome", typeof(string));
			tb.Columns.Add("Marca", typeof(string));
			tb.Columns.Add("Placa", typeof(string));
			tb.Columns.Add("Chassi", typeof(string));
			tb.Columns.Add("Km", typeof(string));
			tb.Columns.Add("Disponibilidade", typeof(string));
			tb.Columns.Add("Categoria", typeof(string));
			tb.Columns.Add("Id_Contrato", typeof(string));
			tb.Columns.Add("Id_Motorista", typeof(string));
			veiculo.Tables.Add(tb);

			// consulta o banco de dados, o retorno é um objeto  SqlDataReader
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
				DataRow linha = veiculo.Tables[0].NewRow();

				linha["Id"] = Convert.ToInt32(reader["Id"]);
				linha["Nome"] = reader["Nome"].ToString();
				linha["Marca"] = reader["Marca"].ToString();
				linha["Placa"] = reader["Placa"].ToString();
				linha["Chassi"] = reader["Chassi"].ToString();
				linha["Km"] = reader["Km"].ToString();
				linha["Disponibilidade"] = reader["Disponibilidade"].ToString();
				linha["Categoria"] = reader["Categoria"].ToString();
				linha["Id_Contrato"] = reader["Id_Contrato"].ToString();
				linha["Id_Motorista"] = reader["Id_Motorista"].ToString();
				// adiciona a nova linha a tabela
				veiculo.Tables[0].Rows.Add(linha);
			}
			conexaodb.Close();
			return veiculo;
		}
	}
}
