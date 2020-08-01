using System;

namespace Intro
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string secretNumber = ("6");
            Console.Write("Guess a number from 1-10 ");
            string number = Console.ReadLine();

            if (number == secretNumber)
            {
            Console.Write("You Guessed Correctly!");
            }
            else
            {
            Console.Write("Sorry! That is not Correct.");
            }
        }
    }
}
