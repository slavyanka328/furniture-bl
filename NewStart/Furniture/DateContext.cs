using System;
using System.Collections.Generic;

namespace Furniture
{
    internal class DateContext
    {
        public List<Product> Products;
        private int nextId;

        public DateContext()
        {
            Products = new List<Product>();
            nextId = 1;
            Products.Add(new Product(nextId++, "Шкаф", 700));
            Products.Add(new Product(nextId++, "Стол", 300));
            Products.Add(new Product(nextId++, "Стул", 500));
        }

        public void DisplayMainMenu()
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=====================================");
                Console.WriteLine("           Главное меню");
                Console.WriteLine("=====================================");
                Console.WriteLine("1 - Показать все продукты");
                Console.WriteLine("2 - Добавить новый продукт");
                Console.WriteLine("3 - Удалить продукт по ID");
                Console.WriteLine("4 - Завершить работу");
                Console.WriteLine("=====================================");
                Console.Write("Выберите действие: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        DisplayProducts();
                        break;
                    case "2":
                        AddProduct();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Неверный ввод, попробуйте еще раз.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        public void DisplayProducts()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("          Список всех продуктов");
            Console.WriteLine("=====================================");
            if (Products.Count == 0)
            {
                Console.WriteLine("Нет доступных продуктов.");
            }
            else
            {
                foreach (var product in Products)
                {
                    Console.WriteLine($"ID: {product.Id} | Название: {product.Name} | Цена: {product.Price:C}");
                }
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("\nНажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }

        public void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("        Добавление нового продукта");
            Console.WriteLine("=====================================");

            Console.Write("Введите название продукта: ");
            string name = Console.ReadLine();

            decimal price;
            while (true)
            {
                Console.Write("Введите цену продукта: ");
                if (decimal.TryParse(Console.ReadLine(), out price) && price >= 0)
                {
                    break;
                }
                Console.WriteLine("Ошибка: цена должна быть числом больше или равной нулю.");
            }

            Products.Add(new Product(nextId++, name, price));
            Console.WriteLine("Продукт успешно добавлен!");
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }

        public void DeleteProduct()
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("           Удаление продукта");
            Console.WriteLine("=====================================");

            Console.Write("Введите ID продукта для удаления: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var productToRemove = Products.Find(p => p.Id == id);
                if (productToRemove != null)
                {
                    Products.Remove(productToRemove);
                    Console.WriteLine("Продукт успешно удален.");
                    ReassignProductIds();
                }
                else
                {
                    Console.WriteLine("Продукт с таким ID не найден.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: некорректный ввод ID.");
            }
            Console.WriteLine("Нажмите любую клавишу для возврата в главное меню...");
            Console.ReadKey();
        }

        private void ReassignProductIds()
        {
            int newId = 1;
            foreach (var product in Products)
            {
                product.Id = newId++;
            }
            nextId = newId;
        }

        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }

            public Product(int id, string name, decimal price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
        }
    }
}
