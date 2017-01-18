using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Abstract Example App";

            //create a new instance of Animal
            //Animal anim = new Animal();
            //you cannot create a new instance of an abstract class

            Dog doggy = new Dog() { Name = "Dusky" };

            doggy.Speak();

            Animal dog2 = new Dog() { Name = "Paul" };

            dog2.Speak();


            Console.ReadKey();

        }
    }
}
