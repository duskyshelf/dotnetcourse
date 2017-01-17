using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SwapApp
{
    class Program
    {
        static void SwapByVal(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Inside SwapByVal a = {0}, b = {1}", a, b);
        }

        static void SwapByRef(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Inside SwapByRef a = {0}, b = {1}", a, b);
        }

        static void Add(int a, int b, out int c)
        {
            c = a + b;

            c += 100;
        }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Outside a = {0}, b = {1}", a, b);

            Console.WriteLine();

            SwapByVal(a, b);
            Console.WriteLine("Outside a = {0}, b = {1}", a, b);

            Console.WriteLine();

            SwapByRef(ref a, ref b);
            Console.WriteLine("Outside a = {0}, b = {1}", a, b);

            Console.WriteLine();

            int c = 0;

            Console.WriteLine("c is {0}", c);

            Add(a, b, out c);

            Console.WriteLine();

            Console.WriteLine("c is {0}", c);

            Console.WriteLine();

            Console.WriteLine("Before extension method, a is {0}", a);

            //call extension method
            a = a.Add5ToThisVariable();

            Console.WriteLine("After extension method, a is {0}", a);

            Console.ReadKey();

        }
    }
}
