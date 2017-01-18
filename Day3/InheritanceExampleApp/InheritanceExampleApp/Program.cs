using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Inheritance Example App";

            Console.WriteLine("Animal Example");

            Animal anim = new Animal() {Name = "Nattata"};

            anim.Speak();

            Console.WriteLine();

            Console.WriteLine("Dog Example");

            Dog doggo = new Dog() {Name = "Doge"};

            doggo.Speak();

            Console.WriteLine();

            Console.WriteLine("Cat Example");

            Cat neko = new Cat() {Name = "Batman"};

            neko.Speak();

            Console.WriteLine();

            CallSpeakMethod(anim);
            Console.WriteLine();
            CallSpeakMethod(doggo);
            Console.WriteLine();
            CallSpeakMethod(neko);

            Console.ReadKey();
        }

        static void CallSpeakMethod(Animal animal)
        {
            animal.Speak();

            if (animal is Dog)
            {
                ((Dog)animal).DisplayNumberOfLegs();
            }
        }
    }
}
