namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal cat = new Cat(2, "Cat", "Fibie", 15, "Female");
            Console.WriteLine($"" +
                $"This is a {cat.Species} and is a {cat.Gender}." +
                $"\nThe {cat.Species}s name is {cat.Name} and is {cat.Age} years in {cat.Species} years and weighs {cat.Mass} kg.");
            cat.makeSound();

            Console.WriteLine();

           

            //wait before closing
            Console.ReadKey();
        }
    }
}
