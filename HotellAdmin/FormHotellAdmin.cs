using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

// FormHotellAdmin.cs - Håndtere visning av data
// OrderData.cs - Håndtere henting av bestillingsdata
// RoomData.cs - Håndtere henting av romdata
// DatabaseManager.cs - Håndtere funksjoner for SQL kommandoer, og åpne/lukke DB tilkobling
// Både RoomData og OrderData kan bruke DatabaseManager.cs
// BookingData.cs ???? - Hente data om booka rom, adde en funksjon som viser hvilke rom som er ledig og opptatt.

namespace HotellAdmin
{

    public partial class FormHotellAdmin : Form {

		int floors = 4;
		int roomsPerFloor = 11; // sett til # av labels i rutene?
		int selectedFloor = 1;
		List<Room> roomDataList;
		List<Order> orderDataList;
		List<Label> roomLabelList = new List<Label>();

		OrderData od = new OrderData();
		RoomData rd = new RoomData();

		Color roomOpen = Color.FromArgb(152, 251, 152); //50 205 50
		Color roomClosed = Color.FromArgb(255, 99, 71); //176 23 31

		public FormHotellAdmin() {
			InitializeComponent();
		}

		private void FormHotellAdmin_Load(object sender, EventArgs e) {
			// RequestLogin(); // Logge inn for å bruke programmet?
			OpenDatabase();
			GetRoomData();
			ShowRoomData(1);
			GetOrderData();
			ShowOrderData();
			// ShowOrderSchema(); // Finn ut hvordan lasse vil ha det, manuelt eller automatisk laget skjema?

			// Disse stopper ekstrem lag og CPU usage når vi resizer
			ResizeBegin += new EventHandler(FormHotellAdmin_ResizeBegin);
			ResizeEnd += new EventHandler(FormHotellAdmin_ResizeEnd);

			foreach (Control c in tableLayoutRoomsPanel.Controls) {
                c.DragDrop += new DragEventHandler(labels_DragDrop);
                c.DragOver += new DragEventHandler(labels_DragOver);
            }

			buttonFirstFloor.MouseDown += new MouseEventHandler(buttonFirstFloor_MouseDown);
			buttonSecondFloor.MouseDown += new MouseEventHandler(buttonSecondFloor_MouseDown);
			buttonThirdFloor.MouseDown += new MouseEventHandler(buttonThirdFloor_MouseDown);

			//La denne loopen ligge under de andre, tror det gjør slik at denne eventen blir triggera sist, og det er viktig
			foreach (Control c in tableLayoutFloorButtons.Controls.OfType<Button>()) {
				c.MouseDown += new MouseEventHandler(buttons_MouseDown);
            }

		}

		private void OpenDatabase() {
			//string db = @"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;";
			DatabaseManager.Open("46.9.246.190", "24440", "hotell", "admin", "admin");
		}

		private void GetRoomData() {
			roomDataList = rd.GetData();

			//if (roomDataList.Count != (floors * roomsPerFloor)) {
			//	ShowError("Feil med romdata."); // midlertidig feilhåndtering, burde endres?
			//} 

		}

		private void ShowRoomData(int floor) {

			if(roomDataList == null || roomDataList.Count == 0) {
				return;
			}

			if(roomLabelList.Count == 0) {

				foreach(Control c in tableLayoutRoomsPanel.Controls.OfType<Label>()) {
					roomLabelList.Add((Label)c);
				}

			}

			Console.WriteLine("Viser rom for " + floor + ". etasje");
			int index = (roomsPerFloor * (floor - 1));
			Room room;

			for (int i = 0;  i < roomLabelList.Count; i++) {
				Console.WriteLine(index + " | " + roomDataList.ElementAtOrDefault(index));
				Color buttonColor = Color.LightGray;
				string buttonText = "null";

				if (roomDataList.ElementAtOrDefault(index) != null) {
					room = roomDataList[index];

					buttonText =
						"Rom " + (room.number + 1) + "\n" +
						"Romtype: " + room.type + "\n" +
						"Status: " + ((room.status) ? "Okkupert" : "Ledig"); 

					buttonColor = (room.status) ? roomClosed : roomOpen;
				} else {
					buttonText =
						"Rom " + (index + 1) + "\n" +
						"Rommet er ikke definert i databasen";
				}

				roomLabelList[i].Text = buttonText;
				roomLabelList[i].BackColor = buttonColor;

				index++;
			}

		}

		private void GetOrderData() {
            orderDataList = od.GetData();
        }

