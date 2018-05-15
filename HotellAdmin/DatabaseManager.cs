using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;

namespace HotellAdmin {

	// Denne klassen er ansvarlig for å holde styr på databasetilkoblingen vår
	// Den kan åpne og lukke databasetilkobling fra MySql databasen vår
	// eller lese data fra en lokal XML fil.
	// Vi kan sende spørringer for data uavhengig om de ligger i XML eller på databasen
	// Endringer på databasen blir synkronisert i den lokale XML filen automatisk
	static class DatabaseManager {

	    private static bool initialized = false;
		private static bool connected;
		private static bool usingLocalDatabase;
		private static bool autoSyncXML;
		private static MySqlConnection conn;
		private static DataSet ds;
		private static DataTable employeesTable;
		private static DataTable ordersTable;
		private static DataTable bookingTable;
		private static DataTable roomTable;
		private static DataTable roomTypesTable;
		private static MySqlDataAdapter da;
		private static MySqlDataAdapter daEmployees;
		private static MySqlDataAdapter daOrders;
		private static MySqlDataAdapter daBooking;
		private static MySqlDataAdapter daRoom;
		private static MySqlDataAdapter daRoomTypes;
		private static FormHotellAdmin gui;

		// Sett noen standard verdier, må kjøres først
		public static void Init(FormHotellAdmin gui) {
			if (initialized) return;
			initialized = true;
			conn = null;
			connected = false;
			usingLocalDatabase = false;
			autoSyncXML = true;
			ds = new DataSet();
			ds.DataSetName = "HotellAdmin";
			DatabaseManager.gui = gui;
		}

		// Åpne databasetilkobling
		public static void Open(string server, string port, string database, string username, string password) {

			if (!initialized) return;

			if (conn != null) {

				if (conn.State == ConnectionState.Open) {
					Console.WriteLine("Open: En databasetilkobling eksisterer allerede");
					return;
				}

			}

			string connectionString = 
				@"server="+server+";port="+port+";database="+database+";username="+username+";password="+password;

			try {
				conn = new MySqlConnection(connectionString);
				conn.StateChange -= new StateChangeEventHandler(OnStateChange);
				conn.StateChange += new StateChangeEventHandler(OnStateChange);
				conn.Open();
				FillDataSet();
				//MergeLocalAndExternalDatabase(); funker ikke ordentlig
				usingLocalDatabase = false;
				connected = true;

				Console.WriteLine("Open: Koblet til database. MySQL versjon: {0}", conn.ServerVersion);

			} catch (MySqlException ex) {
				connected = false;
				Console.WriteLine("Error: {0}", ex.ToString());
			} 

		}

		// Les data fra XML fil -- denne brukes ikke lenger
		public static void OpenLocalDatabase() {

			if (!File.Exists("hotelladmin_database.xml")) {
				Console.WriteLine("Database XML filen eksisterer ikke");
				return;
			} else if(!File.Exists("hotelladmin_schema.xml")) {
				Console.WriteLine("Database skjema filen eksisterer ikke");
				return;
			}

			if (usingLocalDatabase || !initialized) return;

			if (connected) {
				conn.Close();
				connected = false;
			}

			ds.Clear();
			ds.ReadXmlSchema("hotelladmin_schema.xml");
			ds.ReadXml("hotelladmin_database.xml");
			usingLocalDatabase = true;

			employeesTable = ds.Tables["ansatte"];
			ordersTable = ds.Tables["bestillinger"];
			bookingTable = ds.Tables["booking"];
			roomTable = ds.Tables["rom"];
			roomTypesTable = ds.Tables["romtyper"];
		}

		// Lukk databasetilkobling
		public static void Close() {

			if (!initialized) return;

			if (conn.State == ConnectionState.Open) {
				conn.Close();
				Console.WriteLine("Close: Lukket databasetilkoblingen");
				connected = false;
			} else {
				Console.WriteLine("Close: Ingen database er tilkoblet");
			}

		}

