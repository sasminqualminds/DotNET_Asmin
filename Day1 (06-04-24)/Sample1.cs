
///<sample>
/// This program prints "Hello World" to the console
/// </sample>
namespace Day1
{
    ///<sample>
    /// defines a new class named Sample1
    ///</sample>
    internal class Sample1
    {
        static void Main(string[] args)         ///<sample> entry point of program </sample>
        {
            Console.WriteLine("Hello, World!"); ///<sample>
                                                /// uses "Console" class from System namespace 
                                                /// and prints "Hello World!"
                                                ///</sample>
            Console.ReadKey();
        }
    }
}
