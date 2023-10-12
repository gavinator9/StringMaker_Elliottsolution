namespace StringMaker_Elliott
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stringmanager maker= new Stringmanager();
            Console.WriteLine(maker.reverse("Sunbeam Tiger"));
            Console.WriteLine(maker.reverse("Sunbeam Tiger", true));
            Console.WriteLine(maker.ToString("One Two Five Four"));
            Console.WriteLine(maker.Equals("Sunbeam Tiger"));
            Console.WriteLine(maker.symmetric("ABBA"));
            Console.WriteLine(maker.symmetric("ABA"));
            Console.WriteLine(maker.symmetric("ABba"));

        }
    }
}