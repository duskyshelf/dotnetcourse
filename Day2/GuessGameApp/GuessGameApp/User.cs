using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGameApp
{
    class User
    {
        private int lives = 3;

        public User()
        {
            lives = Convert.ToInt16(SaveState.LoadLives());
        }

        public void PrintLives()
        {
            Console.WriteLine("Life: {0}", lives);
        }

        public int Lives()
        {
            return lives;
        }

        public void DecrementLives()
        {
            lives--;
            SaveState.Save(lives);
        }

        public void IncrementLives()
        {
            lives++;
            SaveState.Save(lives);
        }

        public bool Alive()
        {
            return lives > 0;
        }
    }
}
