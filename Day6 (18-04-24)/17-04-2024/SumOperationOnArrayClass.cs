using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SumOperationOnArrayClass
    {
        // declaring array
        int[] sum;

        // constructor
        public SumOperationOnArrayClass(int[] sum)
        {
            this.sum = sum;
        }

        // method to calculate sum of elements in an array
        public int sumOfArray()
        {
            int j = 0;

            for (int i = 0; i < sum.Length; i++)
            {

                j = j + sum[i];

            }
            return j;

        }
    }
}
