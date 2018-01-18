using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Room {

		public int number;
		public string type;
		public int price;
		public bool status;

		public Room(int number, string type, int price) {
			this.number = number;
			this.type = type;
			this.price = price;
			status = false;
		}

		public void SetStatus(bool status) {
			this.status = status;
		}

	}

}
