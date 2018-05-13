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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseErrorWindow));
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
			this.dewRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dewRetry.Location = new System.Drawing.Point(15, 113);
			this.dewRetry.Name = "dewRetry";
			this.dewRetry.Size = new System.Drawing.Size(90, 31);
			this.dewRetry.TabIndex = 0;
			this.dewRetry.Text = "Prøv på nytt";
			this.dewRetry.UseVisualStyleBackColor = true;
			this.dewRetry.Click += new System.EventHandler(this.dewRetry_Click);
			// 
			// dewUseLocal
			// 
			this.dewUseLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dewUseLocal.Location = new System.Drawing.Point(123, 113);
			this.dewUseLocal.Name = "dewUseLocal";
			this.dewUseLocal.Size = new System.Drawing.Size(110, 31);
			this.dewUseLocal.TabIndex = 1;
			this.dewUseLocal.Text = "Bruk lokal database";
			this.dewUseLocal.UseVisualStyleBackColor = true;
			this.dewUseLocal.Click += new System.EventHandler(this.dewUseLocal_Click);
			// 
			// dewCancel
			// 
			this.dewCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dewCancel.Location = new System.Drawing.Point(252, 113);
			this.dewCancel.Name = "dewCancel";
			this.dewCancel.Size = new System.Drawing.Size(86, 31);
			this.dewCancel.TabIndex = 2;
			this.dewCancel.Text = "Avbryt";
			this.dewCancel.UseVisualStyleBackColor = true;
			this.dewCancel.Click += new System.EventHandler(this.dewCancel_Click);
			// 
			// DatabaseErrorWindowText
			// 
			this.DatabaseErrorWindowText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DatabaseErrorWindowText.Location = new System.Drawing.Point(70, 24);
			this.DatabaseErrorWindowText.Name = "DatabaseErrorWindowText";
			this.DatabaseErrorWindowText.Size = new System.Drawing.Size(258, 73);
			this.DatabaseErrorWindowText.TabIndex = 3;
			this.DatabaseErrorWindowText.Text = "Kunne ikke koble til den eksterne databasen, vil du bruke den lokale databasen el" +
    "ler prøve på nytt?";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::HotellAdmin.Properties.Resources.error_icon;
			this.pictureBox1.Location = new System.Drawing.Point(16, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 46);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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