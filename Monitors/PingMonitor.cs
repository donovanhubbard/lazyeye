using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Threading;
using LazyEye.Views;
using log4net;
using LazyEye.Models;

namespace LazyEye.Monitors
{
    public class PingMonitor
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private Thread thread;
        private bool isRunning;
        private int delay = 1000;
        private PingSession pingSession;

        /// <summary>
        /// The IP address to ping. Must be an IP
        /// </summary>
        public string Host { get; set; }

        /// <summary>
        /// The friendly name to display to end user. Can be anything
        /// </summary>
        public string Title { get; set; }

        //Events
        public event EventHandler<PingReplyReceivedEventArgs> PingReplyRecieved;

        public delegate void OnPingReplyReceived(object sender, PingReplyReceivedEventArgs reply);

        private ICMPReply SendPing()
        {
            Ping pinger = new Ping();
            PingReply reply = null;
            ICMPReply replyWrapper = null;
            try
            {
                reply = pinger.Send(Host);
                replyWrapper = new ICMPReply(reply);
            }catch(PingException e)
            {
                replyWrapper = new ICMPReply();
                //todo: this throws an exception if it's a hostname instead of an IP address
                replyWrapper.Address = System.Net.IPAddress.Parse(Host);
                replyWrapper.Status = IPStatus.IcmpError;
            }
            return replyWrapper;
        }

        public void Start()
        {
            pingSession = new PingSession();
            pingSession.MaxLength = 60;
            pingSession.Host = Host;
            pingSession.Title = Title;

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
                ICMPReply reply = SendPing();

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

        /// <summary>
        /// Subscribes to all relevant events on the ping monitor
        /// </summary>
        /// <param name="pingMonitor"></param>
        public void Subscribe(OnPingReplyReceived onPingReplyReceived)
        {
            PingReplyRecieved += new EventHandler<PingReplyReceivedEventArgs>(onPingReplyReceived);
        }

        public void Unsubscribe(OnPingReplyReceived onPingReplyReceived)
        {
            throw new NotImplementedException();
        }

    }


    //Event Args
    public class PingReplyReceivedEventArgs : EventArgs
    {
        public PingSession PingSession{get; set;}
    }
}
