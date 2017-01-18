using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExampleApp
{
    class Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("WOOF WOOF WOOOF BARK {0}", name);
        }
    }
}
