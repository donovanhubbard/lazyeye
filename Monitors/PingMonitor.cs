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
       
        private Thread thread;
        private bool isRunning;
        private string host = "8.8.8.8";

        //Events
        public event EventHandler<PingReplyReceivedEventArgs> PingReplyRecieved;

        private PingReply SendPing()
        {
            Ping pinger = new Ping();
            PingReply reply = pinger.Send(host);
            return reply;
        }

        public void Start()
        {
            thread = new Thread(Run);
            isRunning = true;
            thread.Start();
            
        }

        /// <summary>
        /// Terminates the thread that is running the monitoring
        /// </summary>
        public void Stop()
        {
            isRunning = false;
        }

        private void Run()
        {
            while (isRunning)
            {
                PingReply reply = SendPing();

                PingReplyReceivedEventArgs args = new PingReplyReceivedEventArgs();
                args.PingReply = reply;

                if(PingReplyRecieved != null)
                {
                    PingReplyRecieved(this, args);
                }

                Thread.Sleep(1000);
            }
        }




    }


    //Event Args
    public class PingReplyReceivedEventArgs : EventArgs
    {
        public PingReply PingReply { get; set; }
    }
}
