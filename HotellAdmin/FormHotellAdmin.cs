using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


// FormHotellAdmin.cs - Håndtere visning av data på brukergrensesnittet
// OrderData.cs - Henting og håndtering av bestillingsdata
// RoomData.cs - Henting og håndtering av romdata
// DatabaseManager.cs - Håndtere funksjoner for datasett, åpne/lukke DB tilkobling, skrive til XML
// BookingData.cs - Har nyttige funksjoner for å f.eks. finne ledige rom til en gitt periode
// DatabaseErrorWindow.cs - Vise feilmeldinger relatert til databasen
// LoginWindow.cs - La brukeren logge inn

namespace HotellAdmin {

	// Hoved vinduet
    public partial class FormHotellAdmin : Form {

		int floors = 4;
		int roomsPerFloor = 11;
		int selectedFloor = 1;
		int orderID;
        int index;
        string flippedFromDate;
        string flippedToDate;
        string listBoxItems;
		bool loginRequired = true; // Slå av eller på kravet for å logge inn

		// Lister for å holde dataene våre
		List<Room> roomDataList;
		List<Order> orderDataList;
		List<Booking> bookingDataList;
		List<Label> roomLabelList = new List<Label>();

		// Klassene som henter data fra datasett
		OrderData od = new OrderData();
		RoomData rd = new RoomData();
		BookingData bd = new BookingData();

		Color roomOpen = Color.FromArgb(152, 251, 152); //50 205 50
		Color roomClosed = Color.FromArgb(255, 99, 71); //176 23 31
		Color roomWrongType = Color.FromArgb(255, 255, 150);

		Bitmap statusOnline = new Bitmap(Properties.Resources.status_online);
		Bitmap statusOffline = new Bitmap(Properties.Resources.status_offline);

		public FormHotellAdmin() {
			InitializeComponent();
        }

		// Start opp database, hent data, sette verdier og lag event handlers
		private void FormHotellAdmin_Load(object sender, EventArgs e) {

			OpenDatabase();
			if (loginRequired) RequestLogin();

            GetRoomData();
			ShowRoomData(1);
			GetOrderData();
			ShowOrderData();
			GetBookingData();
			GetDropInData();

			Size = Properties.Settings.Default.FormSize;
			colorBlindMode.Checked = Properties.Settings.Default.ColorBlind;
			headerPictureBox.BackColor = Color.FromArgb(45, 48, 50);
			autoSyncXML.Checked = Properties.Settings.Default.AutoSyncXML;
			DatabaseManager.SetAutoSyncStatus(autoSyncXML.Checked);

			// Disse stopper ekstrem lag og prossessorbruk når vi resizer vinduet
			ResizeBegin += new EventHandler(FormHotellAdmin_ResizeBegin);
			ResizeEnd += new EventHandler(FormHotellAdmin_ResizeEnd);

			foreach (Control c in tableLayoutRoomsPanel.Controls) {
                c.DragDrop += new DragEventHandler(labels_DragDrop);
                c.DragOver += new DragEventHandler(labels_DragOver);
            }

			buttonFirstFloor.MouseDown += new MouseEventHandler(buttonFirstFloor_MouseDown);
			buttonSecondFloor.MouseDown += new MouseEventHandler(buttonSecondFloor_MouseDown);
			buttonThirdFloor.MouseDown += new MouseEventHandler(buttonThirdFloor_MouseDown);

            foreach (Control c in tableLayoutFloorButtons.Controls.OfType<Button>()) {
				c.MouseDown += new MouseEventHandler(buttons_MouseDown);
            }

		}

		// Prøv å koble til databasen via DatabaseManager
        private void OpenDatabase() {
			//string db = @"server=46.9.246.190;database=hotell;port=24440;userid=admin;password=admin;";
			DatabaseManager.Init(this);
			DatabaseManager.Open("46.9.246.190", "24440", "hotell", "admin", "admin");

			// Hvis vi ikke får koblet til, vis en errormelding
			while (!DatabaseManager.IsConnected() && !DatabaseManager.IsUsingLocalDatabase()) {
				ShowDatabaseError();
			}

		}

		// Hent data for alle rom og legg det i en liste
		private void GetRoomData() {
			roomDataList = rd.GetData();
		}

