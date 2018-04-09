namespace HotellAdmin {
	partial class LoginWindow {
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
            this.usernameCheckBox = new System.Windows.Forms.CheckBox();
            this.loginUsername = new System.Windows.Forms.TextBox();
            this.loginPassword = new System.Windows.Forms.TextBox();
            this.loginLabelUsername = new System.Windows.Forms.Label();
            this.loginLabelPassword = new System.Windows.Forms.Label();
            this.loginSubmit = new System.Windows.Forms.Button();
            this.loginLabelErrorMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameCheckBox
            // 
            this.usernameCheckBox.AutoSize = true;
            this.usernameCheckBox.Location = new System.Drawing.Point(12, 130);
            this.usernameCheckBox.Name = "usernameCheckBox";
            this.usernameCheckBox.Size = new System.Drawing.Size(114, 17);
            this.usernameCheckBox.TabIndex = 3;
            this.usernameCheckBox.Text = "Husk brukernavn?";
            this.usernameCheckBox.UseVisualStyleBackColor = true;
            this.usernameCheckBox.CheckedChanged += new System.EventHandler(this.usernameCheckBox_CheckedChanged);
            // 
            // loginUsername
            // 
            this.loginUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsername.Location = new System.Drawing.Point(12, 40);
            this.loginUsername.Name = "loginUsername";
            this.loginUsername.Size = new System.Drawing.Size(220, 26);
            this.loginUsername.TabIndex = 1;
            this.loginUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginUsername_KeyDown);
            // 
            // loginPassword
            // 
            this.loginPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPassword.Location = new System.Drawing.Point(12, 98);
            this.loginPassword.Name = "loginPassword";
            this.loginPassword.PasswordChar = '*';
            this.loginPassword.Size = new System.Drawing.Size(220, 26);
            this.loginPassword.TabIndex = 2;
            this.loginPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.loginPassword_KeyDown);
            // 
            // loginLabelUsername
            // 
            this.loginLabelUsername.AutoSize = true;
            this.loginLabelUsername.Location = new System.Drawing.Point(9, 24);
            this.loginLabelUsername.Name = "loginLabelUsername";
            this.loginLabelUsername.Size = new System.Drawing.Size(62, 13);
            this.loginLabelUsername.TabIndex = 4;
            this.loginLabelUsername.Text = "Brukernavn";
            // 
            // loginLabelPassword
            // 
            this.loginLabelPassword.AutoSize = true;
            this.loginLabelPassword.Location = new System.Drawing.Point(9, 82);
            this.loginLabelPassword.Name = "loginLabelPassword";
            this.loginLabelPassword.Size = new System.Drawing.Size(53, 13);
            this.loginLabelPassword.TabIndex = 5;
            this.loginLabelPassword.Text = "Password";
            // 
            // loginSubmit
            // 
            this.loginSubmit.Location = new System.Drawing.Point(12, 167);
            this.loginSubmit.Name = "loginSubmit";
            this.loginSubmit.Size = new System.Drawing.Size(98, 29);
            this.loginSubmit.TabIndex = 4;
            this.loginSubmit.Text = "Logg inn";
            this.loginSubmit.UseVisualStyleBackColor = true;
            this.loginSubmit.Click += new System.EventHandler(this.loginSubmit_Click);
            // 
            // loginLabelErrorMsg
            // 
            this.loginLabelErrorMsg.AutoSize = true;
            this.loginLabelErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabelErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.loginLabelErrorMsg.Location = new System.Drawing.Point(116, 167);
            this.loginLabelErrorMsg.MaximumSize = new System.Drawing.Size(200, 40);
            this.loginLabelErrorMsg.Name = "loginLabelErrorMsg";
            this.loginLabelErrorMsg.Size = new System.Drawing.Size(165, 20);
            this.loginLabelErrorMsg.TabIndex = 7;
            this.loginLabelErrorMsg.Text = "Vennligst prøv på nytt.";
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 214);
            this.Controls.Add(this.loginLabelErrorMsg);
            this.Controls.Add(this.loginSubmit);
            this.Controls.Add(this.loginLabelPassword);
            this.Controls.Add(this.loginLabelUsername);
            this.Controls.Add(this.loginPassword);
            this.Controls.Add(this.loginUsername);
            this.Controls.Add(this.usernameCheckBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::HotellAdmin.Properties.Settings.Default, "PopupLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::HotellAdmin.Properties.Settings.Default, "RememberedUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = global::HotellAdmin.Properties.Settings.Default.PopupLocation;
            this.Name = "LoginWindow";
            this.Text = global::HotellAdmin.Properties.Settings.Default.RememberedUsername;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginWindow_FormClosing);
            this.Load += new System.EventHandler(this.LoginWindow_Load_1);
            this.SizeChanged += new System.EventHandler(this.LoginWindow_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox usernameCheckBox;
		private System.Windows.Forms.TextBox loginUsername;
		private System.Windows.Forms.TextBox loginPassword;
		private System.Windows.Forms.Label loginLabelUsername;
		private System.Windows.Forms.Label loginLabelPassword;
		private System.Windows.Forms.Button loginSubmit;
		private System.Windows.Forms.Label loginLabelErrorMsg;
	}
}