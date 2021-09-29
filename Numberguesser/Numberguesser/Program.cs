using System;

namespace Numberguesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();
            GreetUser();

            

            while (true) {

                //int correctNumber = 7;

                Random random = new Random();

                init correctNumber = random.Next(1, 11);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        
                      
                        continue;
                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {


                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("You are CORRECT!!!);
    

                Console.ResetColor();

                Console.WriteLine("Play again [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {

                }
                else
                {
                    return;
                }
            }
        }
        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Marten";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        static void GreetUser()
        {
            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game..", inputName);
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            Console.WriteLine("Please enter an acutal number");

            Console.ResetColor();

        }
        //52:26
    }
}