		// Vis rom dataene i romrutene
		private void ShowRoomData(int floor) {

			if(roomLabelList.Count == 0) {

				foreach(Control c in tableLayoutRoomsPanel.Controls.OfType<Label>()) {
					roomLabelList.Add((Label)c);
				}

			}

			Console.WriteLine("Viser rom for " + floor + ". etasje");
			int index = (roomsPerFloor * (floor - 1));
			Room room;

			// Loop over alle romrutene og fyll inn data
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
						"Rom " + (room.number + 1) + "\n" +
						"Romtype: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(room.type.ToLower()) + "\n" +
						"Status: " + ((isRoomAvailable) ? "Ledig" : roomStatus); 
					buttonColor = (isRoomAvailable) ? roomOpen : (room.wrongRoomType) ? roomWrongType : roomClosed;
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

		// Hent bestillingsdata og legg det i en liste
		private void GetOrderData() {
            orderDataList = od.GetData();
        }

		// Vis utildelte bestillinger i listeboksen til høyre
		private void ShowOrderData() {

			listBoxOrders.Items.Clear();

			if (orderDataList == null || orderDataList.Count == 0) {
				return;
			}

			for (int i = 0; i < orderDataList.Count; i++) {
				int orderID = orderDataList[i].orderID;
				string roomType = orderDataList[i].roomType;
				string fromDate = orderDataList[i].fromDate;
				string toDate = orderDataList[i].toDate;
				string status = orderDataList[i].status;
				int phoneNumber = orderDataList[i].phoneNumber;
				string firstName = orderDataList[i].firstName;
                string lastName = orderDataList[i].lastName;
                string order = lastName + "," + firstName + " : " + fromDate + " - " + toDate + " : " + roomType + " : " + orderID;
                listBoxOrders.Items.Add(order);
            }

        }

		// Hent data om booking (bestillinger som er tildelt)
		private void GetBookingData() {
			bookingDataList = bd.GetData();
		}

		// Fyll inn nødvendig data i drop-in skjemaet
		private void GetDropInData() {
			DataRow[] result = DatabaseManager.SelectFromTable("romtyper", "romtype <> 'xdxdxdxd'");
			//DatabaseManager.Query("SELECT romtype FROM romtyper;"); // TODO: må fikse han karen her, funker ikke i offline modus
			string roomType;

			if (result == null) return;

			foreach (DataRow row in result) {
				roomType = (string)row["romtype"];
				dropInComboBox.Items.Add(CultureInfo.CurrentCulture.TextInfo.ToTitleCase(roomType.ToLower()));
			}

			dropInComboBox.SelectedIndex = 0;
		}

		// Finn alle rom som er ledige for dags dato
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

		// Vis feilmelding for database, la brukeren velge om de vil bruke XML-filen som database
		public void ShowDatabaseError() {
			DatabaseErrorWindow dew = new DatabaseErrorWindow();
			var result = dew.ShowDialog();

			if (result == DialogResult.Cancel) {
				this.Close();
				Environment.Exit(0);
			} else if (result == DialogResult.Retry) {
				OpenDatabase();
			}

		}

		// Endre bilde og tekst på status ikonet oppe i høyre hjørne -- eksisterer ikke lenger
		public void UpdateDatabaseStatus(bool status) {

			//if (status) {
			//	iconDatabaseStatus.Image = statusOnline;
			//	labelDatabaseStatus.Text = "Online";
			//	optionLabelDatabaseStatus.Text = "Online database er tilkoblet.";
			//	changeDatabaseStatusButton.Text = "Bruk offline database (XML)";
			//} else {
			//	iconDatabaseStatus.Image = statusOffline;
			//	labelDatabaseStatus.Text = "Offline";
			//	optionLabelDatabaseStatus.Text = "Offline databasen er i bruk.";
			//	changeDatabaseStatusButton.Text = "Koble til online databasen";
			//}

		}

		// Be brukeren om å logge inn
		private void RequestLogin() {
			LoginWindow lw = new LoginWindow();
			var result = lw.ShowDialog();

			if (result == DialogResult.Abort) {
				this.Close();
				Environment.Exit(0);
			} else if (result == DialogResult.OK) {
				Console.WriteLine("Innlogging godkjent.");
			}

		}

		//Sjekk om dataene fylt inn i drop in er riktig
		private bool ValidateForm() {
			//Husk sjekk for om den er tom
			return true;
		}

		// En destructor for å lukke databasetilkoblingen når vi lukker programmet
		~FormHotellAdmin() {
			DatabaseManager.Close();
		}




		//EVENT HANDLERS ---------------------------------------------------------------------------

		// Etasjeknappene
		private void buttonFirstFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 1;
		}

		private void buttonSecondFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 2;
		}

		private void buttonThirdFloor_MouseDown(object sender, EventArgs e) {
			selectedFloor = 3;
		}

		// Felles event handler for alle etasjeknappene
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

		// Bestillings-listeboksen
        private void listBoxOrders_MouseDown(object sender, MouseEventArgs e) {
            index = listBoxOrders.IndexFromPoint(e.X, e.Y);

            if (index == -1) return;

            listBoxItems = listBoxOrders.Items[index].ToString();
			string[] listBoxSplit = listBoxItems.Split(':');
            string firstName = listBoxSplit[0].Split(',')[0].Trim();
            string lastName = listBoxSplit[0].Split(',')[1].Trim(); //greit å splitte opp navna også   :     ^       )    
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

        }

