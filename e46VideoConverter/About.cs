using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e46VideoConverter {
    public partial class About : UserControl {
        private static About _instance;
        internal static About Instance {
            get {
                if (_instance == null) _instance = new About();
                return _instance;
            }
        }

        public About() {
            InitializeComponent();
        }
    }
}
