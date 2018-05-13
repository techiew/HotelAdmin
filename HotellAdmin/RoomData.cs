using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotellAdmin {

	class RoomData {

		public List<Room> GetData() {

			DataTable result = DatabaseManager.GetTable("rom");

			if(result == null) {
				Console.WriteLine("RoomData.GetData: DataTable er tomt");
				return null;
			}

			List<Room> rooms = new List<Room>();
			int number;
			string type;

			foreach(DataRow row in result.Rows) {
				number = (int)row["romID"];
				type = (string)row["romtype"];
				rooms.Add(new Room(number, type, false, false));
			}

			return rooms;
		}

	}

}
