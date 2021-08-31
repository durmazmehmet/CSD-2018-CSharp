namespace CSD
{
    class App
    {
        public static void Main()
        {
            int height, width;
            int direction = 1, pos = 0;

            System.Console.Write("Yüksekliği giriniz:");
            height = int.Parse(System.Console.ReadLine());

            System.Console.Write("Genişliği giriniz:");
            width = int.Parse(System.Console.ReadLine());

            for (int i = 0; i < height; ++i)
            {
                DispRow(width, pos);
                if (pos == width - 1)
                    direction = -1;
                else if (pos == 0)
                    direction = 1;
                pos += direction;
            }
        }

        public static void DispRow(int width, int starPos)
        {
            System.Console.Write('|');
            for (int i = 0; i < width; ++i)
                System.Console.Write(i == starPos ? '*' : ' ');
            System.Console.WriteLine('|');
        }
    }
}



