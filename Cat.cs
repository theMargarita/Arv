namespace Arv
{
    class Cat : Animal
    {
        public Cat(int mass, string species, string name, int age, string gender) : base(mass, species, name, age, gender)
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

        public override void makeSound() => Console.WriteLine("The cat goes *meow*");


    }
}