using System;

namespace CSD
{
    class App
    {
        public static void Main()
        {
            Proc p = new Proc(Sample.Foo);

            p();
        }

       
    }


    
    delegate void Proc();

    class Sample
    {
        public static void Foo()
        {
            Console.WriteLine("Sample.Foo");
        }
    }
}
