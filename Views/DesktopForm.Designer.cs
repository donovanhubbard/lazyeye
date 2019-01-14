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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(115, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Last Response";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 22);
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
            this.label4.Location = new System.Drawing.Point(18, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Max Latency";
            // 
            // maxLabel
            // 
            this.maxLabel.AutoSize = true;
            this.maxLabel.Location = new System.Drawing.Point(26, 91);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(60, 13);
            this.maxLabel.TabIndex = 5;
            this.maxLabel.Text = "initializing...";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(18, 116);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(65, 13);
            this.Label7.TabIndex = 6;
            this.Label7.Text = "Min Latency";
            // 
            // minLabel
            // 
            this.minLabel.AutoSize = true;
            this.minLabel.Location = new System.Drawing.Point(23, 139);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(60, 13);
            this.minLabel.TabIndex = 7;
            this.minLabel.Text = "initializing...";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(18, 164);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(29, 13);
            this.Label8.TabIndex = 8;
            this.Label8.Text = "Jitter";
            // 
            // jitterLabel
            // 
            this.jitterLabel.AutoSize = true;
            this.jitterLabel.Location = new System.Drawing.Point(23, 187);
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
            this.packetLossLabel.Location = new System.Drawing.Point(27, 230);
            this.packetLossLabel.Name = "packetLossLabel";
            this.packetLossLabel.Size = new System.Drawing.Size(60, 13);
            this.packetLossLabel.TabIndex = 11;
            this.packetLossLabel.Text = "initializing...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Packet Loss";
            // 
            // latencyChart
            // 
            chartArea1.Name = "ChartArea1";
            this.latencyChart.ChartAreas.Add(chartArea1);
            this.latencyChart.Location = new System.Drawing.Point(283, 12);
            this.latencyChart.Name = "latencyChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series1.Name = "Series1";
            this.latencyChart.Series.Add(series1);
            this.latencyChart.Size = new System.Drawing.Size(445, 234);
            this.latencyChart.TabIndex = 11;
            this.latencyChart.Text = "latencyChart";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(123, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Host";
            // 
            // hostLabel
            // 
            this.hostLabel.AutoSize = true;
            this.hostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hostLabel.Location = new System.Drawing.Point(145, 75);
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
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 261);
            this.panel1.TabIndex = 14;
            // 
            // DesktopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 293);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DesktopForm";
            this.Text = "LazyEye";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.latencyChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

