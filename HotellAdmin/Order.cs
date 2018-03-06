using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Order {

		public int orderID;
		public string roomType;
        public string fromDate;
        public string toDate;
		public string status;
		public int phoneNumber;
		public string firstName;
		public string lastName;


		public Order(int orderID, string roomType, string fromDate, string toDate,
			string status, int phoneNumber, string firstName, string lastName) {

			this.orderID = orderID;
			this.roomType = roomType;
			this.fromDate = fromDate;
			this.toDate = toDate;
			this.status = status;
			this.phoneNumber = phoneNumber;
			this.firstName = firstName;
			this.lastName = lastName;
		}

	}

}
