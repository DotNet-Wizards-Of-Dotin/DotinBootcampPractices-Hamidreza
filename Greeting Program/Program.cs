namespace Greeting_Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Write Your FirstName : ");
            string firstName = Console.ReadLine();
            Console.Write("Please Write Your LastName : ");
            string lastName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{GreetingToUser.Abbreviation(firstName, lastName)}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            GreetingToUser.Greeting(firstName,lastName);


        }

    }
}
