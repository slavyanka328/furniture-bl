namespace Furniture
{
    public class Program
    {
        public static void Main()
        {
            //Category LDCP = new Category("аброкодабра");
            //LDCP.id = 1;
            //LDCP.Print();
            //Console.ReadLine();

            //Category fish = new Category();
            

            DateContext Context = new DateContext();
            //Context.Categories.Add(fish);
            //Context.Products.Add(new Product() { id = 1, name = "треска", price = 1100, category = fish });

            Context.DisplayMainMenu();

       





            /* int [] ar1 = new int[5];
             ar1[0] = 5;
             ar1[1] = 6;
             foreach (var i in ar1)
             {
                 Console.WriteLine(i);
             }

             Product[] ar2 = new Product[3];
             ar2[0] = new Product();
             ar2[1] = new Product();
             ar2[2] = new Product();

             ar2[0].id = 1;
             ar2[1].id = 2;
             ar2[2].id = 3;
             foreach (var i in ar2)
             {
                 Console.WriteLine(i.id);
             }
             List<Product> list = new List<Product>();
             for(int i = 0; i < 5; i++)
             {
                 list.Add(new Product());
                 list[i].id = i + 1;
             }

             foreach (var i in list)
             {
                 Console.WriteLine(i.id);
             } 

            List<Product> list = new List<Product>();
            Category cat = new Category();
            cat.id = 1;
            cat.name = "asf";

            for (int i = 0; i < 5; i++);
            {
                list.Add(new Product());
            }

            foreach (var i in list)
            {
                i.category = cat;
                Console.WriteLine(i.category.id);
                Console.WriteLine(i.category.name);

            }

            List<Product> list = new List<Product>();
            Category cat = new Category();
            cat.id = 1;
            cat.name = "asf";
            list.Add(new Product());

            foreach (var i in list)
            {
                i.category = cat;
                Console.WriteLine("Айди: " + i.category.id);
                Console.WriteLine("Название: " + i.category.name);

            }
            */

        }
    }
}