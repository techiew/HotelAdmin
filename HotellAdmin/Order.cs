using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Order {

		public string firstName;
		public string lastName;
		public string roomType;

		public Order(string firstName, string lastName, string roomType) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.roomType = roomType;
		}

	}

}
