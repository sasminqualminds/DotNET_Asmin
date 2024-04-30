namespace ExceptionalHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Division by zero exception
                int x = 10;
                int y = 0;
                int result = x / y;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            try
            {
                // Array index out of bounds exception
                int[] numbers = { 1, 2, 3 };
                int index = 10;
                int value = numbers[index];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            try
            {
                // Format exception
                string input = "abc";
                int number = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block executed.");
            }

            Console.ReadLine();
        }

      
}
}
