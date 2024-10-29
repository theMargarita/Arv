namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat(2, "Farmer Cat", "Fibie", 15, "Female", true);
            Console.WriteLine($"" +
                $"This is a {cat.Species} and is a {cat.Gender}." +
                $"\nThe {cat.Species}s name is {cat.Name} and is {cat.Age} years in {cat.Species} years and weighs {cat.Mass} kg.");
            cat.makeSound();
            cat.eating();
            cat.veryDangous(true);

            Console.WriteLine();

            Animal dog = new Dog(24, "Big fluffy Dog", "Soya", 7, "Male", true);
            Console.WriteLine($"This is {dog.Name}, he is a {dog.Species} and a " +
                $"{dog.Gender}.\nHe is {dog.Age} years old in dog years and he weighs {dog.Mass} kg.");
            dog.makeSound();
            dog.eating();
            dog.veryDangous(true);


            //wait before closing
            Console.ReadKey();
        }
    }
}
