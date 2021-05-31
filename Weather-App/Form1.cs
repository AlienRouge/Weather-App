using System;
using System.Drawing;
using System.Windows.Forms;

namespace Weather_App
{
    public partial class Form1 : Form
    {
        private WeatherModel weather;
        private StatisticModel statistic;
        readonly string[] weatherName = {"Сlear", "Cloudy", "Overcast"};

        private int Days = 1;
        private int Hours;

        private int Time;
        private int Temp;

        private bool _isStarted;

        public Form1()
        {
            InitializeComponent();

            mainChart.ChartAreas[0].AxisY.Maximum = 2;
            mainChart.ChartAreas[0].AxisY.Minimum = 0;
            mainChart.ChartAreas[0].AxisX.ScrollBar.IsPositionedInside = false;
        }

        void RestartForm()
        {
            weather = new WeatherModel();
            statistic = new StatisticModel();
            Time = 0;
            Temp = 0;
            Days = 1;
            Hours = 0;
            mainChart.Series[0].Points.Clear();
            mainChart.Series[1].Points.Clear();
            ChiLbl.Visible = ChiResultLbl.Visible = false;
            mainButton.Text = @"Stop";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_isStarted)
            {
                mainButton.Text = @"Start";
                _isStarted = false;
                timer1.Stop();
                statistic.SetDuration(weather.State, Time - Temp);
                var distribution = statistic.GetDistribution(Time);

                var chiResult = statistic.CompareProbs(Time);
                ChiResultLbl.Visible = ChiLbl.Visible = true;
                ChiResultLbl.Text =chiResult.ToString();
                ChiResultLbl.ForeColor = chiResult ? Color.Red : Color.Green;

                for (int i = 0; i < 3; i++)
                    mainChart.Series[1].Points.AddXY(i, distribution[i]);
            }
            else
            {
                RestartForm();
                _isStarted = true;
                mainChart.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = 0;
                weather.Init();
                timer1.Start();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (weather.TimeNext == 0)
            {
                statistic.SetDuration(weather.State, Time - Temp);
                weather.NextState();
                Temp = Time;
                changesLbl.Text = $"Last change:\nDay: {Days} - {Hours}:00 - {weatherName[weather.State]}";
            }
            else
                weather.TimeNext--;

            mainChart.Series[0].Points.AddXY(0, weather.State);

            mainChart.ChartAreas[0].AxisX.ScaleView.Size = 15;
            if (Time > 14)
            {
                mainChart.ChartAreas[0].AxisX.ScrollBar.Axis.ScaleView.Position = Time - 14;
            }


            dataLbl.Text = $@"Day: {Days} - {Hours}:00";
            if (Hours == 24)
            {
                Hours = 0;
                Days++;
            }

            Time++;
            Hours++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}