using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayListClass arrayListClass = new ArrayListClass();
            arrayListClass.arrayListMethod();
            
            HashTableClass hashTableClass = new HashTableClass();
            hashTableClass.hashTableMethod();
           
            QueueClass queueClass = new QueueClass();
            queueClass.queueMethod();

            StackClass stackClass = new StackClass();
            stackClass.stackMethod();



            

        }
    }
}


