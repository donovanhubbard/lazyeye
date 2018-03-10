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
                    log.Debug("Reply queue to large. Dequeueing oldest item");
                    replyQueue.Dequeue();
                }
                log.Debug("Queue size [" + replyQueue.Count + "]");

                PingReplyReceivedEventArgs args = new PingReplyReceivedEventArgs();
                args.ReplyQueue = replyQueue;
                args.ComputeStatistics();

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
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Queue<PingReply> ReplyQueue { get; set; }
        public long AverageLatency { get; set; }
        public float PacketLostPercent { get; set; }
        public long MaxLatency { get; set; }
        public long MinLatency { get; set; }
        public long Jitter { get; set; }

        /// <summary>
        /// Analyzes all the PingReply objects and derives some statistics
        /// </summary>
        public void ComputeStatistics()
        {
            log.Debug("Starting to compute statistics for " + ReplyQueue.Count + " replies");
            if (ReplyQueue.Count > 0)
            {
                MaxLatency = ReplyQueue.Peek().RoundtripTime;
                MinLatency = MaxLatency;
                long runningTotal = 0;

                foreach (PingReply reply in ReplyQueue)
                {
                    if (reply.RoundtripTime < MinLatency)
                    {
                        MinLatency = reply.RoundtripTime;
                    }
                    if (reply.RoundtripTime > MaxLatency)
                    {
                        MaxLatency = reply.RoundtripTime;
                    }
                    runningTotal += reply.RoundtripTime;
                }

                AverageLatency = runningTotal / ReplyQueue.Count;
                Jitter = MaxLatency - MinLatency;

                log.Debug("Min=" + MinLatency);
                log.Debug("Max=" + MaxLatency);
                log.Debug("Avg=" + AverageLatency);
                log.Debug("Jitter=" + Jitter);

            }
            else
            {
                log.Warn("The PingReplyQueue is empty");
            }

            log.Debug("Completed calculating statistics");

        }
    }
}
