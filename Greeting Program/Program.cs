namespace Greeting_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Write Your FirstName : ");
            string firstName = Console.ReadLine();
            Console.Write("Please Write Your LastName : ");
            string lastName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{Abbreviation(firstName, lastName)}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Greeting(firstName,lastName);


        }

        /// <summary>
        /// به هم چسباندن و بزرگ کردن حرف اول اسم 
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>

        public static string Abbreviation(string firstName, string lastName)
        {
            string firstNameAbbreviation = firstName.Substring(0, 1).ToUpper();
            string lastNameAbbreviation = lastName.Substring(0, 1).ToUpper();

            string abbreviation = $"Welcome {firstNameAbbreviation}.{lastNameAbbreviation}";

            return abbreviation;
        }


        /// <summary>
        /// خوش امد گویی بر طبق زمان روز
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public static string Greeting(string firstname, string lastname)
        {

            int hour = DateTime.Now.Hour;

            string greeting;

            if (hour >= 0 && hour < 12)
            {
                greeting = $"Good Morning''{firstname}''{lastname}";
            }
            else if (hour >= 12 && hour < 18)
            {
                greeting = $"Good Afternoon''{firstname}''{lastname}";
            }
            else
            {
                greeting = $"Good Evening''{firstname}''{lastname}";
            }

            return greeting;
        }
    }
}
