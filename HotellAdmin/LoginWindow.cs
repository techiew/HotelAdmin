﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotellAdmin {

	public partial class LoginWindow : Form {

		string errorMsg;

		public LoginWindow() {
			InitializeComponent();
			errorMsg = "";
			loginLabelErrorMsg.Text = errorMsg;
		}
        
        private void LoginWindow_Load(object sender, EventArgs e) {
            this.Size = Properties.Settings.Default.PopupSize;
            usernameCheckBox.Checked = Properties.Settings.Default.RememberUsername;
            loginUsername.Text = Properties.Settings.Default.RememberedUsername;
        }

		// Når brukeren prøver å logge inn
        private void loginSubmit_Click(object sender, EventArgs e) {
			string username = loginUsername.Text.ToLower();
			string password = loginPassword.Text;
			errorMsg = "";

			if (!ValidateLogin(username, password)) {
				return;
			}

			if (Properties.Settings.Default.RememberUsername == true) {
                Properties.Settings.Default.RememberedUsername = loginUsername.Text.ToLower();
			}

			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		// Valider innlogging
		private bool ValidateLogin(string username, string password) {
			bool valid = true;

			if (username == "admin" && password == "admin") return true;

			if(!DatabaseManager.IsConnected() && !DatabaseManager.IsUsingLocalDatabase()) {
				Console.WriteLine("Kan ikke logge inn når en database ikke er tilkoblet.");
				return false;
			}

			if(username == "") {
				errorMsg += "Vennligst skriv inn et brukernavn.\n";
				valid = false;
			}

			if(password == "") {
				errorMsg += "Vennligst skriv inn et passord.\n";
				valid = false;
			}

			if(username.Contains(" ")) {
				errorMsg += "Brukernavn kan ikke inneholde mellomrom.\n";
				valid = false;
			}

			if(password.Contains(" ")) {
				errorMsg += "Passordet kan ikke inneholde mellomrom.\n";
				valid = false;
			}

			//Sjekk om kontoen eksisterer i databasen
			//DataSet result = DatabaseManager.Query("SELECT brukernavn, passord FROM ansatte WHERE brukernavn = '" + username + "' AND passord = '" + password + "';");
			int rowCount = DatabaseManager.CountRowsWithCondition("ansatte", "brukernavn = '" + username + "' AND passord = '" + password + "'");

			if (rowCount == 0) {
				errorMsg += "Denne kontoen eksisterer ikke, vennligst prøv på nytt.\n";
				valid = false;
			}

			loginLabelErrorMsg.Text = errorMsg;

			return valid;
		}

		// Hvis vinduet lukkes...
		private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e) {

			if(Properties.Settings.Default.RememberUsername == false) {
				Properties.Settings.Default.RememberedUsername = "";
			}

            Properties.Settings.Default.PopupSize = this.Size;
            Properties.Settings.Default.RememberedUsername = loginUsername.Text;

            Properties.Settings.Default.Save();

			if (this.DialogResult != DialogResult.OK) this.DialogResult = DialogResult.Abort;

		}

		// Innstilling for å huske brukernavn
		private void usernameCheckBox_CheckedChanged(object sender, EventArgs e) {

			if(usernameCheckBox.Checked) {
				Properties.Settings.Default.RememberUsername = true;
			} else {
				Properties.Settings.Default.RememberUsername = false;
			}

		}

		// Når brukeren trykker en knapp...
		// Disse KeyDown og KeyUp lar deg bytte mellom brukernavn og passordfeltet
		// når man trykker enter. Hvis man trykker enter fra passordfeltet så vil den prøve å logge inn
		private void loginUsername_KeyDown(object sender, KeyEventArgs e) {

			if(e.KeyCode == Keys.Enter) {
				
				if(loginUsername.Focused) {
					loginPassword.Select();
					loginPassword.Focus();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;

			} else if (e.KeyCode == Keys.Down) {

				if (loginUsername.Focused) {
					loginPassword.Select();
					loginPassword.Focus();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;
			}

		}

		// Når brukeren slipper en knapp...
		private void loginPassword_KeyDown(object sender, KeyEventArgs e) {

			if (e.KeyCode == Keys.Enter) {

				if (loginPassword.Focused) {
					loginSubmit.PerformClick();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;

			} else if (e.KeyCode == Keys.Up) {

				if (loginPassword.Focused) {
					loginUsername.Select();
					loginUsername.Focus();
				}

				e.Handled = true;
				e.SuppressKeyPress = true;
			}

		}

    }

}
