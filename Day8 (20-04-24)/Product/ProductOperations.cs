using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class ProductOperations<T>
    {
        private List<ProductClass<T>> products = new List<ProductClass<T>>();

        public void add(ProductClass<T> product)
        {
            if (products.Exists(pro => pro.ProdId.Equals(product.ProdId)))
            {
                Console.WriteLine("Product with the same ID already exists. Please enter another ID.");
                return;
            }

            products.Add(product);
            Console.WriteLine("Product added successfully!");
        }

        public void Remove(ProductClass<T> product)
        {
            ProductClass<T> productToRemove = products.Find(pro => pro.ProdId.Equals(product.ProdId));
            if (productToRemove != null)
            {
                products.Remove(productToRemove);
                Console.WriteLine("Product removed successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {product.ProdId} not found.");
            }
        }

        public void Update(ProductClass<T> product)
        {
            ProductClass<T> productToUpdate = products.Find(pro => pro.ProdId.Equals(product.ProdId));
            if (productToUpdate != null)
            {
                productToUpdate.Description = product.Description;
                productToUpdate.Price = product.Price;
                productToUpdate.Image = product.Image;
                Console.WriteLine("Product updated successfully.");
            }
            else
            {
                Console.WriteLine($"Product with ID {product.ProdId} not found.");
            }
        }

        public void ListProduct(ProductClass<T> product)
        {
            ProductClass<T> productToDisplay = products.Find(pro => pro.ProdId.Equals(product.ProdId));
            if (productToDisplay != null)
            {
                Console.WriteLine("Product details:");
                Console.WriteLine(productToDisplay);
            }
            else
            {
                Console.WriteLine($"Product with ID {product.ProdId} not found.");
            }
        }

        public void ListAllProducts()
        {
            Console.WriteLine("\nAll Products:");
            if (products.Count == 0)
            {
                Console.WriteLine("No products found.");
            }
            else
            {
                foreach (var product in products)
                {
                    Console.WriteLine(product);
                }
            }
        }
    }
}

