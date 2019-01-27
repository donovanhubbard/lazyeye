using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LazyEye.Monitors;
using System.Windows.Forms.DataVisualization.Charting;

namespace LazyEye.Views
{
    /// <summary>
    /// All the form components that display information about a given sessions's ping
    /// </summary>
    public class SessionPanel
    {

        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public PingMonitor Monitor { get; set; }

        public Label TitleLabel { get; set; }
        public Label LastDelayLabel { get; set; }
        public Label HostLabel { get; set; }
        public Label AvgLabel { get; set; }
        public Label MaxLabel { get; set; }
        public Label MinLabel { get; set; }
        public Label JitterLabel { get; set; }
        public Label PacketLossLabel { get; set; }

        public PlayButton PButton { get; set; }

        public Chart LatencyChart { get; set; }

        public DesktopForm ParentForm { get; set; }


        public void Initialize()
        {
            if (PButton != null)
            {
                PButton.PauseListeners += OnPause;
                PButton.PlayListeners += OnPlay;
            }
            else
            {
                log.Error("Initializing panel wiyhout a play button. Initialization must be called after play bytton assigned");
                throw new InvalidOperationException("Initializing panel wiyhout a play button. Initialization must be called after play bytton assigned");
            }
        }

        
        public void OnPause()
        {
            Monitor.Stop();
        }

        public void OnPlay()
        {
            Monitor.Start();
        }


        public void OnPingReceived(object sender, PingReplyReceivedEventArgs eventArgs)
        {

            ParentForm.UpdateSessionPanel(this, eventArgs.PingSession);

        }
    }
}
