using System;

namespace randomnumber.Models
{

    public class Game
    {
        //what data does game contain
        private int _secretNumber { get; set; }

        public int Guesses { get; set; }

        public bool Won { get; set; }

        public string Guess(int guess)
        {
            Guesses++;
            if (guess > _secretNumber)
            {
                return "Top high";
            }
            else if (guess < _secretNumber)
            {
                return "Too low";
            }
            Won = true;
            return "You got it!";
        }
        public Game()
        {
            Random rnd = new Random();
            _secretNumber = rnd.Next(1, 11);
            Won = false;
            Guesses = 0;
        }
    }
}