using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GradeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // change the title
            Console.Title = "Grade App";

            //call the startApp method
            Program prog = new Program();

            prog.StartApp();

        }

        void StartApp()
        {
            //ask the user for his or her grade
            Console.WriteLine("What is your grade?");

            //save the grade
            string grade = Console.ReadLine();

            //create a new instance of the Grade class
            Grade grd = new Grade();

            //display
            Console.WriteLine("IfStatementExample = {0}", grd.IfStatementExample(grade));

            //line space
            Console.WriteLine();

            //display
            Console.WriteLine("SwitchStatementExample = {0}", grd.SwitchStatementExample(grade));

            //line space
            Console.WriteLine();

            //repeat
            StartApp();

        }
    }
}
