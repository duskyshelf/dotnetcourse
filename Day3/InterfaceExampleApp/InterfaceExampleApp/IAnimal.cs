using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExampleApp
{
    interface IAnimal
    {
        string Name { get; set; }
        void Speak();

    }
}
