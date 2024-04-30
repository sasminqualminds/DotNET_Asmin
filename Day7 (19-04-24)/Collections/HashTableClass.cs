using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class HashTableClass
    {
        Hashtable hashTable = new Hashtable();

        public void hashTableMethod()
        {
            // HashTable
            

            Console.WriteLine("Hash Table:");
            Console.WriteLine("Number of items u want to enter into hash table");
            int hashTableCount = Convert.ToInt16(Console.ReadLine());
            for (int i = 0; i < hashTableCount; i++)
            {
                Console.WriteLine($"enter your item number ");
                int key = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine($"enter your item ");
                string value = Console.ReadLine();
                hashTable.Add(key, value);
            }


            Console.WriteLine("Elements in HashTable:");
            foreach (DictionaryEntry entry in hashTable)
            {
                Console.WriteLine(entry.Key + ": " + entry.Value);
            }
            Console.WriteLine();


            ////creating a Hashtable using collection-initializer syntax
            //var fruits = new Hashtable() { { 1, "Apple" }, { 2, "Mango" } };

            //foreach (DictionaryEntry de in fruits)
            //    Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            //Console.WriteLine();



            bool loop = true;
            while (loop)
            {
                Console.WriteLine("Press 1 to remove an item or 2 to stop removing items");

                // Check if the hashtable is empty
                if (hashTable.Count == 0)
                {
                    Console.WriteLine("Hashtable is empty. Press 2 to stop.");
                    int stopOption = Convert.ToInt16(Console.ReadLine());
                    if (stopOption == 2)
                    {
                        break;
                    }
                    continue;
                }

                int removeOption = Convert.ToInt16(Console.ReadLine());

                if (removeOption == 1)
                {
                    Console.WriteLine("Enter the key of the item to remove:");
                    int keyToRemove = Convert.ToInt16(Console.ReadLine());
                   
                    if (hashTable.ContainsKey(keyToRemove))
                    {
                        hashTable.Remove(keyToRemove);
                        Console.WriteLine("Item removed.");
                    }
                    else
                    {
                        Console.WriteLine("Key not found.");
                    }
                }
                else if (removeOption == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid option.");
                }
            }
            foreach (DictionaryEntry de in hashTable)
                Console.WriteLine("Key: {0}, Value: {1}", de.Key, de.Value);
            Console.WriteLine();

        }
    }
}
