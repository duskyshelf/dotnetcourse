using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapApp
{
    class Program
    {
        static void SwapByVal(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine("Inside a = {0}, b = {1}", a, b);
        }
        static void Main(string[] args)
        {
            int a = 1;\
            int b = 2;
            Console.WriteLine("Outside a = {0}, b = {1}", a, b);

            SwapByVal(ref a, ref b);
            Console.WriteLine();
            Console.WriteLine("Outside a = {0}, b = {1}", a, b);

            Console.ReadKey();

        }
    }
}
