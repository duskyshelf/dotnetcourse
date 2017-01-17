using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeApp
{
    class User
    {
        private int age;
        private string name, gender;
        public User(string name, int age, string gender)
        {
            this.age = age;
            this.name = name;
            this.gender = gender.ToLower();
        }

        public void AccessResponse()
        {
            if (age < 18)
            {
                if (gender == "male")
                {
                    Console.WriteLine("Hello Master {0}, you are not allowed to enter", name);
                }
                else if (gender == "female")
                {
                    Console.WriteLine("Hello Miss {0}, you are not allowed to enter", name);
                }
            }
            else if (age >= 18 && age <= 50)
            {
                if (gender == "male")
                {
                    Console.WriteLine("Do you wish to pay and display?");
                    string pay = Console.ReadLine().ToLower();
                    if (pay == "yes")
                    {
                        Console.WriteLine("Hello Mr {0}, you are allowed to enter", name);
                    }
                    else if (pay == "no")
                    {
                        Console.WriteLine("Bye Mr {0}!!!", name);
                    }
;
                }
                else if (gender == "female")
                {
                    Console.WriteLine("Hello Ms {0}, you allowed to enter", name);
                }
            }
            else if (age > 50)
            {
                if (gender == "male")
                {
                    Console.WriteLine("Hello Mr {0}, you allowed to enter", name);
                }
                else if (gender == "female")
                {
                    Console.WriteLine("Hello Ms {0}, you allowed to enter", name);
                }
            }
        }
    }
}
