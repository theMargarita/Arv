namespace Arv
{
    internal class Cow : Animal
    {
        public int Colours { get; set; } = 0;

        public void Colour(int colours)
        {
            //this.Colours = Colours;
            switch (Colours = colours)
            {
                case 1:
                    Console.WriteLine("The cow is brown");
                    break;
                case 2:
                    Console.WriteLine("The cow is black and white");
                    break;
                case 3:
                    Console.WriteLine("The cow is a rainbow");
                    break;
                case 4:
                    Console.WriteLine("The cows fur is pink");
                    break;
                default:
                    Console.WriteLine("The cow is a something");
                    break;
            }
        }
            public Cow(int mass, string species, string name, int age, int colour) : base(mass, species, name, age)
        {
            //the math is not completly corrct but almost
            Age = age;
            if (Age == 1)
            {
                Age = 14;
            }
            else if(Age == 2)
            {
                
                Age =  14 + 4;
            }
            else if (Age > 3)
            {
                Age = 14 + (4 * age);
            }
        }

        public override void Eating()
        {
            Console.WriteLine("The cow is Eating some fresh hay, nom nom");
        }
        public override void MakeSound()
        {
            Console.WriteLine("The cow goes *moooe*");
        }
        public override void VeryDangous(bool dangerous)
        {
            if(dangerous == true)
            {
                Console.WriteLine("Cows kills more humans than shark, so very dangerous");
            }
            else
            {
                Console.WriteLine("Very kind cow");
            }
        }
    }
}
