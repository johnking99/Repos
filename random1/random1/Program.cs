using System;

namespace random1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            rand.Next(1, 101);

            int randomnumber = rand.Next(1, 101);

            int userGuess = 0;
            
            while (randomnumber != 33)
            {
                Console.WriteLine("Guess a number between 1 and 100");
                string userGuessSTR = Console.ReadLine();
               bool isSuccess = int.TryParse(userGuessSTR, out userGuess);
                if (isSuccess == true)
                {

                    if (randomnumber > 33)
                    {
                        Console.WriteLine("Wrong.");
                    }
                    else if (randomnumber < 33)
                    {
                        Console.WriteLine("Wrong.");
                    }
                    else if (randomnumber != 33)
                    {
                        Console.WriteLine("You guessed correctly!");
                    }
                }
                else
                {
                    Console.WriteLine("Wrong.");
                }
            }
        }
    }
}
