namespace Create_a_Game___Guess_The_Number__
{
    class Program
    {
        private static int score = 0;
        private static int lives = 3;

        static void Main(string[] args)
        {
        GameStart:
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Please Choose The Game Mode :");
            Console.WriteLine("1- Simple   2- Normal   3- Hard");
            Console.ForegroundColor = ConsoleColor.White;

            int Modes;
            switch (Modes = Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Modes = 1;
                    Console.WriteLine("Simple Mode");
                    Console.WriteLine("Peek A Number Between 0 To 100");
                    if (Mode.SimpleMode())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BAREKALLAAAAHHHH YOU FOUND IT");
                        score += 10;
                        Console.WriteLine(score);
                        if (score % 50 == 0)
                        {
                            lives++;
                            Console.WriteLine($"You earned an extra life! Current lives: {lives}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, you lost a life!");
                        lives--;

                        if (lives <= 0)
                        {
                            Console.WriteLine("Game over. You're out of lives.");
                            break;
                        }

                        Console.WriteLine($"Remaining lives: {lives}");

                        if (AskToWatchAd())
                        {
                            goto GameStart; // Play again after watching an ad
                        }
                    }
                    break;

                case 2:
                    Modes = 2;
                    Console.WriteLine("Normal Mode");
                    Console.WriteLine("Peek A Number Between 0 To 200");
                    if (Mode.NormalMode())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BAREKALLAAAAHHHH YOU FOUND IT");
                        score += 10;
                        Console.WriteLine(score);
                        if (score % 50 == 0)
                        {
                            lives++;
                            Console.WriteLine($"You earned an extra life! Current lives: {lives}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, you lost a life!");
                        lives--;

                        if (lives <= 0)
                        {
                            Console.WriteLine("Game over. You're out of lives.");
                            break;
                        }

                        Console.WriteLine($"Remaining lives: {lives}");

                        if (AskToWatchAd())
                        {
                            goto GameStart; // Play again after watching an ad
                        }
                    }
                    break;

                case 3:
                    Modes = 3;
                    Console.WriteLine("Hard Mode");
                    Console.WriteLine("Peek A Number , THERE IS NO RANGE !!!");
                    if (Mode.HardMode())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("BAREKALLAAAAHHHH YOU FOUND IT");
                        score += 10;
                        Console.WriteLine(score);
                        if (score % 50 == 0)
                        {
                            lives++;
                            Console.WriteLine($"You earned an extra life! Current lives: {lives}");
                        }
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, you lost a life!");
                        lives--;

                        if (lives <= 0)
                        {
                            Console.WriteLine("Game over. You're out of lives.");
                            break;
                        }

                        Console.WriteLine($"Remaining lives: {lives}");

                        if (AskToWatchAd())
                        {
                            goto GameStart; // Play again after watching an ad
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Please Peek In Range");
                    break;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Mikhay Bazam Vaghteto Talaf Koni ? Y   N");
            string retry = Console.ReadLine().ToUpper();
            if (retry == "Y")
            {
                goto GameStart;
            }
            else
            {
                Console.ReadKey();
            }
        }

        private static bool AskToWatchAd()
        {
            Console.WriteLine("Do you want to watch an ad for an extra chance? Y/N");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }
    }

}
