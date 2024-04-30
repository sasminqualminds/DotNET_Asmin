using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class StackClass
    {
        Stack stack = new Stack();
        public void stackMethod()
        {
            // Stack
            Stack stack = new Stack();
            Console.WriteLine("Number of items u want to enter into stack");
            int c = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Stack:");

            for (int i = 0; i < c; i++)
            {
                Console.WriteLine($"enter your {i + 1} item ");
                string item = Console.ReadLine();
                stack.Push(item);
            }
            Console.WriteLine("Items in stacks");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Press 1 to pop or 2 to stop removing");

                
                if (stack.Count == 0)
                {
                    Console.WriteLine("stack is empty. Press 2 to stop.");
                    int stopOption = Convert.ToInt16(Console.ReadLine());
                    if (stopOption == 2)
                    {
                        break;
                    }
                    continue;
                }

                int dequeueOption = Convert.ToInt16(Console.ReadLine());

                if (dequeueOption == 1)
                {
                    stack.Pop();
                    Console.WriteLine("Element popped.");
                }
                else if (dequeueOption == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }


            Console.WriteLine("Items in stack after popping");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
