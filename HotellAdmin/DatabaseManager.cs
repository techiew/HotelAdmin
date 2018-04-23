using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace HotellAdmin {

	static class DatabaseManager {

		private static MySqlConnection conn = null;
		public static bool connected = false;
		public static bool autoSyncXML = true;
		public static bool isLocal = false;
		public static DataSet ds;
		public static DataTable employeesTable;
		public static DataTable ordersTable;
		public static DataTable bookingTable;
		public static DataTable roomTable;
		public static DataTable roomTypesTable;
		public static MySqlDataAdapter daEmployees;
		public static MySqlDataAdapter daOrders;
		public static MySqlDataAdapter daBooking;
		public static MySqlDataAdapter daRoom;
		public static MySqlDataAdapter daRoomTypes;

		public static void FillDataSet() {
			ds = new DataSet();
			ds.DataSetName = "HotellAdmin";

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

		public static void Open(string server, string port, string database, string username, string password) {

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
				conn.Open();
				FillDataSet();
				Console.WriteLine("Open: Koblet til database. MySQL versjon: {0}", conn.ServerVersion);
				connected = true;
			} catch (MySqlException ex) {
				connected = false;
				Console.WriteLine("Error: {0}", ex.ToString());
			} 

		}

		public static void Close() {

			if (conn.State == ConnectionState.Open) {
				conn.Close();
				Console.WriteLine("Close: Lukket databasetilkoblingen");
				connected = false;
			} else {
				Console.WriteLine("Close: Ingen database er tilkoblet");
			}

		}

		public static DataSet Query(string sql) {

			if (conn == null || conn.State == ConnectionState.Closed) {
				Console.WriteLine("Query: Ingen database er tilkoblet");
				return null;
			}

			MySqlCommand cmd = new MySqlCommand(sql, conn);
			MySqlDataAdapter da = new MySqlDataAdapter(cmd);
			MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
			DataSet qds = new DataSet("result");
			da.Fill(qds, "result");

			Console.WriteLine(sql);

			return qds;
		}

		public static void InsertRow(string tableName, DataRow rowData) {

			if(tableName == "booking") {
				DataRow newRow = bookingTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				newRow[3] = rowData[3];
				newRow[4] = rowData[4];
				bookingTable.Rows.Add(newRow);
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daBooking);
				daBooking.Update(ds, "booking");

			} else if (tableName == "ansatte") {
				DataRow newRow = employeesTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				newRow[3] = rowData[3];
				newRow[4] = rowData[4];
				employeesTable.Rows.Add(newRow);
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daEmployees);
				daEmployees.Update(ds, "ansatte");

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
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrders);
				daOrders.Update(ds, "bestillinger");

			} else if (tableName == "rom") {
				DataRow newRow = roomTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				roomTable.Rows.Add(newRow);
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoom);
				daRoom.Update(ds, "rom");

			} else if (tableName == "romtyper") {
				DataRow newRow = roomTypesTable.NewRow();
				newRow[0] = rowData[0];
				newRow[1] = rowData[1];
				newRow[2] = rowData[2];
				roomTypesTable.Rows.Add(newRow);
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoomTypes);
				daRoomTypes.Update(ds, "romtyper");
			}

			string outputString = "";
			for(int i = 0; i < rowData.ItemArray.Length; i++) {
				outputString += rowData[i].ToString() + ", ";
			}
			Console.WriteLine("INSERT: " + outputString + "INTO " + tableName);

			ds.AcceptChanges();
			OnUpdate();
		}

		public static void UpdateRow(string tableName, string primaryKey, DataRow rowData) {

			DataRow selectedRow = null;

			if(tableName == "booking") {
				selectedRow = bookingTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daBooking);
				daBooking.Update(ds, "booking");

			} else if (tableName == "ansatte") {
				selectedRow = employeesTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daEmployees);
				daEmployees.Update(ds, "ansatte");

			} else if (tableName == "bestillinger") {
				selectedRow = ordersTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daOrders);
				daOrders.Update(ds, "bestillinger");

			} else if (tableName == "rom") {
				selectedRow = roomTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoom);
				daRoom.Update(ds, "rom");

			} else if (tableName == "romtyper") {
				selectedRow = roomTypesTable.Rows.Find(primaryKey);
				selectedRow.BeginEdit();
				selectedRow = rowData;
				selectedRow.EndEdit();
				MySqlCommandBuilder cb = new MySqlCommandBuilder(daRoomTypes);
				daRoomTypes.Update(ds, "romtyper");
			}

			string outputString = "";
			for (int i = 0; i < rowData.ItemArray.Length; i++) {
				outputString += rowData[i].ToString() + ", ";
			}
			Console.WriteLine("UPDATE: " + outputString + "INTO " + tableName);

			ds.AcceptChanges();
			OnUpdate();
		}

		public static void OnUpdate() {

			if (!autoSyncXML) return;

			ds.WriteXml("hotelladmin_database.xml");
			ds.WriteXmlSchema("hotelladmin_schema.xml");
		}

		public static void SyncXML() {
			ds.WriteXml("hotelladmin_database.xml");
			ds.WriteXmlSchema("hotelladmin_schema.xml");
		}

	}

}
