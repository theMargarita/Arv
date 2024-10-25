namespace Arv
{
    /* klassen ska ha minst 5 egenskaper (properties) som alla djur delar
       klassen ska ha minst 3 metoder som djuren delar

        ska ha minst 3 olika djur
        dessa djur ska ha defaultvärden för egenskaperna, både de som sätts in i
        basklassen och subklass
        alla dur måste ha en medtod som heter makeSound() som prints out the sound
        det ska finnas en constructor som kan användas för att nskapa nya dur

        */
    internal class Animal
    {
        public bool Fluffyness { get; set; }
        public string Moving { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
      

        //method that print out the "sound"
        public virtual void makeSound()
        {
            Console.WriteLine("The animal goes *grrr*");
        }

    }





    //class Cat : Animal
    //{
    //    public override void makeSound() => Console.WriteLine("The cat goes *meow*");

    //    public Cat(int age) : base(age)
    //    {
    //        Age = age;
    //        if (Age == 1)
    //        {
    //            //15 human years == 1 cat year
    //            Age = 15;
    //        }
    //        else if (Age == 2)
    //        {
    //            //15+9 human year == 2 cat years
    //            Age = 24;
    //            //Console.WriteLine(24);
    //        }
    //        else if (Age > 2)
    //        {
    //            //24 + 4 x (age - 2) == > 2 cat years
    //            int olderThanTwo = 24 + 4 * (Age - 2);
    //            Age = olderThanTwo;
    //        }
    //    }
    //}

    //class Dog : Animal
    //{
    //    public Dog(int age) : base(age)
    //    {
    //        Age = age * 7;
    //    }
    //    public override void makeSound()
    //    {
    //        Console.WriteLine("The dog goes *woof*");
    //    }
    //}
}
