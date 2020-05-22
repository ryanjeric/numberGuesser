using System;
// Namespace
namespace numberGuesser
{
    // Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            // Console.Write("Write: ");
            // Console.WriteLine("Hello World!");
            // string name = "Sasa Meow";
            // int age = 50;
            // Console.WriteLine("Hey! " + name);
            // Console.WriteLine("{0} {1}",name,age);

            GetAppInfo(); // Run getappinfo
            GreetUser(); // ask user and greet

            while (true) { 
                // Init correct number
                Random random = new Random();
                int correctNumber = random.Next(1,11);

                // Init Guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");
            
                // While guess is not correct
                while(guess!=correctNumber) {
                    // Get Users input
                    string input = Console.ReadLine();

                    // Make Sure its a number
                    if (!int.TryParse(input, out guess)){
                        // Print err msg
                        PrintColorMessage(ConsoleColor.Red, "Please enter an actual number");
                        // keep going
                        continue;
                    }

                    // Cast to integer and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // tell user wrong number
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }
                }

                // tell user correct number
                PrintColorMessage(ConsoleColor.Yellow, "You are Correct");

                // ASK TO Play again
                Console.WriteLine("Play Again? [Y OR N]");
                // get answer
                string answer = Console.ReadLine().ToUpper();

                while(answer!="Y" && answer != "N")
                {
                    PrintColorMessage(ConsoleColor.Red, "Please type Y or N");
                    answer = Console.ReadLine().ToUpper();
                }
                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }

            }

        }

        // GET AND DISPLAY APP INFO
        static void GetAppInfo()
        {
            // SET APP VARS
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sasa Meow";

            // change text COLOR
            Console.ForegroundColor = ConsoleColor.Green;
            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();
        }
        // ASK USER NAME AND GREET
        static void GreetUser()
        {
            // Ask User name
            Console.WriteLine("What is your name?");
            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }
        // Print Color Message
        static void PrintColorMessage(ConsoleColor color,string message)
        {
            // change text COLOR
            Console.ForegroundColor = color;
            // tell user not a number
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
