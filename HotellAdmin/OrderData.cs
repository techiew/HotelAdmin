using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotellAdmin {

	// Inneholder funksjoner for å hente bestillingsdata fra database/XML
	class OrderData {

		// Hent data som vi trenger om bestillinger
        public List<Order> GetData() {
			DataTable result = null;

			try {
				result = DatabaseManager.SelectFromTable("bestillinger", "tildelt = false").CopyToDataTable();
			} catch (InvalidOperationException) {
				
			}

			if (result == null) {
				Console.WriteLine("OrderData.GetData: Datasettet er tomt");
				return null;
			}

			List<Order> OrderList = new List<Order>();
			int orderID;
			string roomType;
			DateTime fromDate;
			DateTime toDate;
			string assigned;
			int phoneNumber;
			string firstName;
			string lastName;

			foreach (DataRow row in result.Rows) {
				orderID = (int)row["bestillingID"];
				roomType = (string)row["romtype"];
				fromDate = (DateTime)row["fradato"];
				toDate = (DateTime)row["tildato"];
                assigned = (string)row["tildelt"]; // == "false") ? false : true;   marius bøll
				phoneNumber = (int)row["tlf"];
				firstName = (string)row["fornavn"];
				lastName = (string)row["etternavn"];
                string fromDateString = fromDate.ToShortDateString();
                string toDateString = toDate.ToShortDateString();
                Order order = new Order(orderID, roomType, fromDateString, toDateString, assigned, phoneNumber, firstName, lastName);
                OrderList.Add(order);
            }

            return OrderList;
        }

    }

}
