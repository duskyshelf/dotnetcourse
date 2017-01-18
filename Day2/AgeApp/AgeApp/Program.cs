using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask for age
            Console.WriteLine("Age?");
            int age = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Name?");
            string name = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Gender? (Male/Female)");
            string gender = Console.ReadLine();

            Console.WriteLine();

            User user = new User(name, age, gender);

            user.AccessResponse();

            Console.ReadKey();
        }
    }
}
