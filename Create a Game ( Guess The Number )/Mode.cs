namespace Create_a_Game___Guess_The_Number__
{
    public static class Mode
    {
        public static bool SimpleMode()
        {
            Random random = new Random();
            int value = random.Next(0, 100);
            int guess = 0;

            while (guess != value)
            {
                guess = GetPlayerGuess();
                if (guess < value)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Boro Bala Tar !");
                }
                else if (guess > value)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bia Paien Tar");
                }
            }

            return true;
        }

        public static bool NormalMode()
        {
            Random random = new Random();
            int value = random.Next(0, 200);
            int guess = 0;

            for (int i = 1; i <= 10; i++)
            {
                guess = GetPlayerGuess();
                if (guess == value)
                {
                    return true;
                }

                if (guess < value && i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Boro Bala Tar !");
                }
                else if (guess > value && i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bia Paien Tar");
                }
                else
                {
                    Console.WriteLine($"You used {i} of your 10 chances!");
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOUR TIME IS UPPPPP...");
            return false;
        }

        public static bool HardMode()
        {
            Random random = new Random();
            int value = random.Next();
            int guess = 0;

            for (int i = 1; i <= 10; i++)
            {
                guess = GetPlayerGuess();
                if (guess == value)
                {
                    return true;
                }

                if (guess < value && i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Boro Bala Tar !");
                }
                else if (guess > value && i < 10)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Bia Paien Tar");
                }
                else
                {
                    Console.WriteLine($"You used {i} of your 10 chances!");
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOUR TIME IS UPPPPP...");
            return false;
        }

        private static int GetPlayerGuess()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
    }

}
