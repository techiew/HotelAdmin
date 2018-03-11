using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;


// FormHotellAdmin.cs - Håndtere visning av data
// OrderData.cs - Håndtere henting av bestillingsdata
// RoomData.cs - Håndtere henting av romdata
// DatabaseManager.cs - Håndtere funksjoner for SQL kommandoer, og åpne/lukke DB tilkobling
// BookingData.cs - Har funksjoner som viser om rom er ledige eller opptatt for en gitt periode

namespace HotellAdmin {

    public partial class FormHotellAdmin : Form {
		int floors = 4;
		int roomsPerFloor = 11; // sett til # av labels i rutene?
		int selectedFloor = 1;
        string flippedFromDate;
        string flippedToDate;
        string foreName;
        string afterName;
        string listBoxItems;
        int orderID;
		List<Room> roomDataList;
		List<Order> orderDataList;
		List<Booking> bookingDataList;
		List<Label> roomLabelList = new List<Label>();

		OrderData od = new OrderData();
		RoomData rd = new RoomData();
		BookingData bd = new BookingData();

		Color roomOpen = Color.FromArgb(152, 251, 152); //50 205 50
		Color roomClosed = Color.FromArgb(255, 99, 71); //176 23 31

		public FormHotellAdmin() {
			InitializeComponent();
        }

		private void FormHotellAdmin_Load(object sender, EventArgs e) {
            // RequestLogin(); // Logge inn for å bruke programmet?
            this.Size = Properties.Settings.Default.FormSize;
            colorBlindMode.Checked = Properties.Settings.Default.ColorBlind;
            OpenDatabase();
			GetRoomData();
			ShowRoomData(1);
			GetOrderData();
			ShowOrderData();
			GetBookingData();
			GetDropInData();
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

			headerPictureBox.BackColor = Color.FromArgb(45, 48, 50);

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
				//Console.WriteLine(index + " | " + roomDataList.ElementAtOrDefault(index));
				Color buttonColor = Color.LightGray;
				string buttonText = "null";

				if (roomDataList.ElementAtOrDefault(index) != null) {
					room = roomDataList[index];
                    bool isRoomAvailable = true;
                    string roomStatus = null;

                    if (room.wrongRoomType) {
                        isRoomAvailable = false;
                        roomStatus = "Feil romtype";
                    } else {

                        if (room.assigned) {
                            isRoomAvailable = false;
                            roomStatus = "Okkupert";
                        }

                    }
					buttonText =
						"Rom " + room.number + "\n" +
						"Romtype: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(room.type.ToLower()) + "\n" +
						"Status: " + ((isRoomAvailable) ? "Ledig" : roomStatus); 
					buttonColor = (isRoomAvailable) ? roomOpen : roomClosed;
				} else {
					buttonText =
						"Rom " + (index) + "\n" +
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

			listBoxOrders.Items.Clear();

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
                string order = lastName + "," + firstName + " : " + fromDate + " - " + toDate + " : " + roomType + " : " + orderID;
                listBoxOrders.Items.Add(order);
            }

        }

		private void GetBookingData() {
			bookingDataList = bd.GetData();
			//Console.WriteLine(BookingData.IsRoomOccupiedForPeriod(3, "2018-08-26", "2018-08-28"));
			//List<Room> availableRooms = BookingData.GetAvailableRoomsForPeriod("2018-08-22", "2018-08-25");
			//Console.WriteLine("Gyldige rom:");
			//for(int i = 0; i < availableRooms.Count; i++) {
			//	Console.WriteLine(availableRooms[i].number);
			//}

		}

		private void ShowRoomsForToday() {
			List<Room> availableRooms = BookingData.GetAvailableRoomsForToday();

			for (int i = 0; i < roomDataList.Count; i++) {
				bool isAssigned = true;

				for (int j = 0; j < availableRooms.Count; j++) {

					if (roomDataList[i].number == availableRooms[j].number) {
						isAssigned = false;
					}

				}

				roomDataList[i].assigned = isAssigned;
			}

			ShowRoomData(selectedFloor);
		}

		private void GetDropInData() {
            DataSet result = DatabaseManager.Query("SELECT romtype FROM romtyper;");
            string roomType;

            foreach (DataRow row in result.Tables["result"].Rows) {
                roomType = (string)row["romtype"];
                dropInComboBox.Items.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(roomType.ToLower()));
            }

            dropInComboBox.SelectedIndex = 0;
        }

		private void SyncOnDatabaseUpdate() {
			// TODO ?
			// Sync XML med database når en oppdatering skjer fra programmet vårt
			// Kanskje bruke DatabaseManager til å synce med xml
		}

