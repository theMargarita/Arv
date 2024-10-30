namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat(2, "Farmer cat", "Fibie", 15, true);
            Console.WriteLine($"This is a {cat.Species} and the {cat.Species}s name is {cat.Name} and is {cat.Age} years in {cat.Species} years and weighs {cat.Mass} kg.");
                
            cat.makeSound();
            cat.eating();
            cat.veryDangous(true);

            Console.WriteLine();

            Animal dog = new Dog(24, "Big fluffy Dog", "Soya", 7, true);
            Console.WriteLine($"This is {dog.Name}, he is a {dog.Species} and a " +
                $".\nHe is {dog.Age} years old in dog years and he weighs {dog.Mass} kg.");
            dog.makeSound();
            dog.eating();
            dog.veryDangous(true);


            //wait before closing
            Console.ReadKey();
        }
    }
}
