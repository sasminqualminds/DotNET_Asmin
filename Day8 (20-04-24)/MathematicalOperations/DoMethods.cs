using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    internal class DoMethods<T>
    {
        OperationMethods<T> operation = new OperationMethods<T>();
        
        public void DoAdd()
        {
            Console.WriteLine("Enter the first number:");
            T first = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Enter the second number:");
            T second = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            operation.add(first, second);
        }
        
    }

}
