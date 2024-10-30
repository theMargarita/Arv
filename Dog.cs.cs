namespace Arv
{
    class Dog : Animal
    {
        public Dog(int mass, string species, string name, int age, bool dangerous) : base(mass, species, name, age, dangerous)
        {
            Age = age * 7;
        }

        //method for woof
        public override void makeSound()
        {
            Console.WriteLine("The dog goes *Woof woof*");
        }
        //method for eating 
        public override void eating()
        {
            Console.WriteLine("The dog is eating juicy bone");
        }
        
        //method for dangerous
        public override void veryDangous(bool dangerous)
        {
            if (Dangerous == true)
            {
                Console.WriteLine("*Dog goes grrr* \n" +
                    "If not friendly why friendly shaped");
            }
            else
            {
                Console.WriteLine("Very good boy");
            }
        }

    }
}
