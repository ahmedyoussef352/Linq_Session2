using ConsoleApp48.Sources;
using LinQ_Session1;

namespace Linq_Session2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = [1, 2, 3, 45, 6, 8];
            var result = arr.Take(3);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            var products = Source.ProductList;
            //var expensive = products
            //    .OrderByDescending(e => e.UnitPrice)
            //    .Take(5);
            //foreach (var item in expensive)
            //{
            //    Console.WriteLine(item);
            //}

            var querySyntax = (from p in products
                               orderby p.UnitPrice descending
                               select p).Take(3);

            //int[] arr2 = [1, 2, 3, 4, 5, 6];
            //var result2 = arr.Skip(3);
            //foreach (var item in result2)
            //{
            //    Console.WriteLine(item);
            //}
            //int pageSize = 10;
            //int pageNumber = 3;

            //var paginagion = products
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToList();

            //Console.WriteLine(products.Any());
            //var hasOutOfStock = products
            //   .Any(p => p.UnitPrice == 0);
            //Console.WriteLine(hasOutOfStock);


            var allResult = products
                .Where(p => p.Category.Equals("seafood", StringComparison.OrdinalIgnoreCase))
                .All(p => p.UnitsInStock == 0);
            // Console.WriteLine(allResult);

            var result2 = products
                .All(p => p.Category.Equals("seafood", StringComparison.OrdinalIgnoreCase) || p.UnitsInStock == 0);

            int[] ids = [1, 2, 3, 4, 5];
            var reslut = products
                .Where(p => ids.Contains(p.ProductID));

            var groupProduct = products
                .Where(p => p.UnitPrice > 0)
                .GroupBy(p => new
                {
                    Id = p.ProductID,
                    name = p.ProductName
                })
                ;
            //.Select(g => new
            //{
            //    CategoryName = g.Key,
            //    NumberOfProducts = g.Count()
            //});
            //foreach (var item in groupProduct)
            //{
            //    Console.WriteLine(item.Key);
            //}

            //var groupProduct2 = from p in products
            //                    group p by p.Category into g
            //                    select new
            //                    {
            //                        CategoryName = g.Key,
            //                        NumberOfProducts = g.Count()
            //                    };


            //Dictionary<int, string> dict1 = products
            //    .ToDictionary(p => p.ProductID, p => p.ProductName);

            //foreach (var item in groupProduct)
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine($"Category: {item.Key}"); // طباعة اسم التصنيف (المفتاح)

            //    foreach (var product in item)
            //    {
            //        Console.WriteLine($"  - {product.ProductName} ({product.UnitPrice})"); // طباعة منتجات هذا التصنيف
            //    }
            //}

            //Q1
            var p1 = products
                .OrderByDescending(p => p.UnitPrice)
                .Take(3);
            //foreach (var item in p1)
            //{
            //    Console.WriteLine(item);
            //}

            //Q2

            PaginatedResult<Product> result3 = GetProductPaginated(5, 2);
            //foreach (var item in result3.Items)
            //{
            //    Console.WriteLine(item);
            //}

            //Q3

            var p3 = products
                .OrderBy(p => p.UnitPrice)
                .TakeWhile(p => p.UnitPrice < 25);
            //foreach (var item in p3)
            //{
            //    Console.WriteLine(item);
            //}

            //Q4
            var p4 = products
                .Where(p => p.Category.Equals("Seafood", StringComparison.OrdinalIgnoreCase))
                .All(p => p.UnitsInStock > 0);
            //Console.WriteLine(p4);

            //Q5
            // Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };
            int[] ids2 = { 3, 9, 13, 18 };
            var p5 = ids2
                .Contains(9);
            //Console.WriteLine(p5);

            //Q6 Group all products by Category and print each group with its product count.
            var p6 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    group = g.Key,
                    Count = g.Count()
                });
            //foreach (var item in p6)
            //{
            //    Console.WriteLine(item.group);
            //    Console.WriteLine(item.Count);
            //}

            //Q7 Group products by Category and project only product names per group
            var p7 = products
                .GroupBy(p => p.Category)
                .Select(g => new
                {
                    group = g.Key,
                    Name = g.Select(p => p.ProductName)
                });


            //foreach (var item in p7)
            //{
            //    Console.WriteLine($"Category is :{item.group}");

            //    foreach (var name in item.Name)
            //    {
            //        Console.WriteLine(name);
            //    }
            //    Console.WriteLine("--------------------");
            //}

            //Q8 Find all categories that have MORE THAN 3 products
            var p8 = products
                .GroupBy(p => p.Category)
                .Select(
                g => new
                {
                    Key = g.Key,
                    Count = g.Count(),
                    productsMoreThan3 = g.Select(g => g.ProductName).Where(g => g.Count() > 3)
                });

            //foreach (var item in p8)
            //{
            //    Console.WriteLine($"{item.Key} : {item.Count}");

            //    foreach (var name in item.productsMoreThan3)
            //    {
            //        Console.WriteLine(name);
            //    }
            //    Console.WriteLine("--------------------");
            //}

            //Q9
            var customers = Source.CustomerList;
            var p9 = from c in customers
                     group c by c.Country into g
                     select new
                     {
                         country = g.Key,
                         CustomersCount = g.Count(),
                         TotalOrderValue = g.SelectMany(c => c.Orders).Sum(o => o.Total)
                     };

            //foreach (var item in p9)
            //{
            //    Console.WriteLine($"Country: {item.country} | Customers: {item.CustomersCount} | Total Orders Value: {item.TotalOrderValue:C}");
            //    Console.WriteLine("---------------------------------------------------");
            //}

            //Q10
            var p10 = products
                .Sum(p => p.UnitsInStock);
            //Console.WriteLine(p10);


            //Q11
            var MOSTEXPENSIVE = products
                .OrderByDescending(p => p.UnitPrice)
                .FirstOrDefault();
            //Console.WriteLine(MOSTEXPENSIVE);

            var CHEAPEST = products
                .OrderBy(p => p.UnitPrice)
                .FirstOrDefault();
            //Console.WriteLine(CHEAPEST);

            //Q12 Get a distinct list of all product categories
            var p12 = products
                .DistinctBy(p => p.Category);
            //foreach (var item in p12)
            //{
            //    Console.WriteLine(item);
            //}

            //Q13

            int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            int[] setB = { 3, 6, 9, 12, 15, 13 };

            var x = setA
                .Except(setB);
            //foreach (var item in x)
            //{
            //    Console.WriteLine(item);
            //}

            //Q14

            string[] list1 = { "Germany", "France", "UK", "Spain" };
            string[] list2 = { "france", "SPAIN", "Italy" };

            var u = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in u)
            //{
            //    Console.WriteLine(item);
            //}

            //Q15 Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            var D15 = new Dictionary<int, Product>();
            D15 = products
                .ToDictionary(p => p.ProductID);
            //if (D15.TryGetValue(18, out Product product18))
            //{
            //    // سيتم استدعاء دالة ToString تلقائياً أو يمكنك طباعة خصائصه
            //    Console.WriteLine(product18);
            //}
            //else
            //{
            //    Console.WriteLine("Product with ID = 18 was not found.");
            //}

            //Q16 Get the first product whose price is greater than $50.
            var p16 = products
                .FirstOrDefault(p => p.UnitPrice > 70);
            //Console.WriteLine(p16);

            //Q17 Try to get the first product with a price > $500. it returns null instead of throwing.
            var p17 = products
    .FirstOrDefault(p => p.UnitPrice > 500);
            // Console.WriteLine(p17);

            //Q18 Generate a multiplication table row for 7
            var table7 = Enumerable.Range(1, 10).Select(i => i * 7);
            //foreach (var num in table7)
            //{
            //    Console.Write($"{num} ");
            //}

            //Q19 Generate even numbers between 1 and 30.
            var evenNumber = Enumerable.Range(1, 30).Where(i => i % 2 == 0);
            //foreach (var num in evenNumber)
            //{
            //    Console.Write($"{num} ");
            //}

            //Q20 Concatenate the first 3 product names with the first 3 customer company names into a single sequence.

            var first3productnames = products
                .Select(p => p.ProductName)
                .Take(3);

            var first3customer = customers
                .Select(c => c.CompanyName)
                .Take(3);

            var mix = first3productnames
                .Concat(first3customer);

            //foreach (var item in mix)
            //{
            //    Console.Write(item);
            //}

            //Q21 Pair each product with a customer (by position) and produce a string "ProductName sold to CompanyName".
            var pairs = products
    .Zip(customers, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

            foreach (var item in pairs)
            {
                Console.WriteLine(item);
            }







        }
        public static PaginatedResult<Product> GetProductPaginated
            (int pageSize, int pageNumber)
        {
            var fullList = Source.ProductList;
            var data = fullList
                .OrderByDescending(p => p.UnitPrice)
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .ToList();
            return new PaginatedResult<Product>
            {
                Items = data,
                PageNumber = pageNumber,
                PageSize = pageSize,
                TotalCount = fullList.Count

            };
        }
    }

}
