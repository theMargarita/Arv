namespace Arv
{
    class Cat : Animal
    {
        //default propertie
        //public int Sleep { get; set; } = 0;
        public Cat(int mass, string species, string name, int age, string sleep) : base(mass, species, name, age, sleep)
        {

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
                //24 + 4 x (Age - 2) == > 2 cat years
                int olderThanTwo = 24 + 4 * (Age - 2);
                Age = olderThanTwo;
            }

        }
        public void Sleepy(int sleepy)
        {
            //Sleep = sleep;
            if (sleepy == 0)
            {
                Console.WriteLine("The cat is running around in hyper mode");
            }
            //true = sleep
            else if (sleepy == 1)
            {
                Console.WriteLine("The cat is sleeping");
            }

        }


        //tries some variants of methods 
        public override void MakeSound() => Console.WriteLine("The cat goes *meow*");

        //Eating method
        public override void Eating() => Console.WriteLine("The cat is eatig a big fishy");

        //overrides method of dangerousness
        public override void VeryDangous(bool dangerous)
        {
            if (dangerous == true)
            {
                Console.WriteLine("Very dangerous kitty");
            }
            else if (dangerous == false)
            {
                Console.WriteLine("Lazy cat");
            }
        }

    }
    class Tiger : Cat
    {
        public Tiger(int mass, string species, string name, int age, string sleep) : base(mass, species, name, age, sleep)
        {
        }
    }
}