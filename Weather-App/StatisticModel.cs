using System;

namespace Weather_App
{
    public class StatisticModel
    {
        private readonly int[] Duration = new int[3];
        private readonly double[] Distribution = new double[3];
        private readonly double[] P = { 0.33333, 0.33333, 0.33333 };

        public void SetDuration(int i, int duration)
        {
            Duration[i] += duration;
            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine($"{j} - {Duration[j]}");
            }
        }

        public double[] GetDistribution(int N)
        {
           
            for (int i = 0; i < 3; i++)
            {
                Distribution[i] = (double)Duration[i] / N;
            }
            return Distribution;
        }

        public bool CompareProbs(int N)
        {
            int[] massP = new int[3];
            int[] massDist = new int[3];

            for (int i = 0; i < Distribution.Length; i++)
            {
                massP[i] = (int)(P[i] * N);
                massDist[i] = (int)(Distribution[i] * N);
            }

            double chiSquare = 0;
            for (int i = 0; i < Distribution.Length; i++)
            {
                chiSquare += Math.Pow((massDist[i] - massP[i]), 2) / massP[i];
            }

            return chiSquare > 5.991;
        }
    }
}