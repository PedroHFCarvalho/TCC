using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PimDLL.BLL;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace PimDLL.DAL
{
	class LoginDAOAccess : IValidaLoginDAO // Classe Envia o Comando SQL para a classe ConexaoAccess
	{
		private ConexaoAccess conexao;

		public LoginDAOAccess()
		{
			conexao = new ConexaoAccess();
		}

		public bool Valida(EncLogin l)
		{
			string sql = "SELECT * FROM tblFuncionario WHERE Login = @Login and Senha = @Senha";

			OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
			conexaodb.Open();
			OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

			var pmtLogin = cmd.CreateParameter();
			pmtLogin.ParameterName = "@Login";
			pmtLogin.DbType = DbType.String;
			pmtLogin.Value = l.LoginU;
			cmd.Parameters.Add(pmtLogin);

			var pmtSenha = cmd.CreateParameter();
			pmtSenha.ParameterName = "@Senha";
			pmtSenha.DbType = DbType.String;
			pmtSenha.Value = l.SenhaU;
			cmd.Parameters.Add(pmtSenha);

			OleDbDataReader reader = cmd.ExecuteReader();

			if (reader.HasRows)
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

		public bool ValidaCliente(EncLogin l)//faz o login do cliente no sistema
		{
			string sql = "SELECT * FROM tblCliente WHERE Login = @Login and Senha = @Senha";

			OleDbConnection conexaodb = new OleDbConnection(conexao.InicializarAccess());
			conexaodb.Open();
			OleDbCommand cmd = new OleDbCommand(sql, conexaodb);

			var pmtLogin = cmd.CreateParameter();
			pmtLogin.ParameterName = "@Login";
			pmtLogin.DbType = DbType.String;
			pmtLogin.Value = l.LoginU;
			cmd.Parameters.Add(pmtLogin);

			var pmtSenha = cmd.CreateParameter();
			pmtSenha.ParameterName = "@Senha";
			pmtSenha.DbType = DbType.String;
			pmtSenha.Value = l.SenhaU;
			cmd.Parameters.Add(pmtSenha);

			OleDbDataReader reader = cmd.ExecuteReader();

			if (reader.HasRows)
			{
				while (reader.Read())
				{
					l.IdU = reader["Id_Cliente"].ToString();
				}
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
