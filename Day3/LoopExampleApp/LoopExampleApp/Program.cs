using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace LoopExampleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //change the title
            Console.Title = "Loop Example App";

            //Array for population containing 5 elements
            int[] pop = new int[5]; //array of 5 elements

            //setting the values
            pop[0] = 211;
            pop[1] = 50;
            pop[2] = 317;
            pop[3] = 411;
            pop[4] = 100;

            //2nd way
            int[] pop2 = { 211, 50, 317, 411, 100 };

            //display the second element in each array
            Console.WriteLine("pop[1] = {0}, pop2[1] = {1}", pop[1], pop2[1]);

            Console.WriteLine();

            Console.WriteLine("For Loop Example....");

            //for (;;)
            //{
            //    Console.WriteLine("Endless Loop");
            //}

            for (int i = 0; i < pop.Length; i++)
            {
                Console.WriteLine("pop[{0}] is {1}", i, pop[i]);
            }

            //while (true)
            //{
            //    Console.WriteLine("Another Endless Loop");
            //}

            Console.WriteLine();

            int count = 0;

            Console.WriteLine("While Loop Example....");

            while (count < pop.Length)
            {
                Console.WriteLine("pop[{0}] is {1}", count, pop[count]);

                count++;
            }

            Console.WriteLine();

            //do
            //{
            //    Console.WriteLine("Endless Do While Loop Here");
            //} while (true);

            count = 0;

            Console.WriteLine("Do While Loop Example....");

            do
            {
                Console.WriteLine("pop[{0}] is {1}", count, pop[count]);

                count++;
            } while (count < pop.Length);

            Console.WriteLine();

            int max = pop[0];
            int min = pop[0];
            int total = pop[0];

            for (int i = 1; i < pop.Length; i++)
            {
                if (pop[i] > max)
                {
                    max = pop[i];
                }
                if (pop[i] < min)
                {
                    min = pop[i];
                }
                total += pop[i];
            }

            double average = (double)total/pop.Length;

            Console.WriteLine("Max is {0}", max);
            Console.WriteLine("Min is {0}", min);
            Console.WriteLine("Total is {0}", total);
            Console.WriteLine("Average is {0}", average);

            Console.WriteLine();

            Console.WriteLine("For Each Loop Example");

            foreach (int item in pop)
            {
                Console.WriteLine("Pop element is {0}", item);
            }

            Console.ReadKey();
        }
    }
}
