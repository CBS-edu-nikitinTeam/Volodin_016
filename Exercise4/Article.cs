using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4
{
    class Article
    {
        public string ProductName { get; private set; }
        public string StoreName { get; private set; }
        public decimal Price { get; private set; }
        public Article(string produictName, string storeName, decimal price)
        {
            ProductName = produictName;
            StoreName = storeName;
            Price = price;
        }

        public void Details()
        {
            Console.WriteLine($"Наименование: {ProductName}");
            Console.WriteLine($"Магазин: {StoreName}");
            Console.WriteLine($"Цена: {Price}");
        }
    }
}
