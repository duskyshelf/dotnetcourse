using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAppExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gimme a length in cm");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gimme a width in cm");
            int width = Convert.ToInt32(Console.ReadLine());

            Rectangle rec = new Rectangle(length, width);

            Console.WriteLine("Area = {0}cm^2, Perimeter = {1}cm", rec.Area(), rec.Perimeter());

            Console.ReadKey();
        }
    }
}
