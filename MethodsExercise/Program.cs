namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favorite holiday:");
               string favHoliday = Console.ReadLine();
            Console.WriteLine("Enter a type of building:");
               string building = Console.ReadLine();
            Console.WriteLine("Enter your favorite animal:");
               string favAnimal = Console.ReadLine();
            Console.WriteLine("Enter a type of container:");
               string container = Console.ReadLine();
            Console.WriteLine("Enter the name of your favorite celebrity:");
               string favCelebrity = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine($"Twas the night before {favHoliday}, \n" +
                $"when all through the {building} not a creature was stirring, \n" +
                $"not even a {favAnimal}.  \n" +
                $"The {container}s were hung by the chimney with care \n" +
                $"in the hopes that {favCelebrity} soon would be there.");
        }
    }
}
