
namespace Weather_App
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.mainButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataLbl = new System.Windows.Forms.Label();
            this.mainChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.changesLbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChiResultLbl = new System.Windows.Forms.Label();
            this.ChiLbl = new System.Windows.Forms.Label();
            this.ByRudov_PolozhNeTvoyo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainButton
            // 
            this.mainButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainButton.Location = new System.Drawing.Point(44, 106);
            this.mainButton.Name = "mainButton";
            this.mainButton.Size = new System.Drawing.Size(118, 47);
            this.mainButton.TabIndex = 0;
            this.mainButton.Text = "Start";
            this.mainButton.UseVisualStyleBackColor = false;
            this.mainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataLbl
            // 
            this.dataLbl.AutoSize = true;
            this.dataLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataLbl.Location = new System.Drawing.Point(27, 16);
            this.dataLbl.Name = "dataLbl";
            this.dataLbl.Size = new System.Drawing.Size(148, 24);
            this.dataLbl.TabIndex = 1;
            this.dataLbl.Text = "Day: 00 - 00:00";
            // 
            // mainChart
            // 
            this.mainChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisY.Interval = 1D;
            chartArea1.Name = "ChartArea1";
            chartArea2.Name = "ChartArea2";
            this.mainChart.ChartAreas.Add(chartArea1);
            this.mainChart.ChartAreas.Add(chartArea2);
            this.mainChart.Location = new System.Drawing.Point(227, 13);
            this.mainChart.Name = "mainChart";
            series1.BorderWidth = 15;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series1.Color = System.Drawing.Color.RoyalBlue;
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            series2.ChartArea = "ChartArea2";
            series2.Name = "Series2";
            this.mainChart.Series.Add(series1);
            this.mainChart.Series.Add(series2);
            this.mainChart.Size = new System.Drawing.Size(703, 511);
            this.mainChart.TabIndex = 2;
            this.mainChart.Text = "chart1";
            // 
            // changesLbl
            // 
            this.changesLbl.AutoSize = true;
            this.changesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changesLbl.Location = new System.Drawing.Point(3, 49);
            this.changesLbl.Name = "changesLbl";
            this.changesLbl.Size = new System.Drawing.Size(0, 18);
            this.changesLbl.TabIndex = 3;
            this.changesLbl.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChiResultLbl);
            this.panel1.Controls.Add(this.ChiLbl);
            this.panel1.Controls.Add(this.changesLbl);
            this.panel1.Controls.Add(this.mainButton);
            this.panel1.Controls.Add(this.dataLbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 512);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(50, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 80);
            this.label1.TabIndex = 6;
            this.label1.Text = "Weather types:\r\n0 - Clear\r\n1 - Cloudy\r\n2 - Overcast\r\n\r\n";
            // 
            // ChiResultLbl
            // 
            this.ChiResultLbl.AutoSize = true;
            this.ChiResultLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChiResultLbl.Location = new System.Drawing.Point(135, 477);
            this.ChiResultLbl.Name = "ChiResultLbl";
            this.ChiResultLbl.Size = new System.Drawing.Size(49, 18);
            this.ChiResultLbl.TabIndex = 5;
            this.ChiResultLbl.Text = "False";
            this.ChiResultLbl.Visible = false;
            // 
            // ChiLbl
            // 
            this.ChiLbl.AutoSize = true;
            this.ChiLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChiLbl.Location = new System.Drawing.Point(23, 477);
            this.ChiLbl.Name = "ChiLbl";
            this.ChiLbl.Size = new System.Drawing.Size(110, 18);
            this.ChiLbl.TabIndex = 4;
            this.ChiLbl.Text = "Chi-Square is";
            this.ChiLbl.Visible = false;
            // 
            // ByRudov_PolozhNeTvoyo
            // 
            this.ByRudov_PolozhNeTvoyo.AutoSize = true;
            this.ByRudov_PolozhNeTvoyo.Location = new System.Drawing.Point(224, 434);
            this.ByRudov_PolozhNeTvoyo.Name = "ByRudov_PolozhNeTvoyo";
            this.ByRudov_PolozhNeTvoyo.Size = new System.Drawing.Size(0, 13);
            this.ByRudov_PolozhNeTvoyo.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 536);
            this.Controls.Add(this.ByRudov_PolozhNeTvoyo);
            this.Controls.Add(this.mainChart);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Weather-App";
            ((System.ComponentModel.ISupportInitialize)(this.mainChart)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button mainButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label dataLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart mainChart;
        private System.Windows.Forms.Label changesLbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ChiLbl;
        private System.Windows.Forms.Label ChiResultLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ByRudov_PolozhNeTvoyo;
    }
}

