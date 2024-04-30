using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    abstract class Shapes : IShape
    {
        
        public abstract double area();

        public abstract double perimeter();
        public void display()
        {
            Console.WriteLine("Calculating area and perimeter");
        }
    }
}
