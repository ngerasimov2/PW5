namespace PW5._2
{
    interface IHello
    {
        void SayHello();
    }

    class RussianHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Привет");
        }
    }
    class EnglishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    class FrenchHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Bonjour");
        }
    }
    class GermanHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Guten Tag");
        }
    }
    class SpanishHello : IHello
    {
        public void SayHello()
        {
            Console.WriteLine("Hola");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IHello> hellos = new List<IHello>();
            hellos.Add(new RussianHello());
            hellos.Add(new EnglishHello());
            hellos.Add(new FrenchHello());
            hellos.Add(new GermanHello());
            hellos.Add(new SpanishHello());

            foreach (var hello in hellos)
            {
                SayHello(hello);
            }

            Console.ReadKey();
        }
        static void SayHello(IHello hello)
        {
            hello.SayHello();
        }
    }
}