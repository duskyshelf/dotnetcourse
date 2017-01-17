using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleAppExercise2
{
    class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>
        /// Return the area of the rectangle
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return length*width;
        }

        /// <summary>
        /// Return the perimeter of the rectangle
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 2*(length + width);
        }
    }
}
