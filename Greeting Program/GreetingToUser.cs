namespace Greeting_Program
{
    public static class GreetingToUser
    {

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
        public static void Greeting(string firstname, string lastname)
        {

            int hour = DateTime.Now.Hour;

            string greeting;

            if (hour >= 0 && hour < 12)
            {
                Console.WriteLine($"Good Morning''{firstname}''{lastname}");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine($"Good Afternoon''{firstname}''{lastname}");

            }
            else
            {
                Console.WriteLine($"Good Evening''{firstname}''{lastname}");

            }

        }
    }
}