		// Fyll opp datasettet vårt via databasen
		private static void FillDataSet() {

			if (!initialized) return;

			ds.Clear();

			daEmployees = new MySqlDataAdapter("SELECT * FROM ansatte", conn);
			daOrders = new MySqlDataAdapter("SELECT * FROM bestillinger", conn);
			daBooking = new MySqlDataAdapter("SELECT * FROM booking", conn);
			daRoom = new MySqlDataAdapter("SELECT * FROM rom ORDER BY romID ASC;", conn);
			daRoomTypes = new MySqlDataAdapter("SELECT * FROM romtyper", conn);

			MySqlCommandBuilder cbEmployees = new MySqlCommandBuilder(daEmployees);
			MySqlCommandBuilder cbOrders = new MySqlCommandBuilder(daOrders);
			MySqlCommandBuilder cbBooking = new MySqlCommandBuilder(daBooking);
			MySqlCommandBuilder cbRoom = new MySqlCommandBuilder(daRoom);
			MySqlCommandBuilder cbRoomTypes = new MySqlCommandBuilder(daRoomTypes);

			daEmployees.FillSchema(ds, SchemaType.Source, "ansatte");
			daOrders.FillSchema(ds, SchemaType.Source, "bestillinger");
			daBooking.FillSchema(ds, SchemaType.Source, "booking");
			daRoom.FillSchema(ds, SchemaType.Source, "rom");
			daRoomTypes.FillSchema(ds, SchemaType.Source, "romtyper");

			daEmployees.Fill(ds, "ansatte");
			daOrders.Fill(ds, "bestillinger");
			daBooking.Fill(ds, "booking");
			daRoom.Fill(ds, "rom");
			daRoomTypes.Fill(ds, "romtyper");

			employeesTable = ds.Tables["ansatte"];
			ordersTable = ds.Tables["bestillinger"];
			bookingTable = ds.Tables["booking"];
			roomTable = ds.Tables["rom"];
			roomTypesTable = ds.Tables["romtyper"];
		}

		// Slå sammen dataene fra XML fil med dataene på databasen
		private static void MergeLocalAndExternalDatabase() {
			DataSet local = new DataSet("local");
			bool schemaExists = File.Exists("hotelladmin_schema.xml");
			bool xmlExists = File.Exists("hotelladmin_database.xml");

			if (schemaExists) {
				local.ReadXmlSchema("hotelladmin_schema.xml");
			}

			if (xmlExists) {
				local.ReadXml("hotelladmin_database.xml");
			}

			ds.AcceptChanges();

			if(xmlExists && schemaExists) {
				ds.Merge(local, true, MissingSchemaAction.Ignore);
				MySqlCommandBuilder cbe = new MySqlCommandBuilder(daEmployees);
				daEmployees.Update(ds, "ansatte");
				MySqlCommandBuilder cbrt = new MySqlCommandBuilder(daRoomTypes);
				daRoomTypes.Update(ds, "romtyper");
				MySqlCommandBuilder cbr = new MySqlCommandBuilder(daRoom);
				daRoom.Update(ds, "rom");
				MySqlCommandBuilder cbo = new MySqlCommandBuilder(daOrders);
				daOrders.Update(ds, "bestillinger");
				MySqlCommandBuilder cbb = new MySqlCommandBuilder(daBooking);
				daBooking.Update(ds, "booking");
			}

			ds.AcceptChanges();
			OnUpdate();
		}

		//public static DataSet Query(string sql) { // ikke bruk denne

		//	if (!initialized) return null;

		//	if (conn == null || conn.State == ConnectionState.Closed) {
		//		Console.WriteLine("Query: Ingen database er tilkoblet");
		//		return null;
		//	}

		//	MySqlCommand cmd = new MySqlCommand(sql, conn);
		//	MySqlDataAdapter da = new MySqlDataAdapter(cmd);
		//	MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
		//	DataSet qds = new DataSet("result");
		//	da.Fill(qds, "result");

		//	Console.WriteLine(sql);

		//	return qds;
		//}

