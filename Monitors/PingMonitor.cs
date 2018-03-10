using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;
using LazyEye.Views;
using log4net;

namespace LazyEye.Monitors
{
    public class PingMonitor
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Thread thread;
        private bool isRunning;
        private int delay = 1000;
        private PingSession pingSession;

        public string Host { get; set; }

        //Events
        public event EventHandler<PingReplyReceivedEventArgs> PingReplyRecieved;

        private PingReply SendPing()
        {
            Ping pinger = new Ping();
            PingReply reply = pinger.Send(Host);
            return reply;
        }

        public void Start()
        {
            pingSession = new PingSession();
            pingSession.MaxLength = 10;

            thread = new Thread(Run);
            isRunning = true;
            thread.Start();
            
        }

        /// <summary>
        /// Terminates the thread that is running the monitoring
        /// </summary>
        public void Stop()
        {
            log.Debug("Stopping ping monitor to host " + Host);
            isRunning = false;
        }

        private void Run()
        {
            while (isRunning)
            {
                PingReply reply = SendPing();

                pingSession.Add(reply);

                PingReplyReceivedEventArgs args = new PingReplyReceivedEventArgs();
                args.PingSession = pingSession;

                if(PingReplyRecieved != null)
                {
                    PingReplyRecieved(this, args);
                }

                Thread.Sleep(delay);
            }

            log.Info("PingMonitor to host [" + Host + "] terminated");
        }
    }


    //Event Args
    public class PingReplyReceivedEventArgs : EventArgs
    {
        public PingSession PingSession{get; set;}
    }
}
