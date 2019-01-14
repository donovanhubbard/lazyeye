using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace LazyEye.Models
{
    /// <summary>
    /// Custom wrapper for the PingReply object
    /// </summary>
    public class ICMPReply
    {
        public System.Net.IPAddress Address { get; set; }
        public long RoundtripTime { get; set; }
        public IPStatus Status { get; set; }

        public ICMPReply()
        {

        }

        public ICMPReply(PingReply pingReply)
        {
            Address = pingReply.Address;
            RoundtripTime = pingReply.RoundtripTime;
            Status = pingReply.Status;
        }
    }
}
