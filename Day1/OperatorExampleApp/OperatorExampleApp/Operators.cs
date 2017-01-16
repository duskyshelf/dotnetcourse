using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExampleApp
{
    class Operators
    {
        //instance variables
        int a = 50;
        int b = 30;

        /// <summary>
        /// This is the Arithmetic operator
        /// </summary>
        public void Arithmetic()
        {
            Console.WriteLine("Arithmetic operators below...");

            //local variables
            int a = 10;
            int b = 20;

            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.WriteLine("(a + b) is {0}", (a + b));
            Console.WriteLine("(a - b) is {0}", (a - b));
            Console.WriteLine("(a * b) is {0}", (a * b));
            Console.WriteLine("(a / b) is {0}", (decimal)a/b);
            Console.WriteLine("(a Modulus b) is {0}", (a % b));

            Console.WriteLine();

            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.WriteLine("a++ is {0}", a++);
            Console.WriteLine("++b is {0}", ++b);
            Console.WriteLine("a is {0} and b is {1}", a, b);
            Console.WriteLine("a-- is {0}", a--);
            Console.WriteLine("--b is {0}", --b);
            Console.WriteLine("a is {0} and b is {1}", a, b);
        }

        public void Relational()
        {
            Console.WriteLine("Relational operators below...");
            Console.WriteLine("a is {0} and b is {1}", a, b);

            Console.WriteLine("(a > b) is {0}", (a > b));
            Console.WriteLine("(a < b) is {0}", (a < b));
            Console.WriteLine("(a >= b) is {0}", (a >= b));
            Console.WriteLine("(a <= b) is {0}", (a <= b));
            Console.WriteLine("(a == b) is {0}", (a == b));
            Console.WriteLine("(a != b) is {0}", (a != b));
        }

        public void Logical(bool a, bool b)
        {
            Console.WriteLine("Logical operators below...");
            Console.WriteLine("a is {0} and b is {1}", a, b);

            Console.WriteLine("(a && b) is {0}", (a && b));
            Console.WriteLine("(a || b) is {0}", (a || b));
            Console.WriteLine("(a ^ b) [XOR] is {0}", (a ^ b));
            Console.WriteLine("(!a) is {0}", !a);
        }

        /// <summary>
        /// This is the assignment operator
        /// </summary>
        public void Assigment()
        {
            Console.WriteLine("Assignment operators below...");

            int c = a + b;

            Console.WriteLine("a is {0} and b is {1} and c is {2}", a, b, c);

            c += a;
            Console.WriteLine("c += a is {0}", c);

            c -= a;
            Console.WriteLine("c -= a is {0}", c);

            c *= a;
            Console.WriteLine("c *= a is {0}", c);

            c /= a;
            Console.WriteLine("c /= a is {0}", c);

            c %= a;
            Console.WriteLine("c %= a is {0}", c);
        }
    }
}
