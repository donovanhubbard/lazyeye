namespace LazyEye.Views
{
    partial class DesktopForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DesktopForm));
            this.lastDelayLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.avgLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.jitterLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.packetLossLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.latencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label5 = new System.Windows.Forms.Label();
            this.hostLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.packetLossLabel2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.jitterLabel2 = new System.Windows.Forms.Label();
            this.avgLabel2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.maxLabel2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.latencyChart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.hostLabel2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lastDelayLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // lastDelayLabel
            // 
            this.lastDelayLabel.AutoSize = true;
            this.lastDelayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDelayLabel.Location = new System.Drawing.Point(144, 182);
            this.lastDelayLabel.Name = "lastDelayLabel";
            this.lastDelayLabel.Size = new System.Drawing.Size(120, 24);
            this.lastDelayLabel.TabIndex = 0;
            this.lastDelayLabel.Text = "initializing...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Response";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avg Latency";
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(25, 44);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(60, 13);
            this.avgLabel.TabIndex = 3;
            this.avgLabel.Text = "initializing...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Latency";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(25, 88);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(60, 13);
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "initializing...";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(10, 110);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Min Latency";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(25, 132);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(60, 13);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "initializing...";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(10, 154);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(29, 13);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Jitter";
            // 
            // jitterLabel
            // 
            this.jitterLabel.AutoSize = true;
            this.jitterLabel.Location = new System.Drawing.Point(25, 176);
            this.jitterLabel.Name = "jitterLabel";
            this.jitterLabel.Size = new System.Drawing.Size(60, 13);
            this.jitterLabel.TabIndex = 9;
            this.jitterLabel.Text = "initializing...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.packetLossLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.jitterLabel);
            this.groupBox1.Controls.Add(this.avgLabel);
            this.groupBox1.Controls.Add(this.Label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.minLabel);
            this.groupBox1.Controls.Add(this.maxLabel);
            this.groupBox1.Controls.Add(this.Label7);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 250);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Session Statistics";
            // 
            // packetLossLabel
            // 
            this.packetLossLabel.AutoSize = true;
            this.packetLossLabel.Location = new System.Drawing.Point(25, 220);
            this.packetLossLabel.Name = "packetLossLabel";
            this.packetLossLabel.Size = new System.Drawing.Size(60, 13);
            this.packetLossLabel.TabIndex = 11;
            this.packetLossLabel.Text = "initializing...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Packet Loss";
            // 
            // latencyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.latencyChart.ChartAreas.Add(chartArea1);
            this.latencyChart.Location = new System.Drawing.Point(297, 3);
            this.latencyChart.Name = "latencyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Series1";
            this.latencyChart.Series.Add(series1);
            this.latencyChart.Size = new System.Drawing.Size(491, 250);
            this.latencyChart.TabIndex = 11;
            this.latencyChart.Text = "latencyChart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(122, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Host";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.Location = new System.Drawing.Point(144, 75);
            this.hostLabel.Name = "hostLabel";
            this.hostLabel.Size = new System.Drawing.Size(120, 24);
            this.hostLabel.TabIndex = 13;
            this.hostLabel.Text = "initializing...";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.latencyChart);
            this.panel1.Controls.Add(this.hostLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lastDelayLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 261);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.latencyChart2);
            this.panel2.Controls.Add(this.hostLabel2);
            this.panel2.Controls.Add(this.label20);
            this.panel2.Controls.Add(this.lastDelayLabel2);
            this.panel2.Location = new System.Drawing.Point(12, 279);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 261);
            this.panel2.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "Host";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.packetLossLabel2);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.jitterLabel2);
            this.groupBox2.Controls.Add(this.avgLabel2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.minLabel2);
            this.groupBox2.Controls.Add(this.maxLabel2);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 250);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Session Statistics";
            // 
            // packetLossLabel2
            // 
            this.packetLossLabel2.AutoSize = true;
            this.packetLossLabel2.Location = new System.Drawing.Point(25, 220);
            this.packetLossLabel2.Name = "packetLossLabel2";
            this.packetLossLabel2.Size = new System.Drawing.Size(60, 13);
            this.packetLossLabel2.TabIndex = 11;
            this.packetLossLabel2.Text = "initializing...";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Packet Loss";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Avg Latency";
            // 
            // jitterLabel2
            // 
            this.jitterLabel2.AutoSize = true;
            this.jitterLabel2.Location = new System.Drawing.Point(25, 176);
            this.jitterLabel2.Name = "jitterLabel2";
            this.jitterLabel2.Size = new System.Drawing.Size(60, 13);
            this.jitterLabel2.TabIndex = 9;
            this.jitterLabel2.Text = "initializing...";
            // 
            // avgLabel2
            // 
            this.avgLabel2.AutoSize = true;
            this.avgLabel2.Location = new System.Drawing.Point(25, 44);
            this.avgLabel2.Name = "avgLabel2";
            this.avgLabel2.Size = new System.Drawing.Size(60, 13);
            this.avgLabel2.TabIndex = 3;
            this.avgLabel2.Text = "initializing...";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 154);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Jitter";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Max Latency";
            // 
            // minLabel2
            // 
            this.minLabel2.AutoSize = true;
            this.minLabel2.Location = new System.Drawing.Point(25, 132);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(60, 13);
            this.minLabel2.TabIndex = 7;
            this.minLabel2.Text = "initializing...";
            // 
            // maxLabel2
            // 
            this.maxLabel2.AutoSize = true;
            this.maxLabel2.Location = new System.Drawing.Point(25, 88);
            this.maxLabel2.Name = "maxLabel2";
            this.maxLabel2.Size = new System.Drawing.Size(60, 13);
            this.maxLabel2.TabIndex = 5;
            this.maxLabel2.Text = "initializing...";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(10, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "Min Latency";
            // 
            // latencyChart2
            // 
            chartArea2.Name = "ChartArea1";
            this.latencyChart2.ChartAreas.Add(chartArea2);
            this.latencyChart2.Location = new System.Drawing.Point(297, 3);
            this.latencyChart2.Name = "latencyChart2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series2.Name = "Series1";
            this.latencyChart2.Series.Add(series2);
            this.latencyChart2.Size = new System.Drawing.Size(491, 250);
            this.latencyChart2.TabIndex = 11;
            this.latencyChart2.Text = "chart1";
            // 
            // hostLabel2
            // 
            this.hostLabel2.AutoSize = true;
            this.hostLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel2.Location = new System.Drawing.Point(144, 75);
            this.hostLabel2.Name = "hostLabel2";
            this.hostLabel2.Size = new System.Drawing.Size(120, 24);
            this.hostLabel2.TabIndex = 13;
            this.hostLabel2.Text = "initializing...";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(121, 126);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(170, 26);
            this.label20.TabIndex = 1;
            this.label20.Text = "Last Response";
            // 
            // lastDelayLabel2
            // 
            this.lastDelayLabel2.AutoSize = true;
            this.lastDelayLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastDelayLabel2.Location = new System.Drawing.Point(144, 182);
            this.lastDelayLabel2.Name = "lastDelayLabel2";
            this.lastDelayLabel2.Size = new System.Drawing.Size(120, 24);
            this.lastDelayLabel2.TabIndex = 0;
            this.lastDelayLabel2.Text = "initializing...";
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesktopForm";
            this.Text = "LazyEye";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lastDelayLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label Label8;
        private System.Windows.Forms.Label jitterLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label packetLossLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart latencyChart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label hostLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label packetLossLabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label jitterLabel2;
        private System.Windows.Forms.Label avgLabel2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.Label maxLabel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataVisualization.Charting.Chart latencyChart2;
        private System.Windows.Forms.Label hostLabel2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lastDelayLabel2;
    }
}

