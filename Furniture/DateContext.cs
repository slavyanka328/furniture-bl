using Furniture;

internal class DataContext
{
    public List<Product> Products;
    public List<Category> Categories;
    private int nextId;
    private int nextOrderNumber;

    public DataContext()
    {
        Products = new List<Product>();
        Categories = new List<Category>();
        nextId = 1;

        // Добавление категорий
        Categories.Add(new Category { Id = 1, Name = "Мебель" });
        Categories.Add(new Category { Id = 2, Name = "Декор" });
        Categories.Add(new Category { Id = 3, Name = "Текстиль" });

        // Пример добавления продуктов с категориями
        Products.Add(new Product { Id = nextId++, Name = "Шкаф", Price = 700, Category = Categories[0] });
        Products.Add(new Product { Id = nextId++, Name = "Стол", Price = 300, Category = Categories[0] });
        Products.Add(new Product { Id = nextId++, Name = "Стул", Price = 500, Category = Categories[0] });
    }

    public void DisplayMainMenu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=====================================");
            Console.WriteLine("          Главное меню");
            Console.WriteLine("=====================================");
            Console.WriteLine("1. Показать все продукты");
            Console.WriteLine("2. Добавить новый продукт");
            Console.WriteLine("3. Удалить продукт");
            Console.WriteLine("4. Показать категории");
            Console.WriteLine("5. Выход");
            Console.WriteLine("=====================================");
            Console.Write("Выберите опцию: ");

            string choice = Console.ReadLine();

            switch (choice)
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
                    DisplayCategories();
                    break;
                case "5":
                    return; // Выход из программы
                default:
                    Console.WriteLine("Некорректный выбор, попробуйте снова.");
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
                product.Print();
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
        Console.WriteLine("       Добавление нового продукта");
        Console.WriteLine("=====================================");

        Console.Write("Введите название продукта: ");
        string name = Console.ReadLine();

        Console.Write("Введите цену продукта: ");
        decimal price = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Выберите категорию:");
        for (int i = 0; i < Categories.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Categories[i].Name}");
        }

        int categoryChoice = int.Parse(Console.ReadLine());
        var selectedCategory = Categories[categoryChoice - 1];

        // Создание нового продукта
        Product newProduct = new Product
        {
            Id = nextId++, // Генерация нового уникального идентификатора
            Name = name,
            Price = price,
            Category = selectedCategory // Присоединение выбранной категории
        };

        // Добавление продукта в список
        Products.Add(newProduct);

        Console.WriteLine("Продукт добавлен. Нажмите любую клавишу для возврата в главное меню...");
        Console.ReadKey();
    }

    public void DeleteProduct()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("       Удаление продукта");
        Console.WriteLine("=====================================");

        Console.Write("Введите ID продукта для удаления: ");
        int idToDelete = int.Parse(Console.ReadLine());

        var productToRemove = Products.FirstOrDefault(p => p.Id == idToDelete);
        if (productToRemove != null)
        {
            Products.Remove(productToRemove);
            Console.WriteLine("Продукт удален. Нажмите любую клавишу для возврата в главное меню...");
        }
        else
        {
            Console.WriteLine("Продукт с таким ID не найден. Нажмите любую клавишу для возврата в главное меню...");
        }
        Console.ReadKey();
    }

    public void DisplayCategories()
    {
        Console.Clear();
        Console.WriteLine("=====================================");
        Console.WriteLine("          Список категорий");
        Console.WriteLine("=====================================");
        if (Categories.Count == 0)
        {
            Console.WriteLine("Нет доступных категорий.");
        }
        else
        {
            foreach (var category in Categories)
            {
                category.Print();
            }
        }
        Console.WriteLine("=====================================");
        Console.WriteLine("\nНажмите любую клавишу для возврата в главное меню...");
        Console.ReadKey();
    }
}
