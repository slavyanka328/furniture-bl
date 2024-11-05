using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Furniture
{
 
    public class Category
      public List<Category> Categorys;
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public Category()
        {
            Categorys = new List<Category>();
            Categorys.Add(new Category( 1, "мебель"));

        }

        public void Print()
        {
            Console.WriteLine($"ID категории: {Id}, Название категории: {Name}");
        }
    }

}
