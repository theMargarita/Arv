namespace Arv
{
    class Dog : Animal
    {
        public bool personalPoopPlockare { get; set; } = true;
        public Dog(int mass, string species, string name, int age, bool ppp) : base(mass, species, name, age)
        {
            Age = age * 7;
        }

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
            Console.WriteLine("The dog goes *woof woof*");
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
                Console.WriteLine("\n*Dog goes grrr* \n" +
                    "If not friendly why friendly shaped");
            }
            else
            {
                Console.WriteLine("Very good doggo");
            }
        }

    }
}
