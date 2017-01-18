using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GuessGameApp
{
    static class SaveState
    {
        public static void Save(int lives)
        {
            System.IO.File.WriteAllText(@"C:\Files\dotnet\Day2\GuessGameApp\Save.txt", Convert.ToString(lives));
        }

        public static string LoadLives()
        {
            return System.IO.File.ReadAllText(@"C:\Files\dotnet\Day2\GuessGameApp\Save.txt");
        }
    }
}
