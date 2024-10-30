namespace Arv
{
    class Cat : Animal
    {
        public Cat(int mass, string species, string name, int age, bool dangerous) : base(mass, species, name, age, dangerous)
        {
            Age = age;

            if (Age == 1)
            {
                //15 human years == 1 cat year
                Age = 15;
            }
            else if (Age == 2)
            {
                //15+9 human year == 2 cat years
                Age = 24;
                //Console.WriteLine(24);
            }
            else if (Age > 2)
            {
                //24 + 4 x (age - 2) == > 2 cat years
                int olderThanTwo = 24 + 4 * (Age - 2);
                Age = olderThanTwo;
            }
        }

        //tries some variants of methods 
        public override void makeSound() => Console.WriteLine("The cat goes *meow*");

        //overrides method of dangerousness
        public override void veryDangous(bool dangerous)
        {
            if (Dangerous == true)
            {
                Console.WriteLine("Very dangerous kitty");
            }
            else if (Dangerous == false)
            {
                Console.WriteLine("Lazy cat");
            }
        }

        //eating method
        public override void eating()
        {
            Console.WriteLine("The cat is eatig a big fishy");
        }
    }
}