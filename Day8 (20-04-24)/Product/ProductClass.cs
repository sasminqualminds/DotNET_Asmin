using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    internal class ProductClass<T>
    {
        public T ProdId { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Image { get; set; }

        public override string ToString()
        {
            return $"Product ID: {ProdId}, Description: {Description}, Price: {Price}, Image: {Image}";
        }
    }
}


