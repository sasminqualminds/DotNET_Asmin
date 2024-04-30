using System.Security.Cryptography.X509Certificates;

namespace Arrays
{
    internal class ArraysTypesProgram
    {

        public static void Main(string[] args)
        {
            /*----------- Single dimensional array --------------*/

            // Creating an array of size 4
            string[] fruits = new string[4];
            // Adding values to array
            fruits[0] = "Apple";
            fruits[1] = "Mango";
            fruits[2] = "Orange";
            fruits[3] = "Grapes";
            // printing the values of array
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

             // declaring the size of array with variable
             int sizeOfArray = 4;
             int[] numbers=new int[sizeOfArray];
             // adding values to it
             numbers[0] = 12;
             numbers[1] = 13;
             numbers[2] = 14;
             numbers[3] = 15;


            // creating an array by specifying size and adding value right away
            int[] id = new int[4] { 1, 2, 3, 4 };

            //creating an array without specifying size
            string[] weeks = new string[] { "Mon", "Tue", "Wed", "Thurs", "Fri", "Sat" };

            // creating an array without specifying size is not possible
            // string[] weeks = new string[]; // must have size or array initializer right away

            // creating an array without specifying size without new keyword is possible
            string[] months;
            months = ["Jan", "feb"];

            int[] marks = { 1, 2, 3, 4, 5, 6, };


            // 2D Arrays


            // indicates 4 rows and 4 columns
            int[,] num = new int[4, 4];

            // adding values right away
            int[,] nums = new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            // without new keyword
            int[,] ids = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 1, 2, 3, 4 } };

            // without specifying size
            int[,] ids1;
            ids1 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };

            for (int i = 0; i < ids1.GetLength(0); i++)
            {
                for (int j = 0; j < ids1.GetLength(1); j++)
                {
                    Console.Write(ids1[i, j] + " ");
                }
                Console.WriteLine();
            }


            /*  ------------ 3 Dimensional Arrays  -------------*/

            int[,,] threedArray = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } }, { { 7, 8, 9 }, { 10, 11, 12 } } };

            for (int i = 0; i < threedArray.GetLength(0); i++)
            {
                for (int j = 0; j < threedArray.GetLength(1); j++)
                {
                    for (int k = 0; k < threedArray.GetLength(2); k++)
                    {
                        Console.Write(threedArray[i, j, k] + " ");
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            /*  ------------- Jagged Arrays  ---------------*/
            //  column numbers are not fixed can vary on different rows

            int[][] jaggged = new int[2][];
            jaggged[0] = [1, 2,9,0,8];
            jaggged[1]=[4, 6] ;
            for(int i = 0;i< jaggged.Length; i++)
            {
                for(int j = 0;j< jaggged[i].Length; j++) { 
                    Console.Write(jaggged[i][j]+ " ");
                }
                Console.WriteLine();
            }

            


        }
    }
}
