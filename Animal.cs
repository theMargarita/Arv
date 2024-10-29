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
        //public bool Dangerous = false;

        public Animal(int mass, string species, string name, int age, string gender)
        {
            Mass = mass;
            Age = age;
            Name = name;
            Gender = gender;
            Species = species;
        }
        //method that print out the "sound"
        public virtual void makeSound()
        {
            Console.WriteLine($"The animal goes *grrr*");
        }

    }

}
