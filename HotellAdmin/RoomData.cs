using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace HotellAdmin {

	class RoomData {

		public List<Room> GetData() {
			
			DataSet result = DatabaseManager.Query("SELECT * FROM rom;");

			if(result == null) {
				Console.WriteLine("RoomData.GetData: Datasettet er tomt");
				return null;
			}

			List<Room> rooms = new List<Room>();
			int number;
			string type;

			foreach(DataRow row in result.Tables["result"].Rows) {
				number = (int)row["romID"];
				type = (string)row["romtype"];
				rooms.Add(new Room(number, type));
			}

			return rooms;
		}

	}

}
