using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using LazyEye.Models;

namespace LazyEye.Monitors
{
    /// <summary>
    /// Contains a collection of PingReply objects and various statistics about it.
    /// </summary>
    public class PingSession
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Queue<ICMPReply> ReplyQueue { get; private set; }
        public long AverageLatency { get; private set; }
        public double PacketLostPercent { get; private set; }
        public long MaxLatency { get; private set; }
        public long MinLatency { get; private set; }
        public long Jitter { get; private set; }
        public int MaxLength { get; set; }
        public string Host { get; set; }
        public string Title { get; set; }

        public PingSession()
        {
            ReplyQueue = new Queue<ICMPReply>();
        }
        
        public void Add(ICMPReply newReply)
        {
            log.Debug("Adding new reply");
            ReplyQueue.Enqueue(newReply);

            if (ReplyQueue.Count > MaxLength)
            {
                log.Debug("Reply queue to large. Dequeueing oldest item");
                ReplyQueue.Dequeue();
            }

            log.Debug("Queue size [" + ReplyQueue.Count + "]");

            ComputeStatistics();
            log.Debug("Completed Add");
        }


        /// <summary>
        /// Analyzes all the PingReply objects and derives some statistics
        /// </summary>
        public void ComputeStatistics()
        {
            log.Debug("Starting to compute statistics for "+ Host+ " for " + ReplyQueue.Count + " replies");

            if (ReplyQueue.Count > 0)
            {
                MaxLatency = ReplyQueue.Peek().RoundtripTime;
                MinLatency = MaxLatency;
                long runningTotal = 0;
                int errorCount = 0;

                foreach (ICMPReply reply in ReplyQueue)
                {
                    if (reply.Status == IPStatus.Success)
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
                    else
                    {
                        errorCount++;
                    }
                }

                AverageLatency = runningTotal / ReplyQueue.Count;
                Jitter = MaxLatency - MinLatency;
                PacketLostPercent = Math.Round(errorCount / (float)ReplyQueue.Count *100,1);

                log.Debug("Min=" + MinLatency);
                log.Debug("Max=" + MaxLatency);
                log.Debug("Avg=" + AverageLatency);
                log.Debug("Jitter=" + Jitter);
                log.Debug("PacketLoss%=" + PacketLostPercent);

            }
            else
            {
                log.Warn("The PingReplyQueue is empty");
            }

            log.Debug("Completed calculating statistics");

        }
    }
}
