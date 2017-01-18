using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    abstract class Animal : IAnimal
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public abstract void Speak();
    }
}
