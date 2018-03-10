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
            this.tableLayoutBookingPanel.Size = new System.Drawing.Size(921, 558);
            this.tableLayoutBookingPanel.TabIndex = 3;
            // 
            // panelButtonsAndRooms
            // 
            this.panelButtonsAndRooms.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelButtonsAndRooms.Controls.Add(this.tableLayoutRoomsPanel);
            this.panelButtonsAndRooms.Controls.Add(this.tableLayoutFloorButtons);
            this.panelButtonsAndRooms.Location = new System.Drawing.Point(3, 3);
            this.panelButtonsAndRooms.Name = "panelButtonsAndRooms";
            this.panelButtonsAndRooms.Size = new System.Drawing.Size(638, 552);
            this.panelButtonsAndRooms.TabIndex = 4;
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
            this.tableLayoutRoomsPanel.Location = new System.Drawing.Point(6, 47);
            this.tableLayoutRoomsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutRoomsPanel.Name = "tableLayoutRoomsPanel";
            this.tableLayoutRoomsPanel.RowCount = 4;
            this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutRoomsPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutRoomsPanel.Size = new System.Drawing.Size(627, 501);
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
            this.room1.Location = new System.Drawing.Point(1, 376);
            this.room1.Margin = new System.Windows.Forms.Padding(0);
            this.room1.Name = "room1";
            this.room1.Size = new System.Drawing.Size(115, 124);
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
            this.room2.Location = new System.Drawing.Point(1, 251);
            this.room2.Margin = new System.Windows.Forms.Padding(0);
            this.room2.Name = "room2";
            this.room2.Size = new System.Drawing.Size(115, 124);
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
            this.room3.Location = new System.Drawing.Point(1, 126);
            this.room3.Margin = new System.Windows.Forms.Padding(0);
            this.room3.Name = "room3";
            this.room3.Size = new System.Drawing.Size(115, 124);
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
            this.room4.Size = new System.Drawing.Size(115, 124);
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
            this.room5.Size = new System.Drawing.Size(115, 124);
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
            this.room6.Size = new System.Drawing.Size(160, 124);
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
            this.room7.Size = new System.Drawing.Size(115, 124);
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
            this.room8.Size = new System.Drawing.Size(116, 124);
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
            this.room9.Location = new System.Drawing.Point(510, 126);
            this.room9.Margin = new System.Windows.Forms.Padding(0);
            this.room9.Name = "room9";
            this.room9.Size = new System.Drawing.Size(116, 124);
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
            this.room10.Location = new System.Drawing.Point(510, 251);
            this.room10.Margin = new System.Windows.Forms.Padding(0);
            this.room10.Name = "room10";
            this.room10.Size = new System.Drawing.Size(116, 124);
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
            this.room11.Location = new System.Drawing.Point(510, 376);
            this.room11.Margin = new System.Windows.Forms.Padding(0);
            this.room11.Name = "room11";
            this.room11.Size = new System.Drawing.Size(116, 124);
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
            this.tabDropin.Location = new System.Drawing.Point(4, 25);
            this.tabDropin.Name = "tabDropin";
            this.tabDropin.Padding = new System.Windows.Forms.Padding(3);
            this.tabDropin.Size = new System.Drawing.Size(922, 558);
            this.tabDropin.TabIndex = 1;
            this.tabDropin.Text = "Drop-in";
            this.tabDropin.UseVisualStyleBackColor = true;
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
	}
}

