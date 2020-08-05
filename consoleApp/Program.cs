using System;

namespace Intro {
    public class Program {
        public static void Main (string[] args) {
            string secretNumber = ("65");
            for (int i = 1; i < 5; i++) {
                Console.Write ("Guess a number from 1-100 ");
                string number = Console.ReadLine ();
                int guesses = (4 - i);

                if (number == secretNumber) {
                    Console.Write ("You Guessed Correctly!");
                    break;
                } else {
                    Console.Write ($"Sorry! That is not correct. You have {guesses} guess(es) remaining! ");
                }
            }
        }
    }
}