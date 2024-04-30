using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : Shapes
    {
        double length;
        double breadth;

        public Rectangle(double length, double breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public override double area()
        {
            Console.WriteLine("Area of rectangle");
            return length*breadth;
        }

        public override double perimeter()
        {
            Console.WriteLine("Perimeter of rectangle");
            return 2*(length+breadth);
        }
    }
}
