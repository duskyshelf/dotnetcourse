using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointerExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Pointer Example App";

            int a = 20;
            int b = a;

            Console.WriteLine("(b=a) gives, a is {0} and b is {1}", a, b);

            b = 50;

            Console.WriteLine("(b=50) gives, a is {0} and b is {1}", a, b);

            Console.WriteLine();

            unsafe
            {
                Console.WriteLine("The memory address of a is {0}", (int)&a);
                Console.WriteLine("The memory address of b is {0}", (int)&b);
            }

            Console.ReadKey();

        }
    }
}
