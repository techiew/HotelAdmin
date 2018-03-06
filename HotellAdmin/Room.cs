using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Room {

		public int number;
		public string type;
		public bool status;

		public Room(int number, string type) {
			this.number = number;
			this.type = type;
			status = false;
		}

		public void SetStatus(bool status) {
			this.status = status;
		}

	}

}
