namespace Create_a_CSV_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> userDetailsList = new List<string>();
            List<int> womanAges = new List<int>();
            List<int> menAges = new List<int>();

            for (int i = 0; i < 3; i++)
            { 
                Console.WriteLine("HI, WELCOME ...");
                Console.Write($"User {i + 1}");
                Console.Write(" Please Write Your Name :");
                string? name = Console.ReadLine();
                Console.Write("Please Write Your Last Name :");
                string? lastName = Console.ReadLine();
                Console.Write("Please Write Your Age :");
                byte age = Convert.ToByte(Console.ReadLine());
                Console.Write("Please Write Yor Gender ('F' for female & 'M' for male): ");
                string gender = Convert.ToString(Console.ReadLine().ToUpper());
                
                string fullDetail = $"{name},{lastName},{age},{gender}";
                
                userDetailsList.Add(fullDetail);
                if (gender == "F") 
                { 
                    womanAges.Add(age);
                } else if (gender == "M")
                { 
                    menAges.Add(age); 
                } 
            }
            
            string getAllUsers = string.Join(";", userDetailsList);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(getAllUsers);
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("**************NOW**************");
            
            Double womanAverageAges = womanAges.Count > 0 ? womanAges.Average() : 0;
            Double menAverageAges = menAges.Count > 0 ? menAges.Average() : 0;
            
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"The AVERAGE ages of woman and men are :" +
                              $" Woman = {womanAverageAges} And Men = {menAverageAges}");
        }

    }
}
