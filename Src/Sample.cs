namespace CSD
{
	class App
	{
		public static void Main()
		{
			double result;

			result = Square();
			System.Console.WriteLine(result);
		}

		public static double Square()
		{
			double a;

			System.Console.Write("Bir deger giriniz:");
			a = double.Parse(System.Console.ReadLine());
			return a * a;
		}
	}
}

