using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyEye.Views;
using LazyEye.Monitors;

namespace LazyEye
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PingMonitor pm = new PingMonitor();
            DesktopForm form = new DesktopForm();

            pm.Start();
            form.SubscribeToPingMonitor(pm);

            Application.Run(form);

            
        }
    }
}
