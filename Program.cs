namespace Arv
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(2, "Farmer cat", "Fibie", 15, true);
            Console.WriteLine($"Name: {cat.Name}");
            Console.WriteLine($"Typ of cat: {cat.Species}");
            Console.WriteLine($"Cats Age in cat years: {cat.Age} years. (15 in human years)");
            Console.WriteLine($"Weight: {cat.Mass}kg");
            cat.Sleepy(true);
            cat.MakeSound();
            cat.Eating();
            cat.VeryDangous(false);

            Console.WriteLine("\n");
            //Console.ReadKey();


            Dog dog = new Dog(24, "Big fluffy Dog", "Soya", 7, true);
            Console.WriteLine($"Name: {dog.Name}");
            Console.WriteLine($"Typ of dog: {dog.Species}");
            Console.WriteLine($"Age in dog years: {dog.Age} (7 in human years)");
            Console.WriteLine($"Weight: {dog.Mass} kg");
            dog.MakeSound();
            dog.Eating();
            dog.VeryDangous(true);
            dog.Poop(true);

            Console.WriteLine("\n");

            Cow cow = new Cow(500, "Fluffy magic cow", "Ermintrude the Cow", 14, 3);
            Console.WriteLine($"Name: {cow.Name}");
            Console.WriteLine($"Type of cow: {cow.Species}");
            Console.WriteLine($"Age in cow years: {cow.Age} years. (54 in human years)");
            Console.WriteLine($"Weight: {cow.Mass} kg.");

            cow.MakeSound();
            cow.Eating();
            cow.VeryDangous(true);
            cow.Colour(5);





            //wait before closing
            Console.ReadKey();
        }
    }
}
