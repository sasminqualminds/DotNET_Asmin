using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class CircleClass
    {
        // field
        private double radius;

        // properties
        public double Radius
        {
            get { return radius; }     // retrieves radius
            set { radius = value; }    // assigning value to radius
        }

        // methods

        // to calculate area of circle
        public double Area()
        {
            double area = Math.PI * radius * radius;
            return area;
        }

        // to calculate circumference of a circle
        public double Circumference()
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }

    }
}
