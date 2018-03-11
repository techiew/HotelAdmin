namespace HotellAdmin {
	partial class FormHotellAdmin {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabBooking = new System.Windows.Forms.TabPage();
			this.tableLayoutBookingPanel = new System.Windows.Forms.TableLayoutPanel();
			this.panelButtonsAndRooms = new System.Windows.Forms.Panel();
			this.currentPeriod = new System.Windows.Forms.Label();
			this.tableLayoutRoomsPanel = new System.Windows.Forms.TableLayoutPanel();
			this.room1 = new System.Windows.Forms.Label();
			this.room2 = new System.Windows.Forms.Label();
			this.room3 = new System.Windows.Forms.Label();
			this.room4 = new System.Windows.Forms.Label();
			this.room5 = new System.Windows.Forms.Label();
			this.room6 = new System.Windows.Forms.Label();
			this.room7 = new System.Windows.Forms.Label();
			this.room8 = new System.Windows.Forms.Label();
			this.room9 = new System.Windows.Forms.Label();
			this.room10 = new System.Windows.Forms.Label();
			this.room11 = new System.Windows.Forms.Label();
			this.tableLayoutFloorButtons = new System.Windows.Forms.TableLayoutPanel();
			this.buttonFirstFloor = new System.Windows.Forms.Button();
			this.buttonSecondFloor = new System.Windows.Forms.Button();
			this.buttonThirdFloor = new System.Windows.Forms.Button();
			this.tableLayoutSidePanel = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.listBoxOrders = new System.Windows.Forms.ListBox();
			this.tabDropin = new System.Windows.Forms.TabPage();
			this.tableLayoutDropIn = new System.Windows.Forms.TableLayoutPanel();
			this.DropInPerson = new System.Windows.Forms.Panel();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.DropInPeriod = new System.Windows.Forms.Panel();
			this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.DropInCombo = new System.Windows.Forms.Panel();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.DropInHeader = new System.Windows.Forms.Panel();
			this.DropInHeaderLabel = new System.Windows.Forms.Label();
			this.DropInButtons = new System.Windows.Forms.Panel();
			this.DropInReset = new System.Windows.Forms.Button();
			this.DropInConfirm = new System.Windows.Forms.Button();
			this.tabOptions = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.tabControl1.SuspendLayout();
			this.tabBooking.SuspendLayout();
			this.tableLayoutBookingPanel.SuspendLayout();
			this.panelButtonsAndRooms.SuspendLayout();
			this.tableLayoutRoomsPanel.SuspendLayout();
			this.tableLayoutFloorButtons.SuspendLayout();
			this.tableLayoutSidePanel.SuspendLayout();
			this.tabDropin.SuspendLayout();
			this.tableLayoutDropIn.SuspendLayout();
			this.DropInPerson.SuspendLayout();
			this.DropInPeriod.SuspendLayout();
			this.DropInCombo.SuspendLayout();
			this.DropInHeader.SuspendLayout();
			this.DropInButtons.SuspendLayout();
			this.tabOptions.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabBooking);
			this.tabControl1.Controls.Add(this.tabDropin);
			this.tabControl1.Controls.Add(this.tabOptions);
			this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabControl1.Location = new System.Drawing.Point(9, 9);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(930, 587);
			this.tabControl1.TabIndex = 1;
			this.tabControl1.TabStop = false;
			// 
			// tabBooking
			// 
			this.tabBooking.Controls.Add(this.tableLayoutBookingPanel);
			this.tabBooking.Location = new System.Drawing.Point(4, 25);
			this.tabBooking.Margin = new System.Windows.Forms.Padding(0);
			this.tabBooking.Name = "tabBooking";
			this.tabBooking.Size = new System.Drawing.Size(922, 558);
			this.tabBooking.TabIndex = 0;
			this.tabBooking.Text = "Booking";
			this.tabBooking.UseVisualStyleBackColor = true;
			// 
			// tableLayoutBookingPanel
			// 
			this.tableLayoutBookingPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutBookingPanel.ColumnCount = 2;
			this.tableLayoutBookingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
			this.tableLayoutBookingPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
			this.tableLayoutBookingPanel.Controls.Add(this.panelButtonsAndRooms, 0, 0);
			this.tableLayoutBookingPanel.Controls.Add(this.tableLayoutSidePanel, 1, 0);
			this.tableLayoutBookingPanel.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutBookingPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutBookingPanel.Name = "tableLayoutBookingPanel";
			this.tableLayoutBookingPanel.RowCount = 1;
			this.tableLayoutBookingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutBookingPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 558F));
			this.tableLayoutBookingPanel.Size = new System.Drawing.Size(921, 558);
			this.tableLayoutBookingPanel.TabIndex = 3;
			// 
			// panelButtonsAndRooms
			// 
			this.panelButtonsAndRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelButtonsAndRooms.Controls.Add(this.currentPeriod);
			this.panelButtonsAndRooms.Controls.Add(this.tableLayoutRoomsPanel);
			this.panelButtonsAndRooms.Controls.Add(this.tableLayoutFloorButtons);
			this.panelButtonsAndRooms.Location = new System.Drawing.Point(3, 3);
			this.panelButtonsAndRooms.Name = "panelButtonsAndRooms";
			this.panelButtonsAndRooms.Size = new System.Drawing.Size(638, 552);
			this.panelButtonsAndRooms.TabIndex = 4;
			// 
			// currentPeriod
			// 
			this.currentPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.currentPeriod.BackColor = System.Drawing.Color.Gainsboro;
			this.currentPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.currentPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.currentPeriod.Location = new System.Drawing.Point(7, 44);
			this.currentPeriod.Name = "currentPeriod";
			this.currentPeriod.Size = new System.Drawing.Size(625, 35);
			this.currentPeriod.TabIndex = 3;
			this.currentPeriod.Text = "Viser oversikt for: i dag";
			this.currentPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.currentPeriod.Click += new System.EventHandler(this.currentPeriod_Click);
			// 
			// tableLayoutRoomsPanel
			// 
			this.tableLayoutRoomsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutRoomsPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
			this.tableLayoutRoomsPanel.ColumnCount = 5;
			this.tableLayoutRoomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53998F));
			this.tableLayoutRoomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53998F));
			this.tableLayoutRoomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.84009F));
			this.tableLayoutRoomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53998F));
			this.tableLayoutRoomsPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.53998F));
			this.tableLayoutRoomsPanel.Controls.Add(this.room1, 0, 3);
			this.tableLayoutRoomsPanel.Controls.Add(this.room2, 0, 2);
			this.tableLayoutRoomsPanel.Controls.Add(this.room3, 0, 1);
			this.tableLayoutRoomsPanel.Controls.Add(this.room4, 0, 0);
			this.tableLayoutRoomsPanel.Controls.Add(this.room5, 1, 0);
			this.tableLayoutRoomsPanel.Controls.Add(this.room6, 2, 0);
			this.tableLayoutRoomsPanel.Controls.Add(this.room7, 3, 0);
			this.tableLayoutRoomsPanel.Controls.Add(this.room8, 4, 0);
			this.tableLayoutRoomsPanel.Controls.Add(this.room9, 4, 1);
			this.tableLayoutRoomsPanel.Controls.Add(this.room10, 4, 2);
			this.tableLayoutRoomsPanel.Controls.Add(this.room11, 4, 3);
			this.tableLayoutRoomsPanel.Location = new System.Drawing.Point(6, 83);
			this.tableLayoutRoomsPanel.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutRoomsPanel.Name = "tableLayoutRoomsPanel";
			this.tableLayoutRoomsPanel.RowCount = 4;
			this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
			this.tableLayoutRoomsPanel.Size = new System.Drawing.Size(627, 465);
			this.tableLayoutRoomsPanel.TabIndex = 2;
			// 
			// room1
			// 
			this.room1.AllowDrop = true;
			this.room1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room1.AutoSize = true;
			this.room1.BackColor = System.Drawing.Color.LightGray;
			this.room1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room1.Location = new System.Drawing.Point(1, 349);
			this.room1.Margin = new System.Windows.Forms.Padding(0);
			this.room1.Name = "room1";
			this.room1.Size = new System.Drawing.Size(115, 115);
			this.room1.TabIndex = 0;
			this.room1.Text = "Rom 1";
			this.room1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room2
			// 
			this.room2.AllowDrop = true;
			this.room2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room2.AutoSize = true;
			this.room2.BackColor = System.Drawing.Color.LightGray;
			this.room2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room2.Location = new System.Drawing.Point(1, 233);
			this.room2.Margin = new System.Windows.Forms.Padding(0);
			this.room2.Name = "room2";
			this.room2.Size = new System.Drawing.Size(115, 115);
			this.room2.TabIndex = 1;
			this.room2.Text = "Rom 2";
			this.room2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room3
			// 
			this.room3.AllowDrop = true;
			this.room3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room3.AutoSize = true;
			this.room3.BackColor = System.Drawing.Color.LightGray;
			this.room3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room3.Location = new System.Drawing.Point(1, 117);
			this.room3.Margin = new System.Windows.Forms.Padding(0);
			this.room3.Name = "room3";
			this.room3.Size = new System.Drawing.Size(115, 115);
			this.room3.TabIndex = 2;
			this.room3.Text = "Rom 3";
			this.room3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room4
			// 
			this.room4.AllowDrop = true;
			this.room4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room4.AutoSize = true;
			this.room4.BackColor = System.Drawing.Color.LightGray;
			this.room4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room4.Location = new System.Drawing.Point(1, 1);
			this.room4.Margin = new System.Windows.Forms.Padding(0);
			this.room4.Name = "room4";
			this.room4.Size = new System.Drawing.Size(115, 115);
			this.room4.TabIndex = 3;
			this.room4.Text = "Rom 4";
			this.room4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room5
			// 
			this.room5.AllowDrop = true;
			this.room5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room5.AutoSize = true;
			this.room5.BackColor = System.Drawing.Color.LightGray;
			this.room5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room5.Location = new System.Drawing.Point(117, 1);
			this.room5.Margin = new System.Windows.Forms.Padding(0);
			this.room5.Name = "room5";
			this.room5.Size = new System.Drawing.Size(115, 115);
			this.room5.TabIndex = 4;
			this.room5.Text = "Rom 5";
			this.room5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room6
			// 
			this.room6.AllowDrop = true;
			this.room6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room6.AutoSize = true;
			this.room6.BackColor = System.Drawing.Color.LightGray;
			this.room6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room6.Location = new System.Drawing.Point(233, 1);
			this.room6.Margin = new System.Windows.Forms.Padding(0);
			this.room6.Name = "room6";
			this.room6.Size = new System.Drawing.Size(160, 115);
			this.room6.TabIndex = 5;
			this.room6.Text = "Rom 6";
			this.room6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room7
			// 
			this.room7.AllowDrop = true;
			this.room7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room7.AutoSize = true;
			this.room7.BackColor = System.Drawing.Color.LightGray;
			this.room7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room7.Location = new System.Drawing.Point(394, 1);
			this.room7.Margin = new System.Windows.Forms.Padding(0);
			this.room7.Name = "room7";
			this.room7.Size = new System.Drawing.Size(115, 115);
			this.room7.TabIndex = 6;
			this.room7.Text = "Rom 7";
			this.room7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room8
			// 
			this.room8.AllowDrop = true;
			this.room8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room8.AutoSize = true;
			this.room8.BackColor = System.Drawing.Color.LightGray;
			this.room8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room8.Location = new System.Drawing.Point(510, 1);
			this.room8.Margin = new System.Windows.Forms.Padding(0);
			this.room8.Name = "room8";
			this.room8.Size = new System.Drawing.Size(116, 115);
			this.room8.TabIndex = 7;
			this.room8.Text = "Rom 8";
			this.room8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room9
			// 
			this.room9.AllowDrop = true;
			this.room9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room9.AutoSize = true;
			this.room9.BackColor = System.Drawing.Color.LightGray;
			this.room9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room9.Location = new System.Drawing.Point(510, 117);
			this.room9.Margin = new System.Windows.Forms.Padding(0);
			this.room9.Name = "room9";
			this.room9.Size = new System.Drawing.Size(116, 115);
			this.room9.TabIndex = 8;
			this.room9.Text = "Rom 9";
			this.room9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room10
			// 
			this.room10.AllowDrop = true;
			this.room10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room10.AutoSize = true;
			this.room10.BackColor = System.Drawing.Color.LightGray;
			this.room10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room10.Location = new System.Drawing.Point(510, 233);
			this.room10.Margin = new System.Windows.Forms.Padding(0);
			this.room10.Name = "room10";
			this.room10.Size = new System.Drawing.Size(116, 115);
			this.room10.TabIndex = 9;
			this.room10.Text = "Rom 10";
			this.room10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// room11
			// 
			this.room11.AllowDrop = true;
			this.room11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.room11.AutoSize = true;
			this.room11.BackColor = System.Drawing.Color.LightGray;
			this.room11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.room11.Location = new System.Drawing.Point(510, 349);
			this.room11.Margin = new System.Windows.Forms.Padding(0);
			this.room11.Name = "room11";
			this.room11.Size = new System.Drawing.Size(116, 115);
			this.room11.TabIndex = 10;
			this.room11.Text = "Rom 11";
			this.room11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutFloorButtons
			// 
			this.tableLayoutFloorButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutFloorButtons.ColumnCount = 3;
			this.tableLayoutFloorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutFloorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutFloorButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
			this.tableLayoutFloorButtons.Controls.Add(this.buttonFirstFloor, 0, 0);
			this.tableLayoutFloorButtons.Controls.Add(this.buttonSecondFloor, 1, 0);
			this.tableLayoutFloorButtons.Controls.Add(this.buttonThirdFloor, 2, 0);
			this.tableLayoutFloorButtons.Location = new System.Drawing.Point(4, 3);
			this.tableLayoutFloorButtons.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this.tableLayoutFloorButtons.Name = "tableLayoutFloorButtons";
			this.tableLayoutFloorButtons.RowCount = 1;
			this.tableLayoutFloorButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutFloorButtons.Size = new System.Drawing.Size(631, 38);
			this.tableLayoutFloorButtons.TabIndex = 1;
			// 
			// buttonFirstFloor
			// 
			this.buttonFirstFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonFirstFloor.BackColor = System.Drawing.Color.CornflowerBlue;
			this.buttonFirstFloor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonFirstFloor.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonFirstFloor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonFirstFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonFirstFloor.ForeColor = System.Drawing.Color.White;
			this.buttonFirstFloor.Location = new System.Drawing.Point(2, 2);
			this.buttonFirstFloor.Margin = new System.Windows.Forms.Padding(2);
			this.buttonFirstFloor.Name = "buttonFirstFloor";
			this.buttonFirstFloor.Size = new System.Drawing.Size(206, 34);
			this.buttonFirstFloor.TabIndex = 0;
			this.buttonFirstFloor.Text = "1. Etg";
			this.buttonFirstFloor.UseVisualStyleBackColor = false;
			// 
			// buttonSecondFloor
			// 
			this.buttonSecondFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonSecondFloor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonSecondFloor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonSecondFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonSecondFloor.Location = new System.Drawing.Point(212, 2);
			this.buttonSecondFloor.Margin = new System.Windows.Forms.Padding(2);
			this.buttonSecondFloor.Name = "buttonSecondFloor";
			this.buttonSecondFloor.Size = new System.Drawing.Size(206, 34);
			this.buttonSecondFloor.TabIndex = 1;
			this.buttonSecondFloor.Text = "2. Etg";
			this.buttonSecondFloor.UseVisualStyleBackColor = true;
			// 
			// buttonThirdFloor
			// 
			this.buttonThirdFloor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonThirdFloor.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonThirdFloor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonThirdFloor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonThirdFloor.Location = new System.Drawing.Point(422, 2);
			this.buttonThirdFloor.Margin = new System.Windows.Forms.Padding(2);
			this.buttonThirdFloor.Name = "buttonThirdFloor";
			this.buttonThirdFloor.Size = new System.Drawing.Size(207, 34);
			this.buttonThirdFloor.TabIndex = 2;
			this.buttonThirdFloor.Text = "3. Etg";
			this.buttonThirdFloor.UseVisualStyleBackColor = true;
			// 
			// tableLayoutSidePanel
			// 
			this.tableLayoutSidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutSidePanel.ColumnCount = 1;
			this.tableLayoutSidePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutSidePanel.Controls.Add(this.label1, 0, 0);
			this.tableLayoutSidePanel.Controls.Add(this.listBoxOrders, 0, 1);
			this.tableLayoutSidePanel.Location = new System.Drawing.Point(644, 0);
			this.tableLayoutSidePanel.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutSidePanel.Name = "tableLayoutSidePanel";
			this.tableLayoutSidePanel.RowCount = 2;
			this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
			this.tableLayoutSidePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
			this.tableLayoutSidePanel.Size = new System.Drawing.Size(277, 558);
			this.tableLayoutSidePanel.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Margin = new System.Windows.Forms.Padding(0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(277, 55);
			this.label1.TabIndex = 1;
			this.label1.Text = "Bestillinger";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// listBoxOrders
			// 
			this.listBoxOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.listBoxOrders.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listBoxOrders.Cursor = System.Windows.Forms.Cursors.Default;
			this.listBoxOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBoxOrders.FormattingEnabled = true;
			this.listBoxOrders.HorizontalScrollbar = true;
			this.listBoxOrders.ItemHeight = 20;
			this.listBoxOrders.Location = new System.Drawing.Point(0, 55);
			this.listBoxOrders.Margin = new System.Windows.Forms.Padding(0);
			this.listBoxOrders.Name = "listBoxOrders";
			this.listBoxOrders.Size = new System.Drawing.Size(277, 502);
			this.listBoxOrders.TabIndex = 2;
			this.listBoxOrders.TabStop = false;
			this.listBoxOrders.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBoxOrders_MouseDown);
			// 
			// tabDropin
			// 
			this.tabDropin.Controls.Add(this.tableLayoutDropIn);
			this.tabDropin.Location = new System.Drawing.Point(4, 25);
			this.tabDropin.Name = "tabDropin";
			this.tabDropin.Padding = new System.Windows.Forms.Padding(3);
			this.tabDropin.Size = new System.Drawing.Size(922, 558);
			this.tabDropin.TabIndex = 1;
			this.tabDropin.Text = "Drop-in";
			this.tabDropin.UseVisualStyleBackColor = true;
			// 
			// tableLayoutDropIn
			// 
			this.tableLayoutDropIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutDropIn.ColumnCount = 3;
			this.tableLayoutDropIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.588997F));
			this.tableLayoutDropIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.73139F));
			this.tableLayoutDropIn.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.58316F));
			this.tableLayoutDropIn.Controls.Add(this.DropInPerson, 1, 3);
			this.tableLayoutDropIn.Controls.Add(this.DropInPeriod, 1, 2);
			this.tableLayoutDropIn.Controls.Add(this.DropInCombo, 1, 1);
			this.tableLayoutDropIn.Controls.Add(this.DropInHeader, 1, 0);
			this.tableLayoutDropIn.Controls.Add(this.DropInButtons, 1, 4);
			this.tableLayoutDropIn.Location = new System.Drawing.Point(-4, 0);
			this.tableLayoutDropIn.Name = "tableLayoutDropIn";
			this.tableLayoutDropIn.RowCount = 6;
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.678F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.09123F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.52236F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.36136F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.44902F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.56637F));
			this.tableLayoutDropIn.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutDropIn.Size = new System.Drawing.Size(927, 559);
			this.tableLayoutDropIn.TabIndex = 0;
			// 
			// DropInPerson
			// 
			this.DropInPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DropInPerson.Controls.Add(this.textBox3);
			this.DropInPerson.Controls.Add(this.textBox2);
			this.DropInPerson.Controls.Add(this.textBox1);
			this.DropInPerson.Location = new System.Drawing.Point(27, 245);
			this.DropInPerson.Name = "DropInPerson";
			this.DropInPerson.Size = new System.Drawing.Size(798, 119);
			this.DropInPerson.TabIndex = 4;
			// 
			// textBox3
			// 
			this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox3.Location = new System.Drawing.Point(282, 62);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(186, 29);
			this.textBox3.TabIndex = 1;
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox2.Location = new System.Drawing.Point(21, 62);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(179, 29);
			this.textBox2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBox1.Location = new System.Drawing.Point(21, 3);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 29);
			this.textBox1.TabIndex = 2;
			// 
			// DropInPeriod
			// 
			this.DropInPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DropInPeriod.Controls.Add(this.dateTimePicker2);
			this.DropInPeriod.Controls.Add(this.dateTimePicker1);
			this.DropInPeriod.Location = new System.Drawing.Point(27, 175);
			this.DropInPeriod.Name = "DropInPeriod";
			this.DropInPeriod.Size = new System.Drawing.Size(798, 64);
			this.DropInPeriod.TabIndex = 1;
			// 
			// dateTimePicker2
			// 
			this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker2.Location = new System.Drawing.Point(282, 5);
			this.dateTimePicker2.Name = "dateTimePicker2";
			this.dateTimePicker2.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker2.TabIndex = 1;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dateTimePicker1.Location = new System.Drawing.Point(21, 5);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 29);
			this.dateTimePicker1.TabIndex = 0;
			// 
			// DropInCombo
			// 
			this.DropInCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DropInCombo.Controls.Add(this.comboBox1);
			this.DropInCombo.Location = new System.Drawing.Point(27, 113);
			this.DropInCombo.Name = "DropInCombo";
			this.DropInCombo.Size = new System.Drawing.Size(798, 56);
			this.DropInCombo.TabIndex = 5;
			// 
			// comboBox1
			// 
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(21, 3);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(237, 32);
			this.comboBox1.TabIndex = 1;
			// 
			// DropInHeader
			// 
			this.DropInHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DropInHeader.Controls.Add(this.DropInHeaderLabel);
			this.DropInHeader.Location = new System.Drawing.Point(27, 3);
			this.DropInHeader.Name = "DropInHeader";
			this.DropInHeader.Size = new System.Drawing.Size(798, 104);
			this.DropInHeader.TabIndex = 6;
			// 
			// DropInHeaderLabel
			// 
			this.DropInHeaderLabel.AutoSize = true;
			this.DropInHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DropInHeaderLabel.Location = new System.Drawing.Point(14, 29);
			this.DropInHeaderLabel.Name = "DropInHeaderLabel";
			this.DropInHeaderLabel.Size = new System.Drawing.Size(157, 39);
			this.DropInHeaderLabel.TabIndex = 0;
			this.DropInHeaderLabel.Text = "Bestilling";
			// 
			// DropInButtons
			// 
			this.DropInButtons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.DropInButtons.Controls.Add(this.DropInReset);
			this.DropInButtons.Controls.Add(this.DropInConfirm);
			this.DropInButtons.Location = new System.Drawing.Point(27, 370);
			this.DropInButtons.Name = "DropInButtons";
			this.DropInButtons.Size = new System.Drawing.Size(798, 58);
			this.DropInButtons.TabIndex = 7;
			// 
			// DropInReset
			// 
			this.DropInReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DropInReset.Location = new System.Drawing.Point(178, 13);
			this.DropInReset.Name = "DropInReset";
			this.DropInReset.Size = new System.Drawing.Size(137, 36);
			this.DropInReset.TabIndex = 1;
			this.DropInReset.Text = "Nullstill";
			this.DropInReset.UseVisualStyleBackColor = true;
			// 
			// DropInConfirm
			// 
			this.DropInConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DropInConfirm.Location = new System.Drawing.Point(21, 13);
			this.DropInConfirm.Name = "DropInConfirm";
			this.DropInConfirm.Size = new System.Drawing.Size(134, 36);
			this.DropInConfirm.TabIndex = 0;
			this.DropInConfirm.Text = "Bekreft";
			this.DropInConfirm.UseVisualStyleBackColor = true;
			// 
			// tabOptions
			// 
			this.tabOptions.Controls.Add(this.tableLayoutPanel1);
			this.tabOptions.Location = new System.Drawing.Point(4, 25);
			this.tabOptions.Name = "tabOptions";
			this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
			this.tabOptions.Size = new System.Drawing.Size(922, 558);
			this.tabOptions.TabIndex = 2;
			this.tabOptions.Text = "Innstillinger";
			this.tabOptions.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.listView1, 0, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(765, 521);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listView1
			// 
			this.listView1.Location = new System.Drawing.Point(30, 30);
			this.listView1.Margin = new System.Windows.Forms.Padding(30);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(205, 200);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// FormHotellAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 605);
			this.Controls.Add(this.tabControl1);
			this.Name = "FormHotellAdmin";
			this.Text = "HotellAdmin";
			this.Load += new System.EventHandler(this.FormHotellAdmin_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabBooking.ResumeLayout(false);
			this.tableLayoutBookingPanel.ResumeLayout(false);
			this.panelButtonsAndRooms.ResumeLayout(false);
			this.tableLayoutRoomsPanel.ResumeLayout(false);
			this.tableLayoutRoomsPanel.PerformLayout();
			this.tableLayoutFloorButtons.ResumeLayout(false);
			this.tableLayoutSidePanel.ResumeLayout(false);
			this.tabDropin.ResumeLayout(false);
			this.tableLayoutDropIn.ResumeLayout(false);
			this.DropInPerson.ResumeLayout(false);
			this.DropInPerson.PerformLayout();
			this.DropInPeriod.ResumeLayout(false);
			this.DropInCombo.ResumeLayout(false);
			this.DropInHeader.ResumeLayout(false);
			this.DropInHeader.PerformLayout();
			this.DropInButtons.ResumeLayout(false);
			this.tabOptions.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabBooking;
		private System.Windows.Forms.TableLayoutPanel tableLayoutBookingPanel;
		private System.Windows.Forms.Panel panelButtonsAndRooms;
		private System.Windows.Forms.TableLayoutPanel tableLayoutRoomsPanel;
		private System.Windows.Forms.Label room1;
		private System.Windows.Forms.Label room2;
		private System.Windows.Forms.Label room3;
		private System.Windows.Forms.Label room4;
		private System.Windows.Forms.Label room5;
		private System.Windows.Forms.Label room6;
		private System.Windows.Forms.Label room7;
		private System.Windows.Forms.Label room8;
		private System.Windows.Forms.Label room9;
		private System.Windows.Forms.Label room10;
		private System.Windows.Forms.Label room11;
		private System.Windows.Forms.TableLayoutPanel tableLayoutFloorButtons;
		private System.Windows.Forms.Button buttonFirstFloor;
		private System.Windows.Forms.Button buttonSecondFloor;
		private System.Windows.Forms.Button buttonThirdFloor;
		private System.Windows.Forms.TableLayoutPanel tableLayoutSidePanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBoxOrders;
		private System.Windows.Forms.TabPage tabDropin;
		private System.Windows.Forms.TabPage tabOptions;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label currentPeriod;
		private System.Windows.Forms.TableLayoutPanel tableLayoutDropIn;
		private System.Windows.Forms.Panel DropInPerson;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel DropInPeriod;
		private System.Windows.Forms.DateTimePicker dateTimePicker2;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Panel DropInCombo;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Panel DropInHeader;
		private System.Windows.Forms.Label DropInHeaderLabel;
		private System.Windows.Forms.Panel DropInButtons;
		private System.Windows.Forms.Button DropInReset;
		private System.Windows.Forms.Button DropInConfirm;
	}
}

