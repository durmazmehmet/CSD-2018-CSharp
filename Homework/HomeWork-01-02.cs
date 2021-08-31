namespace CSD
{
    class App
    {
        public static void Main()
        {
            int val;

            for (;;) {
                System.Console.Write("L�tfen 2'den b�y�k pozitif bir �ift say� giriniz:");
                val = int.Parse(System.Console.ReadLine());
                if (val == 0)
                    break;

                if (val < 2 || val % 2 == 1)
                {
                    System.Console.WriteLine("Ge�ersiz bir sya� girildi!");
                    continue;
                }

                for (int i = 2; i <= val / 2; ++i)
                    if (Prime.IsPrime(i) && Prime.IsPrime(val - i))
                    {
                        System.Console.WriteLine("{0} + {1}", i, val - i);
                        //break;
                    }
            }
        }
    }

    class Prime
    {
        public static bool IsPrime(int val)
        {
            if (val < 2)
                return false;

            if (val % 2 == 0)
                return val == 2;

            for (int i = 3; i * i <= val; ++i)
                if (val % i == 0)
                    return false;

            return true;

        }
    }
}


