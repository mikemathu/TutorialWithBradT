//Namespace
namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
           GetAppInfo();

           GreetUser();

           while (true)
           { 
            //Int Correct Number
            //int correctNumber = 7;

            //Create a new random number
            Random random = new Random();

            //Int Correct Number
            int correctNumber = random.Next(1, 10);

            //In Guess Var
            int guess = 0;

            //Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            //While guess is not correct
            while(guess != correctNumber)
            {
                //Get user input
                string input = Console.ReadLine();

                //Mke sure it is a number
                if (!int.TryParse(input, out guess))
                {
                    PrintColorMessage(ConsoleColor.Red, "Enter an actual Number");

                    //Keep going
                    continue;
                }

                //Cast input to int and put in guess
                guess = Int32.Parse(input);
    
                //Match guess to croorect number
                if(guess != correctNumber)
                {                
                    PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                }             
            }      
                PrintColorMessage(ConsoleColor.Red, "You are CORRECT!!!");                

                //Ask to play again
                Console.WriteLine("Play Agin? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Mike Mathu";

            //Change Text Color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user Input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void PrintColorMessage(Console color, string message)
        {
            //Change Text Color
            Console.ForegroundColor = color;

            //Tell user its wrong number
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();
        }
    }
}