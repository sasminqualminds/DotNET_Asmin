using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    // class that calculates area and circumference of a circle
    internal class OOP2
    {
        // field
        private double radius;
        
        // properties
        public double Radius
        {
            // retrieves radius
            get { return radius; }
            // assigning value to radius
            set { radius = value; }
        }

        // methods
        // to calculate area of circle
        public double Area()
        {
            double area=Math.PI * radius * radius;
            return area;
        }

        // to calculate circumference of a circle
        public double Circumference()
        {
            double circumference = Math.PI * radius * 2;
            return circumference;
        }

        static void Main(string[] args)
        {
            // Created an instance of the OOP2 class
            OOP2 oop2 = new OOP2();

            // Asking user to enter the radius of circle
            Console.WriteLine("Enter radius circle");

            // Entered value is converted into double and stored the value in "radius"
            double radius=Convert.ToDouble(Console.ReadLine());

            // the radius value is assigned to the property "Radius"
            oop2.Radius = radius;

            // Calling the "Area" method of the "oop2" and storing the value in "areaOfCircle"
            double areaOfCircle = oop2.Area();
            // Calling the "Circumference" method of the "oop2" and storing the value in circumferenceOfCircle
            double circumferenceOfCircle = oop2.Circumference();

            // displaying the output on the screen
            Console.WriteLine(areaOfCircle);
            Console.WriteLine(circumferenceOfCircle);

        }
    }
}
