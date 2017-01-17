using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapApp
{
    static class ExtensionClass
    {
        /// <summary>
        /// This is an extension method
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static int Add5ToThisVariable(this int x)
        {
            return  x + 5;
        }
    }
}
