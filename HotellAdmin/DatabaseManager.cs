using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotellAdmin {

	class DatabaseManager {

		const string db =
		@"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;";
		static MySqlConnection conn = null;
		static MySqlCommand cmd;
		static MySqlCommandBuilder cb;
		static MySqlDataAdapter da;
		static DataSet ds;
		
		public static void Open() {

			if (conn != null) return;

			try {

				conn = new MySqlConnection(db);
				conn.Open();
				Console.WriteLine("MySQL version : {0}", conn.ServerVersion);

			} catch (MySqlException ex) {
				Console.WriteLine("Error: {0}", ex.ToString());
			} 

		}

		public static void Close() {

			if (conn != null) {
				conn.Close();
			}

		}

		public static DataSet Query(string sql) {

			if (conn == null) {
				Console.WriteLine("Null på database");
				return null;
			}

			cmd = new MySqlCommand(sql, conn);
			da = new MySqlDataAdapter(cmd);
			cb = new MySqlCommandBuilder(da);
			ds = new DataSet("result");
			da.Fill(ds, "result");

			return ds;
		}

		~DatabaseManager() {
			Close();
		}

	}

}