		private void ShowOrderData() {

			if (orderDataList == null || orderDataList.Count == 0) {
				return;
			}

			for (int i = 0; i < orderDataList.Count; i++) {
				int orderID = orderDataList[i].orderID;
				string roomType = orderDataList[i].roomType;
				string fromDate = orderDataList[i].fromDate;     // Istedet for romtype skal vi ha fradato og tildato må også hente bestillingID
				string toDate = orderDataList[i].toDate;
				string status = orderDataList[i].status;
				int phoneNumber = orderDataList[i].phoneNumber;
				string firstName = orderDataList[i].firstName;
                string lastName = orderDataList[i].lastName;

				string order = orderID + " " + firstName + " " + lastName + " " + fromDate + " " + toDate;
                listBoxOrders.Items.Add(order);
            }

        }

		private void MakeNewOrder() {
			// TODO
			// For å manuelt lage en bestilling fra programmet
			// Bruk OrderData.MakeOrder(parameters); ELLER
			// Legg funksjonen over i en action handler for skjemaet
		}

		private void SyncOnDatabaseUpdate() {
			// TODO ?
			// Sync XML med database når en oppdatering skjer fra programmet vårt
			// Kanskje bruke DatabaseManager til å synce med xml
		}

		private void ShowError(string errorMsg) {
			// TODO
			// vis popup vindu med error
		}

		private void FormHotellAdmin_ResizeBegin(Object sender, EventArgs e) {
			SuspendLayout();
		}

		private void FormHotellAdmin_ResizeEnd(Object sender, EventArgs e) {
			ResumeLayout();
		}

		// En destructor for å lukke databasetilkoblingen når vi lukker programmet
		~FormHotellAdmin() {
			DatabaseManager.Close();
		}

		//Burde egentlig ha en felles event handler for disse, men knappene skal gjøre litt forskjellige ting.
		//så en felles handler hadde gjort koden mer DRY, men blir mer knotete å legge til forskjellige funksjonalitet
		//EDIT: adda en felles handler, men fortsatt ikke helt DRY
		//EDIT: nvm fiksa alt, men bare lar det her stå, ikke fjern pls
		private void buttonFirstFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 1;
		}

		private void buttonSecondFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 2;
		}

		private void buttonThirdFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 3;
		}

		private void buttons_MouseDown(object sender, MouseEventArgs e) {

			foreach (Control c in tableLayoutFloorButtons.Controls.OfType<Button>()) {
				c.BackColor = Color.White;
				c.ForeColor = Color.Black;
			}

			Button button = (sender as Button);
			button.BackColor = Color.CornflowerBlue;
			button.ForeColor = Color.White;

			ShowRoomData(selectedFloor);
        }

        private void listBoxOrders_MouseDown(object sender, MouseEventArgs e) {
            int index = listBoxOrders.IndexFromPoint(e.X, e.Y);

            if (index == -1) return;

            string s = listBoxOrders.Items[index].ToString();
            Console.WriteLine(s);
            DragDropEffects dde1 = DoDragDrop(s, DragDropEffects.All);

            if (dde1 == DragDropEffects.All) {
                listBoxOrders.Items.RemoveAt(index);
            }

        }
        private void labels_DragDrop(object sender, DragEventArgs e) {

			// sjekk denne - https://stackoverflow.com/questions/3240603/c-sharp-drag-and-drop-show-the-dragged-item-while-dragging
			if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                string listboxItemString = (string)e.Data.GetData(DataFormats.StringFormat);
                string[] splitItemString = listboxItemString.Split(' '); //Splitter opp stringen fra listeboksen
                string fromDate = splitItemString[3];   
                string toDate = splitItemString[4];
                string orderID = splitItemString[0];

                string labelString = (sender as Label).Text;
                string[] splitLabelString = labelString.Split('\n'); //Splitter opp de tre linjene stringFromLabel hadde
                string roomInfo = splitLabelString[0];                    //Henter første linje fra stringFromLabel, dette er rom X
                string[] splitRoomInfo = roomInfo.Split(' ');          //Splitter opp stringen romInfo
                string roomID = splitRoomInfo[1];                      //Henter det andre tegnet i stringen som er tallet

				DatabaseManager.Query("INSERT INTO booking (romID, bestillingID, fradato, tildato) VALUES (" + roomID + ", " + orderID + ", '" + fromDate + "', '" + toDate + "');");
                DatabaseManager.Query("UPDATE bestillinger SET tildelt = 'true' WHERE bestillingID =" + orderID + ";");
			}

        }

        private void labels_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }
 
    }

}
