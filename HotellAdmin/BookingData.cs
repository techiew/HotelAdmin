using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class BookingData {

		private static string dateFormat = "yyyy-MM-dd";

		//Henter alle registrerte bookinger i databasen som ikke har utgått (før dags dato)
		public List<Booking> GetData() {
			DataRow[] result = DatabaseManager.SelectFromTable("booking", "tildato >= #" + DateTime.Now.ToString(dateFormat) + "#");
			//DatabaseManager.Query("SELECT * FROM booking WHERE tildato >= CURDATE();");

			if (result == null) {
				Console.WriteLine("BookingData.GetData: Datasettet er tomt");
				return null;
			}

			List<Booking> bookings = new List<Booking>();
			int bookingID;
			int roomID;
			int orderID;
			string fromDate;
			string toDate;

			foreach (DataRow row in result) {
				bookingID = (int)row["bookingID"];
				roomID = (int)row["romID"];
				orderID = (int)row["bestillingID"];
				fromDate = ((DateTime)row["fradato"]).ToShortDateString();
				toDate = ((DateTime)row["tildato"]).ToShortDateString();
				bookings.Add(new Booking(bookingID, roomID, orderID, fromDate, toDate));
			}

			return bookings;
		}

		public static bool IsRoomOccupiedForPeriod(int roomID, string fromDate, string toDate) {
			//DataSet result = DatabaseManager.Query
			//(
			//"SELECT romID FROM booking WHERE tildato >= CURDATE() AND romID = " + roomID + " AND (fradato <= '" + toDate + "') AND ('" + fromDate + "' <= tildato);"  
			//);

			string fromDateCorrect = (DateTime.Parse(fromDate)).ToString(dateFormat);
			string toDateCorrect = (DateTime.Parse(toDate)).ToString(dateFormat);
			string curDate = DateTime.Now.ToString(dateFormat);

			int count = DatabaseManager.SelectFromTable
				(
				"booking", 
				"tildato >= #" + curDate + "#" +
				" AND romID = " + roomID + " AND (fradato <= #" + toDateCorrect + "#)" +
				" AND (#" + fromDateCorrect + "# <= tildato);"
				).Length;

			return (count == 0) ? false : true;
		}

		public static List<Room> GetAvailableRoomsForPeriod(string fromDate, string toDate) {
			//DataSet result = DatabaseManager.Query
			//	(
			//	"SELECT romID FROM rom WHERE romID NOT IN (SELECT romID FROM booking WHERE tildato >= CURDATE() AND (fradato <= '" + toDate + "') AND ('" + fromDate + "' <= tildato));"
			//	);

			string fromDateCorrect = (DateTime.Parse(fromDate)).ToString(dateFormat);
			string toDateCorrect = (DateTime.Parse(toDate)).ToString(dateFormat);
			string curDate = DateTime.Now.ToString(dateFormat);

			string subString = "";

			DataRow[] sub = DatabaseManager.SelectFromTable
				(
				"booking", 
				"tildato >= #" + curDate + "# AND (fradato <= #" + toDateCorrect + "#) AND (#" + fromDateCorrect + "# <= tildato)"
				);

			int roomID;

			foreach (DataRow row in sub) {
				roomID = (int)row["romID"];
				subString += roomID + ",";
			}

			if (subString.Length > 0) {
				subString = subString.Remove(subString.Length - 1);
			} else {
				subString = "-999";
			}

			DataRow[] result = DatabaseManager.SelectFromTable
				(
				"rom",
				"romID NOT IN (" + subString + ")"
				);
 
			if (result == null) {
				Console.WriteLine("BookingData.GetAvailableRoomsForPeriod: Datasettet er tomt");
				return new List<Room>();
			}

			List<Room> availableRooms = new List<Room>();

			foreach (DataRow row in result) {
				roomID = (int)row["romID"];
				availableRooms.Add(new Room(roomID, "Ukjent", false, false));
			}

			return availableRooms;
		}

		public static List<Room> GetAvailableRoomsForToday() {
			//DataSet result = DatabaseManager.Query
			//	(
			//	"SELECT romID FROM rom WHERE romID NOT IN (SELECT romID FROM booking WHERE tildato >= CURDATE() AND (fradato <= CURDATE()) AND (CURDATE() <= tildato));"
			//	);

			string curDate = DateTime.Now.ToString(dateFormat);

			string subString = "";

			DataRow[] sub = DatabaseManager.SelectFromTable
				(
				"booking", 
				"tildato >= #" + curDate + "# AND (fradato <= #" + curDate + "#) AND (#" + curDate + "# <= tildato)"
				);

			int roomID;

			foreach (DataRow row in sub) {
				roomID = (int)row["romID"];
				subString += roomID + ",";
			}

			if (subString.Length > 0) {
				subString = subString.Remove(subString.Length - 1);
			} else {
				subString = "-999";
			}

			DataRow[] result = DatabaseManager.SelectFromTable
				(
				"rom",
				"romID NOT IN (" + subString + ")"
				);

			if (result == null) {
				Console.WriteLine("BookingData.GetAvailableRoomsForPeriod: Datasettet er tomt");
				return new List<Room>();
			}

			List<Room> availableRooms = new List<Room>();

			foreach (DataRow row in result) {
				roomID = (int)row["romID"];
				availableRooms.Add(new Room(roomID, "Ukjent", false, false));
			}

			return availableRooms;
		}

	}

}
