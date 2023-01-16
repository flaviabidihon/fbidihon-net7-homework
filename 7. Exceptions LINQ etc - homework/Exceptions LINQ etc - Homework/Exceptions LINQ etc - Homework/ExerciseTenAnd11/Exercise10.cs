using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions_LINQ_etc___Homework.Exercise10
{
    public static class ExerciseTenAnd11
    {
        public static void Run()
        {
            var products = new List<Product>
             {
             new Product("apple", "Category 1", 10),
             new Product("peach", "Category 2", 20),
             new Product("orange", "Category 1", 15),
             new Product("strawberry", "Category 3", 5),
             new Product("cherry", "Category 3", 5),
             };

            var byPrice = products.OrderBy(p => p.Price)
                .Select(p => new {Category = p.Category})
                .ToList(); 
            var byName = products.OrderBy(p => p.Name)
                .Select(p => new {Category = p.Category})
                .ToList();

            foreach(var product in byPrice)
                Console.WriteLine(product.Category);
            Console.WriteLine();
            foreach(var product in byName)
                Console.WriteLine(product.Category);

            Console.WriteLine();
            Console.WriteLine("------ EXERCISE 11 ------");
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }

        public Product(string name, string category, int price)
        {
            Name = name;
            Category = category;
            Price = price;
        }
    }
}
