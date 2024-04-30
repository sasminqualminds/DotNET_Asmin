using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class QueueClass
    {
        Queue queue=new Queue();

        public void queueMethod()
        {
            //Queue
           
            Console.WriteLine("Queue");
            Console.WriteLine("Number of items u want Enqueue");
            int queueCount = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < queueCount; i++)
            {
                Console.WriteLine($"enter your {i + 1} item ");
                string item = Console.ReadLine();
                queue.Enqueue(item);
            }
            Console.WriteLine("Items in queue");

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();



            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Press 1 to dequeue or 2 to stop dequeueing");

                // Check if the queue is empty
                if (queue.Count == 0)
                {
                    Console.WriteLine("Queue is empty. Press 2 to stop.");
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
                    queue.Dequeue();
                    Console.WriteLine("Element dequeued.");
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


            Console.WriteLine("Items in queue after dequeue");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
    }
}
