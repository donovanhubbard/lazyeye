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
        private Queue<PingReply> replyQueue { get; set; }
        private int maxQueueSize = 3;

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
            replyQueue = new Queue<PingReply>();
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

                replyQueue.Enqueue(reply);

                if(replyQueue.Count > maxQueueSize)
                {
                    replyQueue.Dequeue();
                }

                PingReplyReceivedEventArgs args = new PingReplyReceivedEventArgs();
                args.ReplyQueue = replyQueue;

                if(PingReplyRecieved != null)
                {
                    PingReplyRecieved(this, args);
                }

                Thread.Sleep(delay);
            }
        }




    }


    //Event Args
    public class PingReplyReceivedEventArgs : EventArgs
    {
        public Queue<PingReply> ReplyQueue { get; set; }
    }
}
