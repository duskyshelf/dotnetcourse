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
            StartApp();

            Console.ReadKey();
        }

        static void StartApp()
        {
            lblLength: //length label

            Console.WriteLine("Gimme a length in cm");

            double length = 0;
            double width = 0;

            try
            {
                length = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException fr)
            {
                //development
                //Console.WriteLine(fr.Message);

                //live system
                Console.WriteLine("Please enter only numbers for length e.g. 32.2");

                Console.WriteLine(); //line space

                goto lblLength;
                //throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Error 101");
            }

            lblWidth:

            Console.WriteLine("Gimme a width in cm");

            try
            {
                width = Convert.ToDouble(Console.ReadLine());
            }
            catch (FormatException fr)
            {
                //development
                //Console.WriteLine(fr.Message);

                //live system
                Console.WriteLine("Please enter only numbers for length e.g. 32.2");

                Console.WriteLine(); //line space

                goto lblWidth;
                //throw;
            }
            catch (Exception)
            {
                Console.WriteLine("Error 101");
            }

            Rectangle rec = new Rectangle { Length = length, Width = width };
            Rectangle rec2 = new Rectangle();

            Rectangle rec3 = new Rectangle();

            rec3.Area();
            
            Console.WriteLine("Area = {0}cm², Perimeter = {1}cm", rec.Area(), rec.Perimeter());

            StartApp();
        }
    }
}