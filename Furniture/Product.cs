using Furniture;

public class Product
{
    public int Id { get; set; } // Уникальный идентификатор
    public string Name { get; set; }
    public decimal Price { get; set; }
    public Category Category { get; set; } // Связь с категорией

    public void Print()
    {
        Console.WriteLine($"ID: {Id}, Название: {Name}, Цена: {Price}, Категория: {Category?.Name}");
    }
}
