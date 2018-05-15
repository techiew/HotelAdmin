using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotellAdmin {
	public partial class DatabaseErrorWindow : Form {

		public DatabaseErrorWindow() {
			InitializeComponent();
		}

		private void dewRetry_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Retry;
		}

		private void dewCancel_Click(object sender, EventArgs e) {
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void DatabaseErrorWindow_Load(object sender, EventArgs e) {

		}

	}

}
