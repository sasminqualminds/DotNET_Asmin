namespace Day4
{
    internal class Circle
    {
       
        static void Main(string[] args)
        {
            
            CircleClass circleClass = new CircleClass();          // Created an instance of the OOP2 class
            
            Console.WriteLine("Enter radius circle");             // Asking user to enter the radius of circle
            
            double radius = Convert.ToDouble(Console.ReadLine()); // Entered value is converted into double and stored the value in "radius"
           
            circleClass.Radius = radius;                          // the radius value is assigned to the property "Radius"
            
            double areaOfCircle = circleClass.Area();             // Calling the "Area" method of the "oop2" and storing the value in "areaOfCircle"
           
            double circumferenceOfCircle = circleClass.Circumference();  // Calling the "Circumference" method of the "oop2" and storing the value in circumferenceOfCircle

            // displaying the output on the screen
            Console.WriteLine(areaOfCircle);
            Console.WriteLine(circumferenceOfCircle);

        }



        
    }
}
