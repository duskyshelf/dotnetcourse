using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AgeApp
{
    class User
    {
        private int age;
        private string name, gender, title;
        public User(string name, int age, string gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender.ToLower();
            this.title = Title();
        }

        private string Title()
        {
            if (age < 18)
            {
                if (gender == "male")
                {
                    return "Master";
                }
                else if (gender == "female")
                {
                    return "Miss";
                }
            }
            else if (age >= 18)
            {
                if (gender == "male")
                {
                    return "Mr";
                }
                else if (gender == "female")
                {
                    return "Ms";
                }
            }

            return "Person";
        }

        private void Respond(string approval)
        {
            Console.WriteLine("Hello {0} {1}, {2}", title, name, approval);
        }

        public void AccessResponse()
        {
            const string ALLOWED_MSG = "you are allowed to enter";
            const string NOT_ALLOWED_MSG = "you are not allowed to enter";
            if (age < 18)
            {
                Respond(NOT_ALLOWED_MSG);
            }
            else if (age >= 18 && age <= 50)
            {
                if (gender == "male")
                {
                    Console.WriteLine("Do you wish to pay and display?");
                    string pay = Console.ReadLine().ToLower();
                    if (pay == "yes")
                    {
                        Respond(ALLOWED_MSG);
                    }
                    else if (pay == "no")
                    {
                        Console.WriteLine("Bye Mr {0}!!!", name);
                    }
;
                }
                else if (gender == "female")
                {
                    Respond(ALLOWED_MSG);
                }
            }
            else if (age > 50)
            {
                Respond(ALLOWED_MSG);
            }
        }
    }
}
