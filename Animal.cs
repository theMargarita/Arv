namespace Arv
{
    internal class Animal
    {
        string NL = Environment.NewLine;
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";

        public int Mass { get; set; } = 23;
        public string Species { get; set; } = "Unknown";
        private string _name { get; set; } = "Unknown";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age { get; set; } = 0;
        public string Sleep { get; set; } = "Everyone needs sleep";

        public Animal(int mass, string species, string _name, int age, string sleep)
        {
            Mass = mass;
            Age = age;
            Name = _name;
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
            //this.dangerous = dangerous;

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
            Console.WriteLine("The animal is Eating something that is nom nom for the animal.");
        }
    }

}
