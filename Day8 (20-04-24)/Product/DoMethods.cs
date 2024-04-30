using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class DoMethods<T>
    {
        ProductOperations<T> operations = new ProductOperations<T>();

        public void DoAdd()
        {
            ProductClass<T> product = new ProductClass<T>();

            Console.WriteLine("Enter product ID:");
            product.ProdId = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Enter product description:");
            product.Description = Console.ReadLine();

            Console.WriteLine("Enter product price:");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter product image URL:");
            product.Image = Console.ReadLine();

            operations.add(product);
        }

        public void DoRemove()
        {
            ProductClass<T> product = new ProductClass<T>();

            Console.WriteLine("Enter product ID to remove:");
            product.ProdId = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            operations.Remove(product);
        }

        public void DoUpdate()
        {
            ProductClass<T> product = new ProductClass<T>();

            Console.WriteLine("Enter product ID to update:");
            product.ProdId = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            Console.WriteLine("Enter updated product description:");
            product.Description = Console.ReadLine();

            Console.WriteLine("Enter updated product price:");
            product.Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter updated product image URL:");
            product.Image = Console.ReadLine();

            operations.Update(product);
        }

        public void DoListProduct()
        {
            ProductClass<T> product = new ProductClass<T>();

            Console.WriteLine("Enter product ID to view details:");
            product.ProdId = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));

            operations.ListProduct(product);
        }

        public void DoListAllProducts()
        {
            operations.ListAllProducts();
        }


    }
}



