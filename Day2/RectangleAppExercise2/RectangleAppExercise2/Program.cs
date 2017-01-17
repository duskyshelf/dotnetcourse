using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAppExercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.Width = 80;

            Console.WriteLine("Area = {0}", rect.Area());
            Console.WriteLine("Perimeter = {0}", rect.Perimeter());

            Console.ReadKey();
        }
    }
}
