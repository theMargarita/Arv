namespace Arv
{
    internal class Animal
    {
        string NL = Environment.NewLine;
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        string CYAN = Console.IsOutputRedirected ? "" : "\x1b[96m";

        //auto - properties
        //default värden
        public int Mass { get; set; } = 23;
        public string Species { get; set; } = "Unknown";
        public string Name { get; set; } = "Unknown";

        public int Age { get; set; } = 0;

        public string Sleep { get; set; } = "Everyone needs sleep";

        //constructors
        public Animal(int mass, string species, string name, int age, string sleep)
        {
            Mass = mass;
            Age = age;
            Name = name;
            Species = species;
            Sleep = sleep;
        }

        //method - print out the "sound"
        public virtual void MakeSound()
        {
            Console.WriteLine($"The animal goes {YELLOW}*grrr*{NORMAL}");
        }

        //method - how dangerous is the animal
        public virtual void VeryDangous(bool dangerous)
        {
            if (dangerous == true)
            {
                Console.WriteLine("Very dangerous animal");
            }
            else
            {
                Console.WriteLine("More friendly");
            }
        }

        public virtual void Eating()
        {
            Console.WriteLine($"The {Species} is Eating something that is nom nom for {Name}.");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Name: {CYAN}{Name}{NORMAL}");
            Console.WriteLine($"Typ of animal: {CYAN}{Species}{NORMAL}");
            Console.WriteLine($"Years: {CYAN}{Age}{NORMAL} in {Species} years");
            Console.WriteLine($"Weight: {CYAN}{Mass}kg{NORMAL}");
            Console.WriteLine($"Do {Name} like to sleep? {CYAN} {Sleep}{NORMAL}");

        }
    }

}
