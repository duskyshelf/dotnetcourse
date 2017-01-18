using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExampleApp
{
    class Dog : Animal
    {
        private int legs = 4;

        public int Legs
        {
            get { return legs; }
            set { legs = value;  }
        }

        public override void Speak()
        {
            Console.WriteLine("I am a doggo");
            
            base.Speak();
        }

        public void DisplayNumberOfLegs()
        {
            Console.WriteLine("{0} has {1} leg(s)", Name, legs);
        }
    }
}
