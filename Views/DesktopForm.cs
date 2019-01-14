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

        public DesktopForm()
        {
            log.Debug("Started DesktopForm");
            InitializeComponent();
        }

        //Delegates for updating the form
        private delegate void DisplayLastPingDeletegate(object sender, PingReplyReceivedEventArgs args);


        public void OnPingReceived(object sender, PingReplyReceivedEventArgs eventArgs)
        {
            DisplayLastPing(sender, eventArgs);
        }


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
                DrawLatencyChart(args.PingSession);
                WriteStatistics(args.PingSession);
            }
        }

        private void WriteStatistics(PingSession pingSession)
        {
            this.hostLabel.Text = pingSession.Host;
            this.packetLossLabel.Text = pingSession.PacketLostPercent.ToString() + "%";

            if (pingSession.PacketLostPercent < 100)
            {
                ICMPReply lastReply = pingSession.ReplyQueue.Last();
                
                if (lastReply.Status == System.Net.NetworkInformation.IPStatus.Success)
                {
                    this.lastDelayLabel.Text = lastReply.RoundtripTime.ToString() + "ms";
                }
                else
                {
                    this.lastDelayLabel.Text = lastReply.Status.ToString();
                }

                this.avgLabel.Text = pingSession.AverageLatency.ToString() + " ms";
                this.maxLabel.Text = pingSession.MaxLatency.ToString() + " ms";
                this.minLabel.Text = pingSession.MinLatency.ToString() + " ms";
                this.jitterLabel.Text = pingSession.Jitter.ToString() + " ms";
            }
            else
            {
                this.lastDelayLabel.Text = pingSession.ReplyQueue.Last().Status.ToString();
                this.avgLabel.Text = "N/A";
                this.maxLabel.Text = "N/A";
                this.minLabel.Text = "N/A";
                this.jitterLabel.Text = "N/A";
            }
        }

        private void DrawLatencyChart(PingSession pingSession)
        {
            this.latencyChart.Series.Clear();
            

            var series = new Series();
            series.Name = "latency";

            series.ChartType = SeriesChartType.Area;

            var chartArea = new ChartArea();
            chartArea.AxisX.LabelStyle.Enabled = false;
            //chartArea.AxisX.Enabled = false;
            

            List<int> xvals = new List<int>();
            List<long> yvals= new List<long>();

            int i = 0;
            foreach (ICMPReply reply in pingSession.ReplyQueue)
            {
                xvals.Add(i);
                i++;
                yvals.Add(reply.RoundtripTime);
            }

            this.latencyChart.Series.Add(series);
            //latencyChart.ChartAreas.Add(chartArea);
            

            latencyChart.Series["latency"].Points.DataBindXY(xvals, yvals);
            latencyChart.Invalidate();
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