		// Legg inn en rad i en angitt tabell
		public static bool InsertRow(string tableName, DataRow rowData) {

			if (!initialized || (!usingLocalDatabase && !CheckConnection())) return false;

			if (tableName == "booking") {
				DataRow newRow = bookingTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				newRow[3] = rowData[3];
				newRow[4] = rowData[4];
				bookingTable.Rows.Add(newRow);

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daBooking);
					daBooking.Update(ds, "booking");
				}

			} else if (tableName == "ansatte") {
				DataRow newRow = employeesTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				newRow[3] = rowData[3];
				newRow[4] = rowData[4];
				employeesTable.Rows.Add(newRow);

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daEmployees);
					daEmployees.Update(ds, "ansatte");
				}

			} else if (tableName == "bestillinger") {
				DataRow newRow = ordersTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				newRow[3] = rowData[3];
				newRow[4] = rowData[4];
				newRow[5] = rowData[5];
				newRow[6] = rowData[6];
				newRow[7] = rowData[7];
				ordersTable.Rows.Add(newRow);

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrders);
					daOrders.Update(ds, "bestillinger");
				}

			} else if (tableName == "rom") {
				DataRow newRow = roomTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				roomTable.Rows.Add(newRow);

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoom);
					daRoom.Update(ds, "rom");
				}

			} else if (tableName == "romtyper") {
				DataRow newRow = roomTypesTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				roomTypesTable.Rows.Add(newRow);

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoomTypes);
					daRoomTypes.Update(ds, "romtyper");
				}

			}

			string outputString = "";
			for(int i = 0; i < rowData.ItemArray.Length; i++) {
				outputString += rowData[i].ToString() + ", ";
			}
			Console.WriteLine("INSERT: " + outputString + "INTO " + tableName);

			ds.AcceptChanges();
			OnUpdate();

			return true;
		}

		// Oppdater en rad med en spesifikk primærnøkkel i en angitt tabell 
		public static bool UpdateRow(string tableName, string primaryKey, DataRow rowData) {

			if (!initialized || (!usingLocalDatabase && !CheckConnection())) return false;

			DataRow selectedRow = null;

			if(tableName == "booking") {
				selectedRow = bookingTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daBooking);
					daBooking.Update(ds, "booking");
				}

			} else if (tableName == "ansatte") {
				selectedRow = employeesTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daEmployees);
					daEmployees.Update(ds, "ansatte");
				}

			} else if (tableName == "bestillinger") {
				selectedRow = ordersTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrders);
					daOrders.Update(ds, "bestillinger");
				}

			} else if (tableName == "rom") {
				selectedRow = roomTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoom);
					daRoom.Update(ds, "rom");
				}

			} else if (tableName == "romtyper") {
				selectedRow = roomTypesTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();

				if (!usingLocalDatabase) {
					MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoomTypes);
					daRoomTypes.Update(ds, "romtyper");
				}

			}

			string outputString = "";

			for (int i = 0; i < rowData.ItemArray.Length; i++) {
				outputString += rowData[i].ToString() + ", ";
			}

			Console.WriteLine("UPDATE: " + outputString + "INTO " + tableName);

			ds.AcceptChanges();
			OnUpdate();

			return true;
		}

		// Prøv å finn en rad med en spesifikk primærnøkkel i en angitt tabell
		public static DataRow FindRowInTable(string tableName, int primaryKey) {
			return ds.Tables[tableName].Rows.Find(primaryKey);
		}

		// Tell alle radene i en angitt tabell som oppfyller kravet
		public static int CountRowsWithCondition(string tableName, string condition) {
			return ds.Tables[tableName].Select(condition).Length;
		}

		// Hent ut alle rader fra en angitt tabell som oppfyller kravet
		public static DataRow[] SelectFromTable(string tableName, string condition) {
			return ds.Tables[tableName].Select(condition);
		}

		// Når det skjer en oppdatering i databasen...
		private static void OnUpdate() {

			if (!initialized || !autoSyncXML) return;

			ds.WriteXml("hotelladmin_database.xml");
			ds.WriteXmlSchema("hotelladmin_schema.xml");
		}

		// Når det skjer noe med databasetilkoblingen vår
		private static void OnStateChange(object sender, StateChangeEventArgs e) {

			if (e.CurrentState == ConnectionState.Open) {
				gui.UpdateDatabaseStatus(true);
			} else if (e.CurrentState == ConnectionState.Closed || e.CurrentState == ConnectionState.Broken) {
				gui.UpdateDatabaseStatus(false);
			}

		}

		// Sjekk om databasen fortsatt er tilkoblet
		private static bool CheckConnection() {

			if(conn == null || !initialized || conn.State == (ConnectionState.Closed | ConnectionState.Broken)) {
				connected = false;
				return false;
			}

			MySqlConnection connTest = conn;
			
			try {
				connTest.Close();
				connTest.Open();
			} catch (MySqlException e) {
				connected = false;
				Console.WriteLine("Tilkoblingen til databasen ble brutt.");
				gui.ShowDatabaseError();
				return false;
			}

			return true;
		}

		// Skriv datasettet vårt inn i en XML fil
		public static void SyncXML() {

			if (!initialized) return;

			ds.WriteXml("hotelladmin_database.xml");
			ds.WriteXmlSchema("hotelladmin_schema.xml");
		}

		// Getters & setters ------------------------------------

		// Hent ut en "eksempelrad" med riktig skjema fra en angitt tabell
		public static DataRow GetRowWithSchema(string tableName) {
			return ds.Tables[tableName].NewRow();
		}

		// Hent ut en hel tabell
		public static DataTable GetTable(string tableName) {
			return ds.Tables[tableName];
		}

		// Sjekk om DatabaseManager er initialisert
		public static bool IsInitialized() {
			return initialized;
		}

		public static void SetAutoSyncStatus(bool autoSync) {
			autoSyncXML = autoSync;
		}

		// Er databasen tilkoblet? (Online)
		public static bool IsConnected() {
			return connected;
		}

		// Bruker vi lokal database? (Offline)
		public static bool IsUsingLocalDatabase() {
			return usingLocalDatabase;
		}

	}

}
