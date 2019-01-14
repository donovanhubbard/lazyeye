using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyEye.Views;
using LazyEye.Monitors;
using log4net;
using System.Net.NetworkInformation;
using System.Net;

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

            PingMonitor GatewayPM = new PingMonitor();
            GatewayPM.Host = GetDefaultGateway().ToString();
            GatewayPM.Start();

            DesktopForm Form = new DesktopForm();


            //InternetPM.Subscribe(Form.OnPingReceived);
            InternetPM.Subscribe(Form.InternetPanel.OnPingReceived);

            log.Debug("Launching DesktopForm");
            Application.Run(Form);

            InternetPM.Stop();
            GatewayPM.Stop();
            log.Info("Exiting program");
        }

        /// <summary>
        /// https://stackoverflow.com/questions/13634868/get-the-default-gateway
        /// </summary>
        /// <returns></returns>
        public static IPAddress GetDefaultGateway()
        {
            return NetworkInterface
                .GetAllNetworkInterfaces()
                .Where(n => n.OperationalStatus == OperationalStatus.Up)
                .Where(n => n.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                .SelectMany(n => n.GetIPProperties()?.GatewayAddresses)
                .Select(g => g?.Address)
                .Where(a => a != null)
                // .Where(a => a.AddressFamily == AddressFamily.InterNetwork)
                // .Where(a => Array.FindIndex(a.GetAddressBytes(), b => b != 0) >= 0)
                .FirstOrDefault();
        }
    }
}
