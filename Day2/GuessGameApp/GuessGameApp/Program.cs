using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //set title
            Console.Title = "Guess Game App";

            //opening message
            Console.WriteLine("Welcome to Guess Game App");
            Console.WriteLine("You will be given a number and asked to guess the next number");
            Console.WriteLine();

            User user = new User();
            Game game = new Game();

            StartApp(user, game);

            Console.ReadKey();


        }

        private static void StartApp(User user, Game game)
        {
            if (user.Dead())
            {
                Console.WriteLine();
                Console.WriteLine("You do not have any more lives, Life is 0");
                Console.WriteLine("Do you wish to play again? (Type Y for Yes and any key to exit)");
                
                string response = Console.ReadLine().ToLower();
                if (response == "y")
                {
                    user = new User();
                    Console.WriteLine();
                    StartApp(user, game);
                }
                else
                {
                    Environment.Exit(0);
                }
            }

            user.PrintLives();
            game.PlayRound();

            if (game.won)
            {
                user.IncrementLives();
            }
            else
            {
                user.DecrementLives();
            }

            StartApp(user, game);
        }
    }
}
