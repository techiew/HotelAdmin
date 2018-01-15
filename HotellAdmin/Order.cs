using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Order {

		string firstName;
		string lastName;
		int roomType;

		public Order(string firstName, string lastName, int roomType) {
			this.firstName = firstName;
			this.lastName = lastName;
			this.roomType = roomType;
		}

	}

}
