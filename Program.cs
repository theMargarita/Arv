namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //just to be able to read all the text esier
            string NL = Environment.NewLine;
            string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
            string GREEN = Console.IsOutputRedirected ? "" : "\x1b[92m";
            string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
            string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";

            Cat cat = new Cat(2, "Farmer cat", "Fibie", 15, "Likes to sleep", "Likes to play");
            cat.ShowInfo();
            cat.Sleepy(0);
            cat.MakeSound();
            cat.Eating();
            cat.VeryDangous(false);
            
            Console.WriteLine("\n");

            Dog dog = new Dog(24, "Big fluffy Dog", "Soya", 7, true, "To awake for sleeping");
            dog.ShowInfo();
            dog.MakeSound();
            dog.Eating();
            dog.VeryDangous(true);
            dog.Poop(true);

            Console.WriteLine("\n");

            Cow cow = new Cow(500, "Fluffy magic cow", "Ermintrude the Cow", 14, 3, "Enjoy sleeping");
            cow.ShowInfo();
            cow.MakeSound();
            cow.Eating();
            cow.VeryDangous(true);

            Console.WriteLine("\n");

            Husky husky = new Husky(20, "Winter dog", "Holly Polly", 10, true, "She likes to nap on the sofa", 4);
            husky.ShowInfo();
            husky.Eating();
            husky.MakeSound();
            husky.Poop(true);
            husky.VeryDangous(false);

            Console.WriteLine("\n");

            Malamute malamute = new Malamute(40, "ice aged dog", "Bob the malamute", 7, false, "no time to sleep, need to roll around in the snow", "the fluffiest of the all");
            malamute.ShowInfo();
            malamute.MakeSound();
            malamute.Eating();
            malamute.VeryDangous(true);

            //wait before closing
            Console.ReadKey();
        }
    }
}
