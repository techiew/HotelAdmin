using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotellAdmin {

	class OrderData {

        public List<Order> GetData() {

            DataSet result = DatabaseManager.Query("SELECT bestillingID, romtype, fradato, tildato, tildelt, tlf, fornavn, etternavn FROM bestillinger WHERE tildelt = 'false';"); // Må adde "WHERE status = false" eller hva faen                                                                                            
            List<Order> OrderList = new List<Order>();

			if (result == null) {
				Console.WriteLine("OrderData.GetData: Datasettet er tomt");
				return null;
			}

			int orderID;
			string roomType;
			DateTime fromDate;
			DateTime toDate;
			string status;
			int phoneNumber;
			string firstName;
			string lastName;

			foreach (DataRow row in result.Tables["result"].Rows) {
				orderID = (int)row["bestillingID"];
				roomType = (string)row["romtype"];
				fromDate = (DateTime)row["fradato"];
				toDate = (DateTime)row["tildato"];
                status = (string)row["tildelt"]; // == "false") ? false : true;   marius bøll
				phoneNumber = (int)row["tlf"];
				firstName = (string)row["fornavn"];
				lastName = (string)row["etternavn"];

				string fromDateString = fromDate.ToShortDateString();
                string toDateString = toDate.ToShortDateString();
                Order order = new Order(orderID, roomType, fromDateString, toDateString,
					status, phoneNumber, firstName, lastName);
                OrderList.Add(order);
            }

            return OrderList;
        }

    }

}
