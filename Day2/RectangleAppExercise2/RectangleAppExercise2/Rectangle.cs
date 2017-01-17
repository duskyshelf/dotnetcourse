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

        private double CalculateArea(double length, double width)
        {
            return length * width;
        }

        private double CalculatePerimeter(double length, double width)
        {
            return 2*(length + width);
        }

        /// <summary>
        /// Create rectangle
        /// </summary>
        /// <param name="length">The length of your rectangle</param>
        /// <param name="width">The width of your rectangle</param>
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public Rectangle()
        {
        }

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
            return CalculateArea(length, width);
        }

        /// <summary>
        /// Returns the area of the rectangle
        /// </summary>
        /// <param name="length">length of rectangle</param>
        /// <param name="width">width of rectangle</param>
        /// <returns></returns>
        public double Area(double length, double width)
        {
            return CalculateArea(length, width);
        }

        /// <summary>
        /// Return the perimeter of the rectangle
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return CalculatePerimeter(length, width);
        }

        public double Perimeter(double length, double perimeter)
        {
            return CalculatePerimeter(length, width);
        }
    }
}
