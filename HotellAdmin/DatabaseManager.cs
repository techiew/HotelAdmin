using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotellAdmin {

	static class DatabaseManager {

		private static MySqlConnection conn = null;
		private static MySqlCommand cmd;
		private static MySqlCommandBuilder cb;
		private static MySqlDataAdapter da;
		private static DataSet ds;

		public static void Open(string server, string port, string database, string username, string password) {

			if (conn != null) {

				if (conn.State == ConnectionState.Open) {
					Console.WriteLine("Open: En databasetilkobling eksisterer allerede");
					return;
				}

			}

			string connectionString = 
				@"server="+server+";port="+port+";database="+database+";username="+username+";password="+password;

			try {
				conn = new MySqlConnection(connectionString);
				conn.Open();
				Console.WriteLine("Open: Koblet til database. MySQL versjon: {0}", conn.ServerVersion);
			} catch (MySqlException ex) {
				Console.WriteLine("Error: {0}", ex.ToString());
			} 

		}

		public static void Close() {

			if (conn.State == ConnectionState.Open) {
				conn.Close();
				Console.WriteLine("Close: Lukket databasetilkoblingen");
			} else {
				Console.WriteLine("Close: Ingen database er tilkoblet");
			}

		}

		public static DataSet Query(string sql) {

			if (conn == null || conn.State == ConnectionState.Closed) {
				Console.WriteLine("Query: Ingen database er tilkoblet");
				return null;
			}

			cmd = new MySqlCommand(sql, conn);
			da = new MySqlDataAdapter(cmd);
			cb = new MySqlCommandBuilder(da);
			ds = new DataSet("result");
			da.Fill(ds, "result");

			Console.WriteLine(sql);

			return ds;
		}

	}

}
