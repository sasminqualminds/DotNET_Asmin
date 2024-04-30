using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ArrayListClass
    {
       ArrayList arrayList = new ArrayList();
        public void arrayListMethod()
        {

            Console.WriteLine("ArrayList:");
            Console.WriteLine("Number of items u want to enter into Array list");
            int arrayListCount = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < arrayListCount; i++)
            {
                Console.WriteLine($"enter your {i + 1} item ");
                string item = Console.ReadLine();
                arrayList.Add( item );
            }

            Console.WriteLine("Items in Array list");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }


        
    }
}
