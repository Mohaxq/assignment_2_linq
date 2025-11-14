using DemoG01.Data;
using System;
using System.Collections.Generic;
using System.Xml.Linq;
using static DemoG01.Data.ListGenerator;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //part 1
            //1
            /*var result = ProductList.FirstOrDefault(p=> p.UnitsInStock == 0);
            Console.WriteLine(result);*/

            //2
            /*var result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            if(result == null)
            {
                Console.WriteLine("not found");
            }
            else
            {
                Console.WriteLine(result);
            }
            */

            //3
            /*int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Where(n => n > 5).ElementAt(3);
            Console.WriteLine(result);
            */

            //part 2
            //1
            /*int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Count(n => n % 2 != 0);
            Console.WriteLine(result);
            */

            //2
            /*var result = CustomerList.Select(c => new
            {
                c.CustomerID,
                c.CustomerName,
                OrderCount = c.Orders.Length
            });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //3
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    ProductCount = g.Count()
                });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //4
            /*int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = Arr.Sum();
            Console.WriteLine(result);
            */

            //5
            /*string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = words.Sum(w => w.Length);
            Console.WriteLine(result);
            */

            //6
            /*string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = words.Min(w => w.Length);
            
            Console.WriteLine(result);
            */

            //7
            /*string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = words.Max(w => w.Length);
            Console.WriteLine(result);
            */

            //8
            /*string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = words.Average(w => w.Length);
            Console.WriteLine(result);
            */

            //9
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
                });
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            */

            //10
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g => new
                {
                    Category = g.Key,
                    TotalUnitsInStock = g.Min(p => p.UnitPrice)
                });
            foreach (var item in result)
            {
                Console.WriteLine(item);

            }
            */

            //11
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g => 
                {
                    var minPrice = g.Min(p => p.UnitPrice);
                    return new
                    {
                        Category = g.Key,
                        CheapestProducts = g.Where(p => p.UnitPrice == minPrice)
                    };
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}");
                foreach (var product in item.CheapestProducts)
                {
                    Console.WriteLine($" {product}");
                }
            }
            */

            //12
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g =>
                {
                    var maxPrice = g.Max(p => p.UnitPrice);
                    return new
                    {
                        Category = g.Key,
                        maxproduct = g.Where(p => p.UnitPrice == maxPrice)
                    };
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}");
                foreach (var product in item.maxproduct)
                {
                    Console.WriteLine($" {product}");
                }
            }
            */

            //13
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g =>
                {
                    var maxPrice = g.Max(p => p.UnitPrice);
                    return new
                    {
                        Category = g.Key,
                        maxproduct = g.Where(p => p.UnitPrice == maxPrice)
                    };
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}");
                foreach (var product in item.maxproduct)
                {
                    Console.WriteLine($" {product}");
                }
            }
            */

            //14
            /*var result = ProductList.GroupBy(p => p.Category)
                .Select(g =>
                {
                    var avgPrice = g.Average(p => p.UnitPrice);
                    return new
                    {
                        Category = g.Key,
                        AvgPrice = avgPrice
                    };
                });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //part 3
            //1
            /*var result = ProductList.Select(c=>c.Category).Distinct();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //2
            /*var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);
            foreach (var letter in uniqueFirstLetters)
            {
                Console.WriteLine(letter);
            }
            */

            //3
            /*var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters);
            foreach (var letter in commonFirstLetters)
            {
                Console.WriteLine(letter);
            }
            */

            //4
            /*var productFirstLetters = ProductList.Select(p => p.ProductName[0]);
            var customerFirstLetters = CustomerList.Select(c => c.CustomerName[0]);
            var productOnlyFirstLetters = productFirstLetters.Except(customerFirstLetters);
            foreach (var letter in productOnlyFirstLetters)
            {
                Console.WriteLine(letter);
            }
            */

            //5


            //part 4
            //1
            /*var result = CustomerList.Where(c => c.City == "Washington").Take(3);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //2
            /*var result = CustomerList.Where(c => c.City == "Washington").Skip(2);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //3
            /*int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.TakeWhile((n, i) => n > i);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //4
            /*int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.TakeWhile(n => n % 3 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //5
            /*int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.SkipWhile((n, i) => n > i);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            */

            //part 5
            //1
            /*string[] words = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = words.Any(w => w.Contains("ei"));
            Console.WriteLine(result);
            */

            //2
            /*var result = ProductList.GroupBy(p => p.Category)
                .Where(g => g.Any(p => p.UnitsInStock == 0))
                .Select(g => new
                {
                    Category = g.Key,
                    Products = g.ToList()
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}");
                foreach (var product in item.Products)
                {
                    Console.WriteLine($" {product}");
                }
            }
            */

            //3
            /*var result = ProductList.GroupBy(g => g.Category).Where(g => g.All(p => p.UnitsInStock > 0))
                .Select(g => new
                {
                    Category = g.Key,
                    Products = g.ToList()
                });
            foreach (var item in result)
            {
                Console.WriteLine($"Category: {item.Category}");
                foreach (var product in item.Products)
                {
                    Console.WriteLine($" {product}");
                }
            }
            */

            //part 6
            //1
            /*List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            var result = numbers.GroupBy(n => n % 5).Select(c => new { r = c.Key, values = c.ToList() });
            foreach (var item in result)
            {
                Console.WriteLine($"Remainder: {item.r}");
                foreach (var value in item.values)
                {
                    Console.WriteLine($"{value}");
                }
            }
            */

            //2
            /*string[] f = System.IO.File.ReadAllLines("dictionary_english.txt");
            var result = f.GroupBy(c => c[0])
                .Select(g => new
                {
                    FirstLetter = g.Key,
                    Words = g.ToList()
                });
            foreach (var item in result)
            {
                Console.WriteLine($"First Letter: {item.FirstLetter}");
                foreach (var word in item.Words)
                {
                    Console.WriteLine($" {word}");
                }

            }
            */
        }
    }
}
