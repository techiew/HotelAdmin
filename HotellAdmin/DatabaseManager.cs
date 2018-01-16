using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotellAdmin {

	static class DatabaseManager {

		static MySqlConnection conn = null;
		static MySqlCommand cmd;
		static MySqlCommandBuilder cb;
		static MySqlDataAdapter da;
		static DataSet ds;

		public static void Open(string server, string port, string database, string username, string password) {

			if (conn != null) {
				Console.WriteLine("En databasetilkobling eksisterer allerede");
				return;
			}

			string connectionString = 
				@"server="+server+";port="+port+";database="+database+";username="+username+";password="+password;

			try {

				conn = new MySqlConnection(connectionString);
				conn.Open();
				Console.WriteLine("Koblet til database. MySQL versjon: {0}", conn.ServerVersion);

			} catch (MySqlException ex) {
				Console.WriteLine("Error: {0}", ex.ToString());
			} 

		}

		public static void Close() {

			if (conn != null) {
				conn.Close();
				Console.WriteLine("Lukket databasetilkoblingen");
			}

		}

		public static DataSet Query(string sql) {

			if (conn == null) {
				Console.WriteLine("Ingen database er tilkoblet");
				return null;
			}

			cmd = new MySqlCommand(sql, conn);
			da = new MySqlDataAdapter(cmd);
			cb = new MySqlCommandBuilder(da);
			ds = new DataSet("result");
			da.Fill(ds, "result");

			return ds;
		}

	}

}
