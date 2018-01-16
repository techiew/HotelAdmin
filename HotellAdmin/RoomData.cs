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
			DatabaseManager.Open();
			DataSet result = DatabaseManager.Query("SELECT * FROM hotellrom;");

			if(result == null) {
				Console.WriteLine("Null på dataset");
			}

			List<Room> rooms = new List<Room>();
			int number;
			string type;
			bool status;

			foreach(DataRow row in result.Tables["result"].Rows) {
				number = (int)row["romID"];
				type = (string)row["romType"];
				rooms.Add(new Room(number, type, false));
			}

			return rooms;
		}

	}

}
