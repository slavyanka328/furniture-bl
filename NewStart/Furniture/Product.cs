using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }

        public Product(int id, string name, decimal price)
        {
            Id = id;
            Name = name;
            Price = price;
            Category = new Category(); // По умолчанию создаем пустую категорию
        }

        public void Print()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Название: {Name}");
            Console.WriteLine($"Цена: {Price:C}");
            Console.WriteLine("-------------------------");
        }
    }
}
