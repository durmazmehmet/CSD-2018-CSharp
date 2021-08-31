using System;

namespace CSD
{
    class App
    {
        public static void Main()
        {
            long n;
            int[] digits;

            for (;;)
            {
                Console.Write("Sayý giriniz:");
                n = long.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Negatif sayý giremezsiniz!..");
                    continue;
                }
                if (n == 0)
                    break;
                digits = GetDigits(n);

                for (int i = 0; i < digits.Length; ++i)
                    Console.Write("{0} ", digits[i]);
                Console.WriteLine();
            }
        }

        public static int[] GetDigits(long n)
        {
            int len = (int)Math.Log10(n) + 1;
            int[] digits = new int[len];

            for (int i = len - 1; i >= 0; --i)
            {
                digits[i] = (int)(n % 10);
                n /= 10;
            }

            return digits;
        }
    }
}
