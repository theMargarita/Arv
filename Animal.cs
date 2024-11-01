namespace Arv
{
    /* 

        dessa djur ska ha defaultvärden för egenskaperna, både de som sätts in i
        basklassen och subklass
        alla dur måste ha en medtod som heter MakeSound() som prints out the sound
        det ska finnas en constructor som kan användas för att nskapa nya dur

        */
    internal class Animal
    {
        public int Mass { get; set; }
        public string Species { get; set; }
        //default 
        private string _name { get; set; } = "Unknown";
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age { get; set; }

        public Animal(int mass, string species, string name, int age)
        {
            this.Mass = mass;
            this.Age = age;
            Name = name;
            this.Species = species;
        }
        //method - print out the "sound"
        public virtual void MakeSound()
        {
            Console.WriteLine("The animal goes *grrr*");
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
