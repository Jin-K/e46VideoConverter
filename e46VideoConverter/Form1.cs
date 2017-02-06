using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace e46VideoConverter {
    public partial class Home : Form {

        public Home() {
            InitializeComponent();
        }

        private void convertingButton_Load(object sender, EventArgs e) {
            (sender as BunifuFlatButton).selected = true;
            convertingButton_Click(sender, e);
        }

        private void dashboardButton_Click(object sender, EventArgs e) {
            if (!container.Controls.Contains(Dashboard.Instance)) {
                container.Controls.Add(Dashboard.Instance);
                Dashboard.Instance.Dock = DockStyle.Fill;
            }

            Dashboard.Instance.BringToFront();
        }

        private void convertingButton_Click(object sender, EventArgs e) {
            if (!container.Controls.Contains(Converting.Instance)) {
                container.Controls.Add(Converting.Instance);
                Converting.Instance.Dock = DockStyle.Fill;
            }

            Converting.Instance.BringToFront();
        }

        private void aboutButton_Click(object sender, EventArgs e) {
            if (!container.Controls.Contains(About.Instance)) {
                container.Controls.Add(About.Instance);
                About.Instance.Dock = DockStyle.Fill;
            }

            About.Instance.BringToFront();
        }
    }
}
