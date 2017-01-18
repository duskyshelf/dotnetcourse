using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameApp
{
    class Game
    {
        private Random random = new Random();
        public int number1;
        private int number2;
        public bool won;

        public void PlayRound()
        {
            number1 = random.Next(100);
            number2 = random.Next(100);
            Console.WriteLine("Here is a number: {0}", number1);
            Console.WriteLine("Do you think the next number will be higher or lower?");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("<Type H for higher and L for Lower>");
            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine().ToLower();
            won = Correct(response);
            if (won)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lose");
            }
            Console.WriteLine("The next number was {0}", number2);
            Console.WriteLine();
        }

        private bool Correct(string response)
        {
            if (number1 > number2)
            {
                return response == "l";
            }
            else
            {
                return response == "h";
            }
        }

        private string AskForHigherLower()
        {
            Console.WriteLine("<Type H for higher and L for Lower>");
            Console.ForegroundColor = ConsoleColor.White;
            string response = Console.ReadLine().ToLower();
            if (response == "h" || response == "l")
            {
                return response;
            }
            else
            {
                Console.WriteLine("Invalid input");
                AskForHigherLower();
            }
        }
    }
}
