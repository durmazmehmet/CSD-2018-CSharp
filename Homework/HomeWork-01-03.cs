namespace CSD
{
    class App
    {
        public static void Main()
        {
            int n;
            int left, right;
            int direction;

            System.Console.Write("Bir deðer giriniz:");
            n = int.Parse(System.Console.ReadLine());

            left = right = n - 1;
            direction = 1;
            for (int i = 0; i < 2 * n - 1; ++i)
            {
                for (int k = 0; k <= right; ++k)
                    System.Console.Write(k >= left ? '*' : ' ');
                System.Console.WriteLine();

                if (left == 0)
                    direction = -1;

                left -= direction;
                right += direction;
                
            }
        }
    }
}


