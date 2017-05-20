using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithLinqExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Fun with Query Expressions ****\n");

            ProductInfo[] itemInStock = new[]{
                new ProductInfo{ Name="Mac's Coffee",
                    Description="Coffee with TEETH",
                    NumberInStock=24},
                new ProductInfo{ Name="Milk Maid Milk",
                    Description ="Milk cow's love",
                    NumberInStock = 100 },
                new ProductInfo{ Name="Pure Silk Tofu",
                    Description="Bland as Possible",
                    NumberInStock=120},
                new ProductInfo{ Name="Crunchy Pops",
                    Description="Cheezy pepppery goodness",
                    NumberInStock=2},
                new ProductInfo{ Name="RipOffWater",
                    Description="From the tap to your wallet",
                    NumberInStock=100},
                new ProductInfo{ Name="Classic Valpo Pizza",
                    Description="Everyone love pizza",
                    NumberInStock=73 }
            };
            //ListEverything(itemInStock);
            //ListProductNames(itemInStock);
            //GetOverStock(itemInStock);
            // GetNamesAndDescription(itemInStock);

            //foreach (var item in GetProjectedSubset(itemInStock))
            //{
            //    Console.WriteLine(item);
            //}

            //ReverseEverything(itemInStock);
            //AlphabetizeProductNames(itemInStock);
            //DisplayOff();
            //DisplayIntersection();
            AggregateOps();
            Console.Read();
        }

        static void ListEverything(ProductInfo[] products)
        {
            Console.WriteLine("All product details");

            var allProducts = from product in products select product;
            foreach (var item in allProducts)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static void ListProductNames(ProductInfo[] products)
        {
            //Now get only the naes of the products
            Console.WriteLine("Only product names:");
            var names = from product in products select product.Name;
            foreach (var item in names)
            {
                Console.WriteLine($"Name: {item}");
            }
        }

        static void GetOverStock(ProductInfo[] products)
        {
            Console.WriteLine("The overstock items");

            var overStock = from product in products where product.NumberInStock > 25 select product;

            foreach (var item in overStock)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }

        static void GetNamesAndDescription(ProductInfo[] products)
        {
            Console.WriteLine("Names and Descriptions:");
            var nameDesc = from product in products select new { product.Name, product.Description };

            foreach (var item in nameDesc)
            {
                Console.WriteLine(item.ToString());
            }
        }

        static Array GetProjectedSubset(ProductInfo[] products)
        {
            var nameDesc = from product in products select new { product.Name, product.Description };

            return nameDesc.ToArray();
        }

        static void GetCountFromQuery(ProductInfo[] products)
        {
            string[] currentVideoGames = {"Morrowind", "Uncharted 2","Fallout 3","Daxter","System Shock 2" };

            int numb = (from count in currentVideoGames where count.Length > 6 select count).Count();

            Console.WriteLine($"{numb} items honor the the LINQ query");
        }

        static void ReverseEverything(ProductInfo[] products) {
            Console.WriteLine("Products in reverse");
            var allProducts = from product in products select product;
            foreach (var item in allProducts.Reverse())
            {
                Console.WriteLine(item);
            }
        }

        static void AlphabetizeProductNames(ProductInfo[] products) {
            var subset = from product in products orderby product.Name select product;

            Console.WriteLine("Ordered by Name:");

            foreach (var item in subset)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayOff() {
            List<string> myCars = new List<string>{ "Yugo","Aztec","BMW"};
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from car in myCars select car).Except(from car1 in yourCars select car1);

            Console.WriteLine("Here is what you dont have, but I do:");
            foreach (string item in carDiff)
            {
                Console.WriteLine(item);
            }
        }
        static void DisplayIntersection()
        {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from car in myCars select car).Intersect(from car1 in yourCars select car1);

            Console.WriteLine("Here is what we have in common:");
            foreach (string item in carDiff)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayUnion() {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from car in myCars select car).Union(from car1 in yourCars select car1);

            Console.WriteLine("Here is everything");
            foreach (string item in carDiff)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayConcat() {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from car in myCars select car).Concat(from car1 in yourCars select car1);

            Console.WriteLine("Here are all our cars together:");
            foreach (string item in carDiff)
            {
                Console.WriteLine(item);
            }
        }

        static void DisplayConcastNoDups() {
            List<string> myCars = new List<string> { "Yugo", "Aztec", "BMW" };
            List<string> yourCars = new List<string> { "BMW", "Saab", "Aztec" };

            var carDiff = (from car in myCars select car).Concat(from car1 in yourCars select car1);

            Console.WriteLine("");
            foreach (string item in carDiff.Distinct())
            {
                Console.WriteLine(item);
            }
        }
        static void AggregateOps() {
            double[] winterTemps = {2.0,-21.3,8,-4,0,8.2 };

            //various aggregation examples
            Console.WriteLine($"Max temp: {(from temp in winterTemps select temp).Max()}");

            Console.WriteLine($"Min temp: { (from temp in winterTemps select temp).Min()}");

            Console.WriteLine($"Average temp: {(from temp in winterTemps select temp).Average()}");

            Console.WriteLine($"Sum temp: {(from temp in winterTemps select temp).Sum()}");
        }
    }
}
