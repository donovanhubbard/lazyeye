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
using System.Windows.Forms.DataVisualization.Charting;
using LazyEye.Monitors;
using LazyEye.Models;

namespace LazyEye.Views
{
    public partial class DesktopForm : Form
    {
        private static log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public LinkedList<SessionPanel> SessionPanels;
        public SessionPanel InternetPanel;

        private delegate void UpdateSessionPanelDelegate(SessionPanel sessionPanel, PingSession pingSession);

        public DesktopForm()
        {
            log.Debug("Started DesktopForm");
            InitializeComponent();

            InitializePanels();

        }

        private void InitializePanels()
        {
            SessionPanels = new LinkedList<SessionPanel>();

            InternetPanel = new SessionPanel();

            InternetPanel.HostLabel = hostLabel;
            InternetPanel.LastDelayLabel = lastDelayLabel;
            InternetPanel.AvgLabel = avgLabel;
            InternetPanel.MaxLabel = maxLabel;
            InternetPanel.MinLabel = minLabel;
            InternetPanel.JitterLabel = jitterLabel;
            InternetPanel.PacketLossLabel = packetLossLabel;
            InternetPanel.LatencyChart = latencyChart;
            InternetPanel.ParentForm = this;

            SessionPanels.AddFirst(InternetPanel);

        }

        /*
        public void OnPingReceived(object sender, PingReplyReceivedEventArgs eventArgs)
        {
            foreach(SessionPanel currentPanel in SessionPanels)
            {
                UpdateSessionPanel(InternetPanel, eventArgs.PingSession);
            }   
        }*/

        public void UpdateSessionPanel(SessionPanel sessionPanel, PingSession pingSession)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new UpdateSessionPanelDelegate(UpdateSessionPanel), sessionPanel, pingSession);
            }
            else
            {
                UpdateStatistics(sessionPanel, pingSession);
                UpdateLatencyChart(sessionPanel, pingSession);
                //DrawLatencyChart(sessionPanel, eventArgs.PingSession);
                //WriteStatistics(eventArgs.PingSession);
            }
        }

        public void UpdateStatistics(SessionPanel sessionPanel, PingSession pingSession)
        {
            sessionPanel.HostLabel.Text = pingSession.Host;
            sessionPanel.PacketLossLabel.Text = pingSession.PacketLostPercent.ToString() + "%";

            if (pingSession.PacketLostPercent < 100)
            {
                ICMPReply lastReply = pingSession.ReplyQueue.Last();

                if (lastReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    sessionPanel.LastDelayLabel.Text = lastReply.RoundtripTime.ToString() + "ms";
                }
                else
                {
                    sessionPanel.LastDelayLabel.Text = lastReply.Status.ToString();
                }

                sessionPanel.AvgLabel.Text = pingSession.AverageLatency.ToString() + " ms";
                sessionPanel.MaxLabel.Text = pingSession.MaxLatency.ToString() + " ms";
                sessionPanel.MinLabel.Text = pingSession.MinLatency.ToString() + " ms";
                sessionPanel.JitterLabel.Text = pingSession.Jitter.ToString() + " ms";
            }
            else
            {
                sessionPanel.LastDelayLabel.Text = pingSession.ReplyQueue.Last().Status.ToString();
                sessionPanel.AvgLabel.Text = "N/A";
                sessionPanel.MaxLabel.Text = "N/A";
                sessionPanel.MinLabel.Text = "N/A";
                sessionPanel.JitterLabel.Text = "N/A";
            }
        }

        private void UpdateLatencyChart(SessionPanel sessionPanel,PingSession pingSession)
        {
            sessionPanel.LatencyChart.Series.Clear();

            var series = new Series();
            series.Name = "latency";

            series.ChartType = SeriesChartType.Area;

            var chartArea = new ChartArea();
            chartArea.AxisX.LabelStyle.Enabled = false;

            List<int> xvals = new List<int>();
            List<long> yvals = new List<long>();

            int i = 0;
            foreach (ICMPReply reply in pingSession.ReplyQueue)
            {
                xvals.Add(i);
                i++;
                yvals.Add(reply.RoundtripTime);
            }

            sessionPanel.LatencyChart.Series.Add(series);

            sessionPanel.LatencyChart.Series["latency"].Points.DataBindXY(xvals, yvals);
            sessionPanel.LatencyChart.Invalidate();
        }
    }

    /// <summary>
    /// All the form components that display information about a given sessions's ping
    /// </summary>
    public class SessionPanel
    {
        public Label LastDelayLabel { get; set; }
        public Label HostLabel { get; set; }
        public Label AvgLabel { get; set; }
        public Label MaxLabel { get; set; }
        public Label MinLabel { get; set; }
        public Label JitterLabel { get; set; }
        public Label PacketLossLabel { get; set; }

        public Chart LatencyChart { get; set; }

        public DesktopForm ParentForm { get; set; }



        public void OnPingReceived(object sender, PingReplyReceivedEventArgs eventArgs)
        {

            ParentForm.UpdateSessionPanel(this, eventArgs.PingSession);

        }
    }


}
