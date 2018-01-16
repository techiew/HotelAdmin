using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotellAdmin {

	class OrderData {

        MySqlConnection connection = new MySqlConnection(@"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;");

        public List<Order> ReadTable() {
            connection.Open();
            DataSet visData = new DataSet("bestilling");
            MySqlDataAdapter hentData = new MySqlDataAdapter("SELECT fornavn, etternavn, romType, fraDato, tilDato FROM bestilling;", connection);
            hentData.Fill(visData, "bestilling");
            List<Order> OrderList = new List<Order>();
            string fornavn;
            string etternavn;
            string romType;

            foreach (DataRow rad in visData.Tables["bestilling"].Rows) {
                fornavn = (string)rad["fornavn"];
                etternavn = (string)rad["etternavn"];
                romType = (string)rad["romType"];
                Order Order = new Order(fornavn, etternavn, romType);
                OrderList.Add(Order);
            }

            return OrderList;
        }

    }

}