		private void ShowLoadingBox() {
			// Vis en boks som feedback at programmet henter data?
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

            listBoxItems = listBoxOrders.Items[index].ToString();
			string[] listBoxSplit = listBoxItems.Split(':');
            string foreName = listBoxSplit[0].Split(',')[0].Trim();
            string afterName = listBoxSplit[0].Split(',')[1].Trim(); //greit å splitte opp navna også   :     ^       )    
			string partOne = listBoxSplit[1].Split('-')[0].Trim();
			string partTwo = listBoxSplit[1].Split('-')[1].Trim();
            string roomType = listBoxSplit[2].Trim().ToLower();
            string orderIDString = listBoxSplit[3].Trim();
            orderID = Int32.Parse(orderIDString);

            string[] fromDateSplit = partOne.Split('.');
			string[] toDateSplit = partTwo.Split('.');

			string fromDateString = fromDateSplit[2] + "-" + fromDateSplit[1] + "-" + fromDateSplit[0];
			string toDateString = toDateSplit[2] + "-" + toDateSplit[1] + "-" + toDateSplit[0];
            flippedFromDate = fromDateString;
            flippedToDate = toDateString; 
            List<Room> availableRooms = BookingData.GetAvailableRoomsForPeriod(fromDateString, toDateString);
			currentPeriod.Text = "Viser oversikt for: " + partOne + " - " + partTwo;

			for (int i = 0; i < roomDataList.Count; i++) {
				bool isAssigned = true;
                bool isWrongRoomType = true;

				for(int j = 0; j < availableRooms.Count; j++) {
					if(roomDataList[i].number == availableRooms[j].number) {
						isAssigned = false;
					} 
				}

                for (int j = 0; j < availableRooms.Count; j++) {

                    if (roomDataList[i].type == roomType) {
                        isWrongRoomType = false;
                    }

                }

                roomDataList[i].assigned = isAssigned;
                roomDataList[i].wrongRoomType = isWrongRoomType;
			}

			ShowRoomData(selectedFloor);

			DragDropEffects dde = DoDragDrop(listBoxItems, DragDropEffects.All);

            if (dde == DragDropEffects.All) {
                listBoxOrders.Items.RemoveAt(index); // må fikse slik at listeboks itemet bare blir fjerna hvis endringene faktisk skjer, er feks bugga hvis vi drar den inn i en tom romlabel
            }

        }

        private void labels_DragDrop(object sender, DragEventArgs e) {

			// sjekk denne - https://stackoverflow.com/questions/3240603/c-sharp-drag-and-drop-show-the-dragged-item-while-dragging    nei takk
			// jo, det skal vi mekke
			if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                string labelString = (sender as Label).Text;
                string[] splitLabelString = labelString.Split('\n'); //Splitter opp de tre linjene stringFromLabel hadde
                string roomInfo = splitLabelString[0];                    //Henter første linje fra stringFromLabel, dette er rom X
                string[] splitRoomInfo = roomInfo.Split(' ');          //Splitter opp stringen romInfo
                string roomIDString = splitRoomInfo[1];                      //Henter det andre tegnet i stringen som er tallet
                int roomID = Int32.Parse(roomIDString);

				if (roomDataList.ElementAtOrDefault(roomID) == null) return;

                Console.WriteLine(roomID);
                Console.WriteLine(roomDataList[roomID].assigned  + "Dette er roomdata is assigned");
                
                if (roomDataList[roomID].wrongRoomType == false) {
                    if (roomDataList[roomID].assigned == false)
                    {
                        string query = ("INSERT INTO booking(romID, bestillingID, fradato, tildato) VALUES(" + roomID + ", " + orderID + ", '" + flippedFromDate + "', '" + flippedToDate + "');");
                        DatabaseManager.Query(query);
                        DatabaseManager.Query("UPDATE bestillinger SET tildelt = 'true' WHERE bestillingID =" + orderID + ";");
                        roomDataList[roomID].assigned = true;
                        ShowRoomData(selectedFloor);
                    }
                    else
                    {
                        listBoxOrders.Items.Add(listBoxItems);
                        Console.WriteLine(listBoxItems);
                    }
                }
                else {
                    listBoxOrders.Items.Add(listBoxItems);
                    Console.WriteLine(listBoxItems);
                }

            }

        }

        private void labels_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }

		private void currentPeriod_Click(object sender, EventArgs e) {
			ShowRoomsForToday();
			currentPeriod.Text = "Viser oversikt for: i dag";
		}

		//Sjekk om dataene fylt inn i drop in er riktig
		private bool ValidateForm() {
			//Husk sjekk for om den er tom
			return true;
		}

        private void dropInConfirm_Click(object sender, EventArgs e) {
			bool validOrder = ValidateForm();

			if (!validOrder) return;

            string roomType = dropInComboBox.Text;
            string fromDate = dropInFromDate.Value.ToString("yyyy-MM-dd");
            string toDate = dropInToDate.Value.ToString("yyyy-MM-dd");
            string tlf = dropInPhoneNumber.Text;
            string foreName = dropInFirstname.Text;
            string afterName = dropInLastname.Text;
            string query = ("INSERT INTO bestillinger (romtype, fradato, tildato, tlf, fornavn, etternavn) VALUES ('" + roomType + "', '" + fromDate + "', '" + toDate + "', " + tlf + ", '" + foreName + "', '" + afterName + "');");
            DatabaseManager.Query(query);
            DropInMessage.Text = "Bestillingen har nå blitt registrert!";
            DropInMessage.Visible = true;
            GetOrderData();
			ShowOrderData();
        }

		private void dropInReset_Click(object sender, EventArgs e) {
			dropInFromDate.Text = "";
			dropInToDate.Text = "";
			dropInFirstname.Text = "";
			dropInLastname.Text = "";
			dropInPhoneNumber.Text = "";
		}

        private void colorBlindMode_CheckedChanged(object sender, EventArgs e) {

            if (colorBlindMode.Checked) {
               roomOpen = Color.FromArgb(0, 174, 239); //Blåfarge
               roomClosed = Color.FromArgb(255, 99, 71);
               Properties.Settings.Default.ColorBlind = true;
            }

            if (!colorBlindMode.Checked) {
               roomOpen = Color.FromArgb(152, 251, 152); //50 205 50
               roomClosed = Color.FromArgb(255, 99, 71); //176 23 31
               Properties.Settings.Default.ColorBlind = false;
            }

            ShowRoomData(1);
        }

        private void FormHotellAdmin_FormClosing(object sender, FormClosingEventArgs e) {
            Properties.Settings.Default.FormSize = this.Size;
            Properties.Settings.Default.Location = this.Location;
            Properties.Settings.Default.Save();
        }
    }

}