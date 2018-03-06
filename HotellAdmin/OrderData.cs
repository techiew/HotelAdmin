using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace HotellAdmin {

	class OrderData {

        public List<Order> ReadTable() {

            DataSet visData = DatabaseManager.Query("SELECT bestillingID, fornavn, etternavn, fradato, tildato FROM bestillinger;"); // Må adde "WHERE status = false" eller hva faen                                                                                            
            List<Order> OrderList = new List<Order>();
            string fornavn;
            string etternavn;
            int bestillingID;
            DateTime fraDato;
            DateTime tilDato;

            foreach (DataRow rad in visData.Tables["result"].Rows) {
                fornavn = (string)rad["fornavn"];
                etternavn = (string)rad["etternavn"];
                bestillingID = (int)rad["bestillingID"];
                fraDato = (DateTime)rad["fradato"];
                tilDato = (DateTime)rad["tildato"];
                var fraDatoString = fraDato.ToShortDateString();
                var tilDatoString = tilDato.ToShortDateString();
                Order Order = new Order(fornavn, etternavn, bestillingID, fraDatoString, tilDatoString);
                OrderList.Add(Order);
            }

            return OrderList;
        }

    }

}
