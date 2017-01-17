using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAppExercise
{
    internal class Rectangle
    {
        private int length, width;

        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Area()
        {
            return length*width;
        }

        public int Perimeter()
        {
            return 2 * (length + width);
        }
    }
}
