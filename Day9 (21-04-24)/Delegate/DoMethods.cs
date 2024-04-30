using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Delegate.Program;

namespace Delegate
{
    internal class DoMethods
    {
        public delegate void ArithmeticHandler(int firstNumber, int secondNumber);
        Operations operations=new Operations();
        ArithmeticHandler arithObj1, arithObj2, arithObj3;

        
        public void addition()
        {
            Console.WriteLine("Enter your first num");
            int a2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b2 = Convert.ToInt16(Console.ReadLine());
            arithObj1 = new ArithmeticHandler(operations.Addition);
            arithObj1(a2, b2);
           

           
        }
        public void subtraction() {
            Console.WriteLine("Enter your first num");
            int a2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int b2 = Convert.ToInt16(Console.ReadLine());
            arithObj2 = new ArithmeticHandler(operations.Subtraction);
            arithObj2(a2, b2);
            
            
        }
        
    }
}
