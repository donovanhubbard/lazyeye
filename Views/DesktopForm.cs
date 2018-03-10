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

        public DesktopForm()
        {
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
                PingReply reply = args.PingReply;
                if (reply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    this.lastDelayLabel.Text = reply.RoundtripTime.ToString() + "ms";
                }
                else
                {
                    this.lastDelayLabel.Text = reply.Status.ToString() ;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
