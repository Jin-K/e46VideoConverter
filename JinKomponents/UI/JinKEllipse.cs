using JinKomponents.Librairie;
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace JinKomponents.UI {
    [ProvideProperty("JinKomponents", typeof(Control))]
    [DebuggerStepThrough]
    public class JinKEllipse : Component {
        private int integer1 = 5;
        private ContainerControl containerControl1;
        private Control control1;
        private IContainer container1;
        private System.Windows.Forms.Timer timer1;

        private ContainerControl ContainerController1 {
            get {
                return containerControl1;
            }
            set {
                containerControl1 = value;
                ApplyEllipse();
            }
        }

        public override ISite Site {
            get {
                return base.Site;
            }
            set {
                base.Site = value;
                if (value != null) {
                    IDesignerHost service = value.GetService(typeof(IDesignerHost)) as IDesignerHost;
                    if (service == null) return;

                    IComponent rootComponent = service.RootComponent;
                    if (!(rootComponent is ContainerControl)) return;

                    ContainerController1 = rootComponent as ContainerControl;
                }
            }
        }

        public void ApplyEllipse() {
            try {
                if (control1 != null) 
                    Ellipse.Apply(control1, integer1);
            }
            catch (Exception) { }
        }
    }
}