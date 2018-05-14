using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	// En datastruktur for å holde romdata
	class Room {

		public int number;
		public string type;
		public bool assigned;
        public bool wrongRoomType;

		public Room(int number, string type, bool assigned, bool roomType) {
			this.number = number;
			this.type = type;
			this.assigned = false;
            this.wrongRoomType = false;
		}

	}

}
