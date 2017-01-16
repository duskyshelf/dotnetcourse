using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //change the title
            Console.Title = "Operator Example App";

            //create an instance of Operators
            Operators opera = new Operators();

            //call the arithmetic operator
            opera.Arithmetic();

            //line space
            Console.WriteLine();

            //call the relational method
            opera.Relational();

            //line space
            Console.WriteLine();

            //call the logical method
            opera.Logical(true, false); //positional argument
            opera.Logical(b: false, a: true); //named argument

            //line space
            Console.WriteLine();

            //call the relational method
            opera.Assigment();

            //hold screen
            Console.ReadKey();
        }
    }
}
