namespace Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Square square = new Square(22,22);
            Rectangle rectangle = new Rectangle(12,4);
            square.display();
            Console.WriteLine(square.area());
            Console.WriteLine(square.perimeter());
            Console.WriteLine();
            rectangle.display();
            Console.WriteLine(rectangle.area());
            Console.WriteLine(rectangle.perimeter());

           
        }
    }
}
