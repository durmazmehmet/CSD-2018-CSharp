namespace CSD
{
    public class Sample
    {
        private int m_a;

        public Sample(int a)
        {
            m_a = a;
        }

        public void Disp()
        {
            System.Console.WriteLine(m_a);
        }
    }
}

namespace Other
{
    class Test
    {
        public static void Foo()
        {
            System.Console.WriteLine("Other.Foo");
        }
    }
}
