using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotellAdmin {

	class DatabaseManager {

		const string db =
		@"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;";
		static MySqlConnection conn = null;
		
		public void Open() {
			try {
				conn = new MySqlConnection(db);
				conn.Open();
				Console.WriteLine("MySQL version : {0}", conn.ServerVersion);
			} catch (MySqlException ex) {
				Console.WriteLine("Error: {0}", ex.ToString());
			} finally {

				if (conn != null) {
					conn.Close();
				}

			}
		}

		public void Close() {
			if (conn != null) {
				conn.Close();
			}
		}

		public void Query(string mysqlQuery) {

		}

	}

}
