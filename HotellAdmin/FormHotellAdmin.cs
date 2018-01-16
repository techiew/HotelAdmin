using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// FormHotellAdmin.cs - Håndtere visning av data
// OrderData.cs - Håndtere henting av bestillingsdata
// RoomData.cs - Håndtere henting av romdata
// DatabaseManager.cs - Håndtere funksjoner for SQL kommandoer, og åpne/lukke DB tilkobling
// Både RoomData og OrderData kan bruke DatabaseManager.cs

namespace HotellAdmin {

	public partial class FormHotellAdmin : Form {

		int floors = 4;
		int rooms = 14;
		int selectedFloor = 1;
		List<Room> roomDataList;
		List<Order> orderDataList;

		OrderData od = new OrderData();
		RoomData rd = new RoomData();

		public FormHotellAdmin() {
			InitializeComponent();
		}

		private void FormHotellAdmin_Load(object sender, EventArgs e) {
			// RequestLogin(); // Logge inn for å bruke programmet?
			GetRoomData();
			ShowRoomData(1);
			GetOrderData();
			ShowOrderData();
			// ShowOrderSchema(); // Finn ut hvordan lasse vil ha det, manuelt eller automatisk laget skjema?

		}

		private void GetRoomData() {
			// TODO
			// Hent data om alle rom fra en class som heter "RoomData"
			// List<Room> roomData = RoomData.GetData(); --- Sånn ca. det burde se ut
			// RoomData sin GetData funksjon må returnere en liste over rom
			roomDataList = rd.GetData();

			if (roomDataList.Count != (floors * rooms)) {
				ShowError("Feil med romdata."); // midlertidig feilhåndtering, burde endres?
			} 

		}

		private void ShowRoomData(int floor) {
			// TODO
			for (int i = 0; i < roomDataList.Count; i++) {
				Console.WriteLine(roomDataList[i].number);
			}

		}

		private void GetOrderData() {
			// XD
			// TODO
			// Hent data om alle bestillinger fra en class som heter "OrderData"
			// List<Order> orderData = OrderData.GetData(); --- Sånn ca. det burde se ut
			od.GetData();
			// OrderData sin GetData funksjon må returnere en liste over bestillinger
			List<Order> orderData = new List<Order>(); // Placeholder
			orderDataList = orderData;
		}

		private void ShowOrderData() {
			// TODO
			for(int i = 0; i < orderDataList.Count; i++) {
				// Legg bestillinger i listen til høyre
			}

		}

		private void MakeNewOrder() {
			// TODO
			// OrderData.MakeOrder(parameters); ELLER
			// Legg funksjonen over i en action handler for skjemaet
		}

		private void SyncOnDatabaseUpdate() {
			// TODO ?
			// Sync XML med database når en oppdatering skjer fra programmet vårt
		}

		private void ShowError(string errorMsg) {
			// TODO
		}

	}

}
