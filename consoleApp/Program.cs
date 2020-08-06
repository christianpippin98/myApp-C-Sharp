using System;

namespace Intro {
    public class Program {
        public static void Main (string[] args) {
            Random rnd = new Random ();
            int secretNumber = rnd.Next (1, 101);
            for (int i = 1; i < 5; i++) {
                Console.Write ("Guess a number from 1-100 ");
                int number = Convert.ToInt32 (Console.ReadLine ());
                int guesses = (4 - i);

                if (0 == guesses) {
                    Console.Write ("Sorry, that was not right! You have no guesses left!");
                } else if (number == secretNumber) {
                    Console.Write ("You Guessed Correctly!");
                    break;
                } else if (number > secretNumber) {
                    Console.Write ($"Sorry! That is not correct. Guess lower! You have {guesses} guess(es) remaining! ");
                } else if (number < secretNumber) {
                    Console.Write ($"Sorry! That is not correct. Guess higher! You have {guesses} guess(es) remaining! ");
                }
            }
        }
    }
}