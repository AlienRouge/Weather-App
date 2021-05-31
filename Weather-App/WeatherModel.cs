using System;

namespace Weather_App
{
    public class WeatherModel
    {
        private double[][] Q =
        {
            new[] {-.4, .3, .1},
            new[] {.4, -.8, .4},
            new[] {.1, .4, -.5},
        };
        public int TimeNext;
        public int State;
        private readonly Random _random = new Random();

        private double[] GetString(int i)
        {
            var x = new double[Q[i].Length];
            for (int j = 0; j < Q[i].Length; j++)
            {
                if (i == j)
                    x[j] = 0;

                else
                    x[j] = Q[i][j] / -Q[i][i];
            }

            return x;
        }

        public void NextState()
        {
            double alpha = _random.NextDouble();
            TimeNext = (int) Math.Round(Math.Log(alpha) / Q[State][State] * 24);

            double[] localP = GetString(State);
            int i;
            for (i = 0; i <= localP.Length; i++)
            {
                alpha -= localP[i];
                if (!(alpha <= 0)) continue;
                State = i;
                break;
            }
        }

        public void Init()
        {
            NextState();
            TimeNext = 0;
        }
    }
}