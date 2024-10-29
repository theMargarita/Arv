namespace Arv
{
    /* 
       klassen ska ha minst 3 metoder som djuren delar

        ska ha minst 3 olika djur
        dessa djur ska ha defaultvärden för egenskaperna, både de som sätts in i
        basklassen och subklass
        alla dur måste ha en medtod som heter makeSound() som prints out the sound
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
        public string Gender { get; set; }
        public int Age { get; set; }
        //private bool _dangerous { get; set; } = false;
        public bool Dangerous = false;

        public Animal(int mass, string species, string name, int age, string gender, bool dangerous)
        {
            Mass = mass;
            Age = age;
            Name = name;
            Gender = gender;
            Species = species;
            Dangerous = dangerous;
        }
        //method - print out the "sound"
        public virtual void makeSound()
        {
            Console.WriteLine("The animal goes *grrr*");
        }

        //method - how dangerous is the animal
        public virtual void veryDangous(bool dangerous)
        {
            Dangerous = dangerous;

            if (Dangerous == true)
            {
                Console.WriteLine("Very dangerous animal");
            }
            else
            {
                Console.WriteLine("More friendly");
            }
        }

        public virtual void eating()
        {
            Console.WriteLine("The animal is eating something.");
        }
    }

}
