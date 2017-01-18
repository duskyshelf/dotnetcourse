using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("I am a dog and my name is {0}", name);
        }
    }
}
