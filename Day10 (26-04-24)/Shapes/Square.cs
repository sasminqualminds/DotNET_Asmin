using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Square : Shapes
    {
        double side1;
        double side2;

        public Square(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        public override double area()
        {
            Console.WriteLine("Area of square");
            return side1*side2;
        }
        public override double perimeter()
        {
            Console.WriteLine("Perimeter of square");
            return 4*side1;
        }

    }
}
