using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Employee app";

            Console.WriteLine("Employee 1");

            //create new Employee
            Employee emp1 = new Employee();

            emp1.name = "Natstar";
            emp1.age = 24;

            emp1.DisplayDetails();

            //delete instance
            emp1 = null;

            Console.WriteLine(); //linebreak
            
            Console.WriteLine("Employee 2");

            //create new Employee
            Employee emp2 = new Employee()
            {
                name = "Dusky",
                age = 30
            };

            emp2.DisplayDetails();

            //delete instance
            emp2 = null;

            Console.WriteLine(); //new line

            // Garbage Collection
            System.GC.Collect();

            Console.ReadKey();
        }
    }
}
