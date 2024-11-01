namespace Arv
{
    internal class Cow : Animal
    {
        string NL = Environment.NewLine;
        string NORMAL = Console.IsOutputRedirected ? "" : "\x1b[39m";
        string YELLOW = Console.IsOutputRedirected ? "" : "\x1b[93m";
        public int Colours { get; set; } = 0;

        public Cow(int mass, string species, string _name, int age, int colours, string sleep) : 
            base(mass, species, _name, age, sleep)
        {
            //the math is not completly corrct but almost
            Age = age;
            if (Age == 1)
            {
                Age = 14;
            }
            else if (Age == 2)
            {

                Age = 14 + 4;
            }
            else if (Age > 3)
            {
                Age = 14 + (4 * age);
            }

            //scale of colour or something
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
        //method - eating
        public override void Eating()
        {
            Console.WriteLine("The cow is Eating some fresh hay, nom nom");
        }

        //method - sound
        public override void MakeSound()
        {
            Console.WriteLine($"The cow goes {YELLOW}*moooe*{NORMAL}");
        }

        //method - dangerous scale
        public override void VeryDangous(bool dangerous)
        {
            if (dangerous == true)
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
