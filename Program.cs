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
            Console.WriteLine($"Name:{CYAN}{cat.Name}{NORMAL}");
            Console.WriteLine($"Typ of cat: {CYAN}{cat.Species}{NORMAL}");
            Console.WriteLine($"Cats Age in cat years: {CYAN}{cat.Age} years and 15 in human years.{NORMAL}");
            Console.WriteLine($"Weight: {CYAN}{cat.Mass}kg{NORMAL}");
            Console.WriteLine($"The cat{CYAN} {cat.Sleep}{NORMAL}");
            Console.WriteLine($"The cat {CYAN}{cat.PlayFul}{NORMAL}");
            cat.Sleepy(0);
            cat.MakeSound();
            cat.Eating();
            cat.VeryDangous(false);

            Console.ReadKey();
            Console.WriteLine("\n");

            Dog dog = new Dog(24, "Big fluffy Dog", "Soya", 7, true, "To awake for sleeping");
            Console.WriteLine($"Name:{CYAN} {dog.Name}{NORMAL}");
            Console.WriteLine($"Typ of dog: {CYAN}{dog.Species}{NORMAL}");
            Console.WriteLine($"Age in dog years: {CYAN}{dog.Age} and 7 in human years{NORMAL}");
            Console.WriteLine($"Weight: {CYAN}{dog.Mass} kg{NORMAL}");
            Console.WriteLine($"The dog is {CYAN}{dog.Sleep}{NORMAL}");
            dog.MakeSound();
            dog.Eating();
            dog.VeryDangous(true);
            dog.Poop(true);

            Console.ReadKey();
            Console.WriteLine("\n");

            Cow cow = new Cow(500, "Fluffy magic cow", "Ermintrude the Cow", 14, 3, "Enjoy sleeping");
            Console.WriteLine($"Name: {CYAN}{cow.Name}{NORMAL}");
            Console.WriteLine($"Type of cow: {CYAN}{cow.Species}{NORMAL}");
            Console.WriteLine($"Age in cow years: {CYAN}{cow.Age} years and 54 in human years{NORMAL}");
            Console.WriteLine($"Weight: {CYAN}{cow.Mass} kg.{NORMAL}");
            Console.WriteLine($"The cow {CYAN}{cow.Sleep}{NORMAL}");
            cow.MakeSound();
            cow.Eating();
            cow.VeryDangous(true);

            Console.ReadKey();
            Console.WriteLine("\n");

            Cat tiger = new Tiger(350, "Tiger", "Pinglan", 12, "enjoys naps", "Very very playful");
            Console.WriteLine($"Name: {CYAN}{tiger.Name}{NORMAL}");
            Console.WriteLine($"Age in cat years: {CYAN}{tiger.Age} years and 12 in human years {NORMAL}");
            Console.WriteLine($"Mass: {CYAN}{tiger.Mass}{NORMAL} kg");
            Console.WriteLine($"Type of cat: {CYAN}{tiger.Species}{NORMAL}");
            Console.WriteLine($"How playful is {CYAN}{tiger.Name}? {tiger.PlayFul}{NORMAL}");
            Console.WriteLine($"Status of {CYAN}{tiger.Name}: {tiger.Sleep} {NORMAL}");
            tiger.MakeSound();
            tiger.Sleepy(1);
            tiger.VeryDangous(true);
            tiger.Eating();

            Console.WriteLine("\n");
            Console.ReadKey();

            Husky husky = new Husky(20, "Winter dog", "Holly Polly", 10, true, "She likes to nap on the sofa");
            Console.WriteLine($"Name:{NORMAL} {CYAN}{husky.Name}{NORMAL}");
            Console.WriteLine($"Age in dog years: {CYAN}{husky.Age} years {NORMAL} and 10 in human years");
            Console.WriteLine($"Mass: {CYAN}{husky.Mass}{NORMAL} kg");
            Console.WriteLine($"Type of dog: {CYAN}{husky.Species}{NORMAL}");
            Console.WriteLine($"Satus: {CYAN}{husky.Sleep}{NORMAL}");
            Console.WriteLine($"Does she have a ppp? {CYAN}{husky.personalPoopPlockare}{NORMAL}");
            husky.Eating();
            husky.MakeSound();
            husky.Poop(true);
            husky.VeryDangous(false);

            Console.WriteLine("\n");
            Console.ReadKey();

            Animal animal = new Animal(40, "middle aged beaver", "Bob the beaver", 7, "no time to sleep, need to work on the pond");
            Console.WriteLine($"Name: {CYAN}{animal.Name}{NORMAL}");
            Console.WriteLine($"Age: {CYAN}{animal.Age} years{NORMAL}");
            Console.WriteLine($"Type of animal: {CYAN}{animal.Species}{NORMAL}");
            Console.WriteLine($"Mass: {CYAN}{animal.Mass} kg{NORMAL}");
            Console.WriteLine($"Status: {CYAN}{animal.Sleep}{NORMAL}");
            animal.MakeSound();
            animal.Eating();
            animal.VeryDangous(true);

            //wait before closing
            Console.ReadKey();
        }
    }
}
