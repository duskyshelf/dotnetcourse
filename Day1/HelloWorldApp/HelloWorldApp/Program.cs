using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldApp
{
    class Program
    {
        /*
        This is a multiline comment
        */
        //This is a single line comment
        static void Main(string[] args)
        {
            //change the title to Hello World App
            Console.Title = "Hello World App";

            ////change teh background colour of the text to red
            //Console.BackgroundColor = ConsoleColor.Red;

            ////change the text colour to black
            //Console.ForegroundColor = ConsoleColor.Black;

            ////make a sound for 5 sec
            //Console.Beep(262, 5000);

            //display Hello World
            Console.WriteLine("Hello World");

            int a = 10; //This is a variable

            //ask the user for his or her name
            Console.WriteLine("What is your name?");

            //save the user's response in a variable called name
            string name = Console.ReadLine();

            //display the name
            Console.WriteLine("Hello " + name + ", you have a great name!");

            //ask user for his or her age
            Console.WriteLine("What is your age?");

            //save the age as an Integer
            int age = Convert.ToInt16(Console.ReadLine());

            //display "Hello {name}, your age is {age} yr(s) old"
            Console.WriteLine("Hello {0}, your age is {1} yr(s) old", name, age);

            //Hold the screen
            Console.ReadKey();
        }
    }
}
