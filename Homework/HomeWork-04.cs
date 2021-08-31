using System;

namespace CSD
{
    class App
    {
        public static void Main()
        {
            CentralLimitTheorem.Prove(10000, 5, 5000);
        }
    }

    class CentralLimitTheorem
    {
        public static void Prove(int max, int ssize, int n)
        {
            Random rand = new Random();
            int total;
            int avg;
            int[] freq = new int[10];
            

            for (int i = 0; i < n; ++i)
            {
                total = 0;
                for (int k = 0; k < ssize; ++k)
                    total += rand.Next(0, max);
                avg = total / ssize;

                ++freq[avg / 1000];
            }

            for (int i = 0; i < 10; ++i)
            {
                int count = (int)Math.Round(freq[i] / 50D);

                for (int k = 0; k < count; ++k)
                    Console.Write("X");
                Console.WriteLine();
            }
        }
    }
}
