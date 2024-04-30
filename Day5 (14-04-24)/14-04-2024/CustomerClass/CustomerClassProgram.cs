namespace Day5
{
    internal class CustomerClassProgram
    {
        static void Main(string[] args)
        {
            CustomerClass customerClass = new CustomerClass("Jack", "2345677");
            CustomerClass customerClass1 = new CustomerClass("Bob", "555-1212");
            CustomerClass c = new CustomerClass("Bob", "555-1212");

            Console.WriteLine(customerClass.details());
            Console.WriteLine(customerClass1.details());
            Console.WriteLine(c.details());
        }
    }
}
