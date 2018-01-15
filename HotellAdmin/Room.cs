using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class Room {

		int number;
		int type;
		bool status;

		public Room(int number, int type, bool status) {
			this.number = number;
			this.type = type;
			this.status = status;
		}

	}

}
