using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace JinKomponents.Librairie {
    [DebuggerStepThrough]
    public static class Ellipse {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr FunctionLol(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        public static void Apply(Form Form, int _Elipse) {
            try {
                Form.FormBorderStyle = FormBorderStyle.None;
                Form.Region = Region.FromHrgn(Ellipse.FunctionLol(0, 0, Form.Width, Form.Height, _Elipse, _Elipse));
            }
            catch (Exception) { }
        }

        public static void Apply(Control ctrl, int Elipse) {
            try {
                ctrl.Region = Region.FromHrgn(Ellipse.FunctionLol(0, 0, ctrl.Width, ctrl.Height, Elipse, Elipse));
            }
            catch (Exception) { }
        }
    }
}