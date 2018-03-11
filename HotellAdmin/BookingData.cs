using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellAdmin {

	class BookingData {

		//Henter alle registrerte bookinger i databasen som ikke har utgått
		public List<Booking> GetData() {
			DataSet result = DatabaseManager.Query("SELECT * FROM booking WHERE tildato >= CURDATE();");

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

			foreach (DataRow row in result.Tables["result"].Rows) {
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
			DataSet result = DatabaseManager.Query
				(
				"SELECT romID FROM booking WHERE tildato >= CURDATE() AND romID = " + roomID + " AND (fradato <= '" + toDate + "') AND ('" + fromDate + "' <= tildato);"  
				);

			if (result == null) {
				Console.WriteLine("BookingData.IsRoomOccupiedForPeriod: Datasettet er tomt");
				return true;
			}

			return (result.Tables[0].Rows.Count == 0) ? false : true;
		}

		public static List<Room> GetAvailableRoomsForPeriod(string fromDate, string toDate) {
			DataSet result = DatabaseManager.Query
				(
				"SELECT romID FROM rom WHERE romID NOT IN (SELECT romID FROM booking WHERE tildato >= CURDATE() AND (fradato <= '" + toDate + "') AND ('" + fromDate + "' <= tildato));"
				);

			if (result == null) {
				Console.WriteLine("BookingData.GetAvailableRoomsForPeriod: Datasettet er tomt");
				return new List<Room>();
			}

			List<Room> availableRooms = new List<Room>();
			int roomID;

			foreach (DataRow row in result.Tables["result"].Rows) {
				roomID = (int)row["romID"];
				availableRooms.Add(new Room(roomID, "Ukjent", false, false));
			}

			return availableRooms;
		}

		public static List<Room> GetAvailableRoomsForToday() {
			DataSet result = DatabaseManager.Query
				(
				"SELECT romID FROM rom WHERE romID NOT IN (SELECT romID FROM booking WHERE tildato >= CURDATE() AND (fradato <= CURDATE()) AND (CURDATE() <= tildato));"
				);

			if (result == null) {
				Console.WriteLine("BookingData.GetAvailableRoomsForPeriod: Datasettet er tomt");
				return new List<Room>();
			}

			List<Room> availableRooms = new List<Room>();
			int roomID;

			foreach (DataRow row in result.Tables["result"].Rows) {
				roomID = (int)row["romID"];
				availableRooms.Add(new Room(roomID, "Ukjent", false, false));
			}

			return availableRooms;
		}

	}

}
