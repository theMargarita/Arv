namespace Arv
{
    class Dog : Animal
    {
        string NL = Environment.NewLine;
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        public bool personalPoopPlockare { get; set; } = true;
        public Dog(int mass, string species, string name, int age, bool ppp, string sleep) :
            base(mass, species, name, age, sleep)
        {
            Age = age * 7;
        }
        //method - ppp
        public void Poop(bool ppp)
        {
            personalPoopPlockare = ppp;
            if (ppp == false)
            {
                Console.WriteLine("This dog has sadly not a personal poop picker");
            }
            else
            {
                Console.WriteLine("This dog have a personal poop picker");
            }

        }

        //method for woof
        public override void MakeSound()
        {
            Console.WriteLine($"The dog goes {YELLOW}*woof woof*{NORMAL}");
        }

        //method for Eating 
        public override void Eating()
        {
            Console.WriteLine("The dog is Eating a juicy bone");
        }

        //method for dangerous
        public override void VeryDangous(bool dangerous)
        {
            if (dangerous == true)
            {
                Console.WriteLine("If not friendly why friendly shaped");
            }
            else
            {
                Console.WriteLine("Very good doggo");
            }
        }
        public override void ShowInfo()
        {
            base.ShowInfo();

        }

    }

}
