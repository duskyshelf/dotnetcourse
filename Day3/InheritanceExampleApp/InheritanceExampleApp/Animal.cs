using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleApp
{
    class Animal
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Speak()
        {
            Console.WriteLine("I am an animal");
            Console.WriteLine("My name is {0}", name);
        } 
    }
}
