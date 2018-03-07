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

        public void SubscribeToPingMonitor(PingMonitor pingMonitor) 
        {
            pingMonitor.PingReplyRecieved += new EventHandler<PingReplyReceivedEventArgs>(PingReplyReceivedHandler);
        }


        //Event Subscriptions
        public void PingReplyReceivedHandler(object sender, PingReplyReceivedEventArgs args)
        {
            lastDelayLabel.Text = args.PingReply.RoundtripTime.ToString();
        }

    }
}
