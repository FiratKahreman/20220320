using System.Collections.Generic;

namespace _02_HttpMethods.Models
{
    public static class ProductContext
    {
        static List<Product> products;

        static ProductContext()
        {
            products = new List<Product>();
            products.Add(new Product() { Id = 1, Name = "Laptop", Price = 12232, Stock = 100 });
            products.Add(new Product() { Id = 2, Name = "Mouse", Price = 353, Stock = 1000 });
            products.Add(new Product() { Id = 3, Name = "Telefon", Price = 5034, Stock = 500 });
        }

        public static List<Product> Products
        {
            get
            {
                return products;
            }
        }
    }
}