		// DragDrop handler for romrutene
        private void labels_DragDrop(object sender, DragEventArgs e) {

			if (e.Data.GetDataPresent(DataFormats.StringFormat)) {
                string labelString = (sender as Label).Text;
                string[] splitLabelString = labelString.Split('\n'); //Splitter opp de tre linjene stringFromLabel hadde
                string roomInfo = splitLabelString[0];                    //Henter første linje fra stringFromLabel, dette er rom X
                string[] splitRoomInfo = roomInfo.Split(' ');          //Splitter opp stringen romInfo
                string roomIDString = splitRoomInfo[1];                      //Henter det andre tegnet i stringen som er tallet
                int roomID = Int32.Parse(roomIDString) - 1;

				if (roomDataList.ElementAtOrDefault(roomID) == null) return;

                Console.WriteLine(roomID);
                Console.WriteLine(roomDataList[roomID].assigned  + "Dette er roomdata is assigned");
                
                if (roomDataList[roomID].wrongRoomType == false) {

					if (roomDataList[roomID].assigned == false) {
                        listBoxOrders.Items.RemoveAt(index);
                        DataRow row = DatabaseManager.GetRowWithSchema("booking");
						row["romID"] = roomID;
						row["bestillingID"] = orderID;
						row["fradato"] = flippedFromDate;
						row["tildato"] = flippedToDate;
						DatabaseManager.InsertRow("booking", row);

						row = DatabaseManager.FindRowInTable("bestillinger", orderID);
						row["tildelt"] = "true";
						DatabaseManager.UpdateRow("bestillinger", orderID.ToString(), row);

                        roomDataList[roomID].assigned = true;
                        ShowRoomData(selectedFloor);
                    } 

                } 
           
            }

        }

		// Romrutene
        private void labels_DragOver(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.All;
        }

		// Handler for periodeknappen oppe i midten, lar deg gå tilbake til dags dato
		private void currentPeriod_Click(object sender, EventArgs e) {

			for (int i = 0; i < roomDataList.Count; i++) {
				roomDataList[i].wrongRoomType = false;
			}

			ShowRoomsForToday();
			currentPeriod.Text = "Viser oversikt for: i dag";
		}

		// Submit knappen i drop-in skjemaet
        private void dropInConfirm_Click(object sender, EventArgs e) {
			bool validOrder = ValidateForm();

			if (!validOrder) return;

            string roomType = dropInComboBox.Text;
            string fromDate = dropInFromDate.Value.ToString("yyyy-MM-dd");
            string toDate = dropInToDate.Value.ToString("yyyy-MM-dd");
            string tlf = dropInPhoneNumber.Text;
            string firstName = dropInFirstname.Text;
            string lastName = dropInLastname.Text;
			DataRow row = DatabaseManager.GetRowWithSchema("bestillinger");
			row["romtype"] = roomType;
			row["fradato"] = fromDate;
			row["tildato"] = toDate;
			row["tildelt"] = false;
			row["tlf"] = tlf;
			row["fornavn"] = firstName;
			row["etternavn"] = lastName;
			DatabaseManager.InsertRow("bestillinger", row);
			//DatabaseManager.Query("INSERT INTO bestillinger (romtype, fradato, tildato, tlf, fornavn, etternavn)" +
			//"VALUES ('" + roomType + "', '" + fromDate + "', '" + toDate + "', " + tlf + ", '" + foreName + "', '" + afterName + "');");
            DropInMessage.Text = "Bestillingen har nå blitt registrert!";
            DropInMessage.Visible = true;
            GetOrderData();
			ShowOrderData();
        }

		// Nullstill knappen på skjemaet
		private void dropInReset_Click(object sender, EventArgs e) {
			dropInFromDate.Text = "";
			dropInToDate.Text = "";
			dropInFirstname.Text = "";
			dropInLastname.Text = "";
			dropInPhoneNumber.Text = "";
		}

		// Fargeblindmodus innstilling
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

		// Når checkboxen for automatisk XML synkronisering trykkes
		private void autoSyncXML_CheckedChanged(object sender, EventArgs e) {

			if(autoSyncXML.Checked) {
				Properties.Settings.Default.AutoSyncXML = true;
			} else {
				Properties.Settings.Default.AutoSyncXML = false;
			}

			DatabaseManager.SetAutoSyncStatus(autoSyncXML.Checked);
		}

		// Når XML synkroniseringsknappen trykkes
		private void syncXMLNowButton_Click(object sender, EventArgs e) {
			DatabaseManager.SyncXML();
		}

		// Startes hvis vinduet blir lukket, lagrer innstillinger
		private void FormHotellAdmin_FormClosing(object sender, FormClosingEventArgs e) {
			Properties.Settings.Default.FormSize = this.Size;
			Properties.Settings.Default.Location = this.Location;
			Properties.Settings.Default.Save();
		}

		// Når brukeren endrer størrelsen på vinduet...
		private void FormHotellAdmin_ResizeBegin(object sender, EventArgs e) {
			SuspendLayout();
		}

		// Når brukeren slutter å endre størrelsen på vinduet...
		private void FormHotellAdmin_ResizeEnd(object sender, EventArgs e) {
			ResumeLayout();
		}

	}

}