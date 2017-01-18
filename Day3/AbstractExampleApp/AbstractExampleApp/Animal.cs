using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleApp
{
    //Below is an abstract class
    //It cannot be instantiated
    abstract class Animal
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //an abstract method is a method with a method body and has the keyword abstract
        public abstract void Speak();
    }
}
