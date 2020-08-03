using System;

namespace Intro {
    public class Program {
        public static void Main (string[] args) {
            string secretNumber = ("6");
            Console.Write ("Guess a number from 1-10 ");
            string number = Console.ReadLine ();

            if (number == secretNumber) {
                Console.Write ("You Guessed Correctly!");
            } else {
                Console.Write ("Sorry! That is not correct. Guess again! ");
                string number2 = Console.ReadLine ();

                if (number2 == secretNumber) {
                    Console.Write ("You Guessed Correctly!");
                } else {
                    Console.Write ("Nope, again! ");
                    string number3 = Console.ReadLine ();

                    if (number3 == secretNumber) {
                        Console.Write ("You guessed correctly!");
                    } else {
                        Console.Write ("Sorry! Last guess! ");
                        string number4 = Console.ReadLine ();

                        if (number4 == secretNumber) {
                            Console.Write ("You guessed correctly!");
                        } else {
                            Console.Write ("Nope, you lost your chance!");
                        }
                    }
                }
            }
        }
    }
}