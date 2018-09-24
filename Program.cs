using System;
using System.Text;
using randomnumber.Models;

namespace randomnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("NUMBA GAME TIME");

            Game game = new Game();
            bool playing = true;
            while (playing)
            {
                System.Console.WriteLine("Guess a number, 1 - 10");
                string guessString = Console.ReadLine();
                int guess;
                if (!Int32.TryParse(guessString, out guess))
                {
                    Console.WriteLine("Not a good number, try again");
                    game.Guesses++;
                    continue;
                }
                string result = game.Guess(guess);
                Console.WriteLine(result);
                if (game.Won)
                {
                    Console.WriteLine("Great job, wnat to play again? (Y/N)");
                    string again = Console.ReadLine();
                    if (again.Length > 0 && again.ToLower()[0] == 'n')
                    {
                        playing = false;
                    }
                    else
                    {
                        game = new Game();
                    }
                }
            }
        }
    }
}

//  Random random = new Random();
//             bool playing = true;
//             Console.WriteLine("Pick a number, 1 - 10");
//             while (playing)
//             {
//                 int number = random.Next(1, 11);
//                 int PlayerChoice = Int32.Parse(Console.ReadLine());
//                 if (PlayerChoice == number)
//                 {
//                     Console.WriteLine($"You guessed correctly! Computer chose {number} Play Again? (Y/N)");
//                     string response = Console.ReadLine();
//                     if (response.ToUpper() != "Y")
//                     {
//                         playing = false;
//                     }
//                 }
//                 else
//                 {
//                     if (PlayerChoice > number)
//                     {
//                         Console.WriteLine("Too high, guess lower...");
//                         int response = PlayerChoice;
//                     }
//                     if (PlayerChoice < number)
//                     {
//                         Console.WriteLine("Too low, guess again...");
//                         int response = PlayerChoice;
//                     }
//                 }
//             }