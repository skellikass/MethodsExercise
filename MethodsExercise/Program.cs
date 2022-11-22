namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Console.WriteLine("Exercise 1");
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
            Console.WriteLine("Click Enter to see your story!");
            Console.ReadLine();
            Console.WriteLine($"Twas the night before {favHoliday}, \n" +
                $"when all through the {building} not a creature was stirring, \n" +
                $"not even a {favAnimal}.  \n" +
                $"The {container}s were hung by the chimney with care \n" +
                $"in the hopes that {favCelebrity} soon would be there.");
            Console.WriteLine("");

            Console.WriteLine("Click Enter for Exercise 2");
            Console.ReadLine();

            //Exercise 2
            Console.WriteLine("Exercise 2");

            Methods.Add(1,3);
            int addAnswer = Methods.Add(1,3);
            Console.WriteLine(addAnswer);
            
            Methods.Subtract(3,1);
            int subAnswer = Methods.Subtract(3,1);
            Console.WriteLine(subAnswer);

            Methods.Divide(10,5);
            int divAnswer = Methods.Divide(10,5);
            Console.WriteLine(divAnswer);

            Methods.Multiply(7,3);
            int multAnswer = Methods.Multiply(7, 3);
            Console.WriteLine(multAnswer);

            Methods.Modulus(2,9);
            int modAnswer = Methods.Modulus(2,9);
            Console.WriteLine(modAnswer);
        }
    }
}
