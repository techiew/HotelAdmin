using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {
	class Booking {
		public int bookingID;
		public int roomID;
		public int orderID;
		public string fromDate;
		public string toDate;

		public Booking(int bookingID, int roomID, int orderID, string fromDate, string toDate) {
			this.bookingID = bookingID;
			this.roomID = roomID;
			this.orderID = orderID;
			this.fromDate = fromDate;
			this.toDate = toDate;
		}

	}
}
