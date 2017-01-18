using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Interface Example App";

            IAnimal dog = new Dog {Name = "Ruff"};

            dog.Speak();

            Console.ReadKey();
        }
    }
}
