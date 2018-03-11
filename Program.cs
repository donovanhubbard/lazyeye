using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyEye.Views;
using LazyEye.Monitors;
using log4net;

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
            log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
            log.Info("Starting application");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PingMonitor pm = new PingMonitor();
            pm.Host = "8.8.8.81";

            DesktopForm form = new DesktopForm();

            pm.Start();
            form.SubscribeToPingMonitor(pm);

            log.Debug("Launching DesktopForm");
            Application.Run(form);

            pm.Stop();
            log.Info("Exiting program");
        }
    }
}
