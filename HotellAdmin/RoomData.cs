using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotellAdmin {

	class RoomData {

		public RoomData() {

		}

		public List<Room> GetData() {
			
			DataSet result = DatabaseManager.Query("SELECT * FROM rom;");

			if(result == null) {
				Console.WriteLine("Room.GetData: Datasettet er tomt");
				return null;
			}

			List<Room> rooms = new List<Room>();
			int number;
			string type;
			int price;

			foreach(DataRow row in result.Tables["result"].Rows) {
				number = (int)row["romID"];
				type = (string)row["romtype"];
				price = (int)row["pris"];
				rooms.Add(new Room(number, type, price));
			}

			return rooms;
		}

	}

}
