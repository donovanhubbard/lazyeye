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

            PingMonitor InternetPM = new PingMonitor();
            InternetPM.Host = "8.8.8.8";
            InternetPM.Start();

            //PingMonitor GatewayPM = new PingMonitor();
            //GatewayPM.Host = "192.168.1.1";
            //GatewayPM.Start();

            DesktopForm form = new DesktopForm();

            
            form.SubscribeToPingMonitor(InternetPM);
            //form.SubscribeToPingMonitor(GatewayPM);

            log.Debug("Launching DesktopForm");
            Application.Run(form);

            InternetPM.Stop();
            log.Info("Exiting program");
        }
    }
}
