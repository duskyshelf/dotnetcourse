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

                //create a pointer called c that points to the memory address of a

                int* c = &a;

                Console.WriteLine();

                Console.WriteLine("(int* c = &a) gives a = {0} and c = {1}", a, *c);
                Console.WriteLine("The memory address of a is {0}", (int)&a);
                Console.WriteLine("The memory address of c is {0}", (int)c);

                *c = 42;

                Console.WriteLine("(*c = 42) gives: a is {0} and c is {1}", a, *c);

                a = 70;

                //change the value of a to 70
                Console.WriteLine("(a = 70) gives: a is {0} and c is {1}", a, *c);

                int[] pop = {1, 2, 3};
                int pop2 = 5;

                fixed (int* h = pop) { }
                int* gg = &pop2;
            }

            Console.ReadKey();
        }
    }
}
