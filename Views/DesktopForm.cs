using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyEye.Monitors;

namespace LazyEye.Views
{
    public partial class DesktopForm : Form
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public DesktopForm()
        {
            log.Debug("Started DesktopForm");
            InitializeComponent();
        }

        /// <summary>
        /// Subscribes to all relevant events on the ping monitor
        /// </summary>
        /// <param name="pingMonitor"></param>
        public void SubscribeToPingMonitor(PingMonitor pingMonitor) 
        {
            pingMonitor.PingReplyRecieved += new EventHandler<PingReplyReceivedEventArgs>(DisplayLastPing);
        }

        //Delegates for updating the form
        private delegate void DisplayLastPingDeletegate(object sender, PingReplyReceivedEventArgs args);

        /// <summary>
        /// update anything that is related to the last ping response received
        /// </summary>
        /// <param name="args">Argument fired by the PingMonitor.PingReplyRecieved event </param>
        private void DisplayLastPing(object sender, PingReplyReceivedEventArgs args)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new DisplayLastPingDeletegate(DisplayLastPing), sender, args);
            }
            else
            {
                //PingReply reply = args.PingReply;
                PingReply lastReply = args.ReplyQueue.Last();

                if (lastReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    this.lastDelayLabel.Text = lastReply.RoundtripTime.ToString() + "ms";
                }
                else
                {
                    this.lastDelayLabel.Text = lastReply.Status.ToString() ;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
