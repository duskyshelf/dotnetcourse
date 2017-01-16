using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        public string name;
        public int age;

        public static int employeeID = 0;

        //constructor
        public Employee()
        {
            Console.WriteLine("Inside Constructor");

            employeeID++;
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("Inside {0}'s Destructor", name);
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee's name is {0}", name);
            Console.WriteLine("Employee's age is {0}", age);

            Console.WriteLine("Employee's ID is {0}", employeeID);
        }
    }
}
