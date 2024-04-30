using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicalOperations
{
    internal class OperationMethods<T>
    {

        public void add(T firstNumber, T secondNumber)
        {
            T result;

            if (typeof(T) == typeof(int))
            {               
                dynamic num1 = firstNumber;
                dynamic num2 = secondNumber;
                result = num1 + num2;
            }
            else if (typeof(T) == typeof(string))
            {
                
                result = (T)(object)(firstNumber.ToString() + secondNumber.ToString());
            }
            else
            {
                
                throw new NotSupportedException("Addition operation is not supported for type " + typeof(T).FullName);
            }

            Console.WriteLine("Result: " + result);
        }
        
      
    }
}
