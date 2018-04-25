namespace HotellAdmin {
	partial class DatabaseErrorWindow {
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
			this.dewRetry = new System.Windows.Forms.Button();
			this.dewUseLocal = new System.Windows.Forms.Button();
			this.dewCancel = new System.Windows.Forms.Button();
			this.DatabaseErrorWindowText = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// dewRetry
			// 
			this.dewRetry.Location = new System.Drawing.Point(15, 121);
			this.dewRetry.Name = "dewRetry";
			this.dewRetry.Size = new System.Drawing.Size(89, 23);
			this.dewRetry.TabIndex = 0;
			this.dewRetry.Text = "Prøv på nytt";
			this.dewRetry.UseVisualStyleBackColor = true;
			this.dewRetry.Click += new System.EventHandler(this.dewRetry_Click);
			// 
			// dewUseLocal
			// 
			this.dewUseLocal.Location = new System.Drawing.Point(123, 121);
			this.dewUseLocal.Name = "dewUseLocal";
			this.dewUseLocal.Size = new System.Drawing.Size(110, 23);
			this.dewUseLocal.TabIndex = 1;
			this.dewUseLocal.Text = "Bruk lokal database";
			this.dewUseLocal.UseVisualStyleBackColor = true;
			this.dewUseLocal.Click += new System.EventHandler(this.dewUseLocal_Click);
			// 
			// dewCancel
			// 
			this.dewCancel.Location = new System.Drawing.Point(252, 121);
			this.dewCancel.Name = "dewCancel";
			this.dewCancel.Size = new System.Drawing.Size(86, 23);
			this.dewCancel.TabIndex = 2;
			this.dewCancel.Text = "Avbryt";
			this.dewCancel.UseVisualStyleBackColor = true;
			this.dewCancel.Click += new System.EventHandler(this.dewCancel_Click);
			// 
			// DatabaseErrorWindowText
			// 
			this.DatabaseErrorWindowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DatabaseErrorWindowText.Location = new System.Drawing.Point(70, 24);
			this.DatabaseErrorWindowText.Name = "DatabaseErrorWindowText";
			this.DatabaseErrorWindowText.Size = new System.Drawing.Size(257, 60);
			this.DatabaseErrorWindowText.TabIndex = 3;
			this.DatabaseErrorWindowText.Text = "Kunne ikke koble til den eksterne databasen, vil du bruke lokale databasen eller " +
    "prøve på nytt?";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(15, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(45, 50);
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// DatabaseErrorWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 154);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.DatabaseErrorWindowText);
			this.Controls.Add(this.dewCancel);
			this.Controls.Add(this.dewUseLocal);
			this.Controls.Add(this.dewRetry);
			this.Name = "DatabaseErrorWindow";
			this.Text = "Database Error";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button dewRetry;
		private System.Windows.Forms.Button dewUseLocal;
		private System.Windows.Forms.Button dewCancel;
		private System.Windows.Forms.Label DatabaseErrorWindowText;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}