using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace HotellAdmin {

	class OrderData {

		public OrderData() {

		}

		public void GetData() {
			string db =
			@"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;";

			MySqlConnection conn = null;

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

	}

}
