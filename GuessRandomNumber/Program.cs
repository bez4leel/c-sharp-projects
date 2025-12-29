namespace GuessRandomNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool gameRunning = true;

            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 100);

            int tries = 3;

            while (gameRunning)
            {
                Console.Write($"Guess a number: ");
                string userInput = Console.ReadLine();
                int userGuess = 0;
                bool isNumber = int.TryParse(userInput, out userGuess);
                if (userGuess == randomNumber && isNumber)
                {
                    Console.WriteLine("Congratulations you guessed the right number!");
                    gameRunning = false;
                }
                else
                {
                    tries--;
                    Console.WriteLine($"Wrong you got {tries} more tries");
                }

                if (tries == 0)
                {
                    Console.WriteLine("Game over");
                    Console.Write("Retry? (Y/N) :");
                    string retry = Console.ReadLine();
                    if (retry == "Y" || retry == "y")
                    {
                        Console.Clear();
                        tries = 3;
                    }
                    else
                    {
                        gameRunning = false;
                    }
                }
            }
        }
    }
}
