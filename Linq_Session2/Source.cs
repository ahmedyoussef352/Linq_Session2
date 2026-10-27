using LinQ_Session1;

namespace ConsoleApp48.Sources;

public static class Source
{
    public static List<Product> ProductList = new List<Product>()
    {
        new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
            new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
            new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
            new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35m, UnitsInStock = 0 },
            new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.00m, UnitsInStock = 120 },
            new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.00m, UnitsInStock = 15 },
            new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.00m, UnitsInStock = 6 },
            new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.00m, UnitsInStock = 29 },
            new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 },
            new Product { ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.00m, UnitsInStock = 22 },
            new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products", UnitPrice = 38.00m, UnitsInStock = 86 },
            new Product { ProductID = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00m, UnitsInStock = 24 },
            new Product { ProductID = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
            new Product { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.50m, UnitsInStock = 39 },
            new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45m, UnitsInStock = 29 },
            new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.00m, UnitsInStock = 0 },
            new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50m, UnitsInStock = 42 },
            new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections", UnitPrice = 9.20m, UnitsInStock = 25 },
            new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.00m, UnitsInStock = 40 },
            new Product { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.00m, UnitsInStock = 3 },
            new Product { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals", UnitPrice = 21.00m, UnitsInStock = 104 },
            new Product { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals", UnitPrice = 9.00m, UnitsInStock = 61 },
            new Product { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.50m, UnitsInStock = 20 },
            new Product { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections", UnitPrice = 14.00m, UnitsInStock = 76 },
            new Product { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections", UnitPrice = 31.23m, UnitsInStock = 15 },
            new Product { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.90m, UnitsInStock = 49 },
            new Product { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce", UnitPrice = 45.60m, UnitsInStock = 26 },
            new Product { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry", UnitPrice = 123.79m, UnitsInStock = 0 },
            new Product { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.89m, UnitsInStock = 10 },
            new Product { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.50m, UnitsInStock = 0 },
            new Product { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products", UnitPrice = 32.00m, UnitsInStock = 9 },
            new Product { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.50m, UnitsInStock = 112 },
            new Product { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.00m, UnitsInStock = 111 },
            new Product { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 20 },
            new Product { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.00m, UnitsInStock = 112 },
            new Product { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.00m, UnitsInStock = 11 },
            new Product { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.50m, UnitsInStock = 17 },
            new Product { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 69 },
            new Product { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.40m, UnitsInStock = 123 },
            new Product { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood", UnitPrice = 9.65m, UnitsInStock = 85 },
            new Product { ProductID = 42, ProductName = "Singapore Lean Peppered Snail", Category = "Seafood", UnitPrice = 14.00m, UnitsInStock = 26 },
            new Product { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.00m, UnitsInStock = 17 },
            new Product { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.45m, UnitsInStock = 27 },
            new Product { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.50m, UnitsInStock = 5 },
            new Product { ProductID = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.00m, UnitsInStock = 95 },
            new Product { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.50m, UnitsInStock = 36 },
            new Product { ProductID = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.75m, UnitsInStock = 15 },
            new Product { ProductID = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.00m, UnitsInStock = 10 },
            new Product { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.25m, UnitsInStock = 65 },
            new Product { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.00m, UnitsInStock = 20 },
            new Product { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.00m, UnitsInStock = 38 },
            new Product { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.80m, UnitsInStock = 0 },
            new Product { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry", UnitPrice = 7.45m, UnitsInStock = 21 },
            new Product { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry", UnitPrice = 24.00m, UnitsInStock = 115 },
            new Product { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals", UnitPrice = 38.00m, UnitsInStock = 21 },
            new Product { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.50m, UnitsInStock = 36 },
            new Product { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.25m, UnitsInStock = 62 },
            new Product { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products", UnitPrice = 55.00m, UnitsInStock = 79 },
            new Product { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products", UnitPrice = 34.00m, UnitsInStock = 19 },
            new Product { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.50m, UnitsInStock = 113 },
            new Product { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.30m, UnitsInStock = 17 },
            new Product { ProductID = 63, ProductName = "Vegie-spread", Category = "Produce", UnitPrice = 43.90m, UnitsInStock = 24 },
            new Product { ProductID = 64, ProductName = "Wimmer gut Schwarzwälder Schinken", Category = "Meat/Poultry", UnitPrice = 33.25m, UnitsInStock = 22 },
            new Product { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments", UnitPrice = 21.05m, UnitsInStock = 76 },
            new Product { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments", UnitPrice = 17.00m, UnitsInStock = 4 },
            new Product { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages", UnitPrice = 14.00m, UnitsInStock = 52 },
            new Product { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.50m, UnitsInStock = 6 },
            new Product { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.00m, UnitsInStock = 26 },
            new Product { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.00m, UnitsInStock = 15 },
            new Product { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.50m, UnitsInStock = 26 },
            new Product { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products", UnitPrice = 34.80m, UnitsInStock = 14 },
            new Product { ProductID = 73, ProductName = "Röd Kaviare", Category = "Seafood", UnitPrice = 15.00m, UnitsInStock = 101 },
            new Product { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.00m, UnitsInStock = 4 },
            new Product { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.75m, UnitsInStock = 125 },
            new Product { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 57 },
            new Product { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments", UnitPrice = 13.00m, UnitsInStock = 32 }
    };

    public static List<Customer> CustomerList = new List<Customer>()
        {
            new Customer
            {
                CustomerID = "ALFKI",
                CompanyName = "Alfreds Futterkiste",
                Address = "Obere Str. 57",
                City = "Berlin",
                Region = null,
                PostalCode = "12209",
                Country = "Germany",
                Phone = "030-0074321",
                Orders = new Order[]
                {
                    new Order { OrderID = 10643, OrderDate = new DateTime(1997, 8, 25), Total = 814.50m },
                    new Order { OrderID = 10692, OrderDate = new DateTime(1997, 10, 3), Total = 878.00m },
                    new Order { OrderID = 10702, OrderDate = new DateTime(1997, 10, 13), Total = 330.00m },
                    new Order { OrderID = 10835, OrderDate = new DateTime(1998, 1, 15), Total = 845.80m },
                    new Order { OrderID = 10952, OrderDate = new DateTime(1998, 3, 16), Total = 471.20m },
                    new Order { OrderID = 11011, OrderDate = new DateTime(1998, 4, 9), Total = 933.50m }
                }
            },
            new Customer
            {
                CustomerID = "ANATR",
                CompanyName = "Ana Trujillo Emparedados y helados",
                Address = "Avda. de la Constitución 2222",
                City = "México D.F.",
                Region = null,
                PostalCode = "05021",
                Country = "Mexico",
                Phone = "(5) 555-4729",
                Orders = new Order[]
                {
                    new Order { OrderID = 10308, OrderDate = new DateTime(1996, 9, 18), Total = 88.80m },
                    new Order { OrderID = 10625, OrderDate = new DateTime(1997, 8, 8), Total = 479.75m },
                    new Order { OrderID = 10759, OrderDate = new DateTime(1997, 11, 28), Total = 320.00m },
                    new Order { OrderID = 10926, OrderDate = new DateTime(1998, 3, 4), Total = 514.40m }
                }
            },
            new Customer
            {
                CustomerID = "ANTON",
                CompanyName = "Antonio Moreno Taquería",
                Address = "Mataderos  2312",
                City = "México D.F.",
                Region = null,
                PostalCode = "05023",
                Country = "Mexico",
                Phone = "(5) 555-3932",
                Orders = new Order[]
                {
                    new Order { OrderID = 10365, OrderDate = new DateTime(1996, 11, 27), Total = 403.20m },
                    new Order { OrderID = 10507, OrderDate = new DateTime(1997, 4, 15), Total = 749.06m },
                    new Order { OrderID = 10535, OrderDate = new DateTime(1997, 5, 13), Total = 2156.00m },
                    new Order { OrderID = 10573, OrderDate = new DateTime(1997, 6, 19), Total = 2082.00m },
                    new Order { OrderID = 10682, OrderDate = new DateTime(1997, 9, 25), Total = 375.50m },
                    new Order { OrderID = 10856, OrderDate = new DateTime(1998, 1, 28), Total = 660.00m }
                }
            },
            new Customer
            {
                CustomerID = "AROUT",
                CompanyName = "Around the Horn",
                Address = "120 Hanover Sq.",
                City = "London",
                Region = null,
                PostalCode = "WA1 1DP",
                Country = "UK",
                Phone = "(171) 555-7788",
                Orders = new Order[]
                {
                    new Order { OrderID = 10355, OrderDate = new DateTime(1996, 11, 15), Total = 480.00m },
                    new Order { OrderID = 10383, OrderDate = new DateTime(1996, 12, 16), Total = 899.00m },
                    new Order { OrderID = 10453, OrderDate = new DateTime(1997, 2, 21), Total = 407.70m },
                    new Order { OrderID = 10558, OrderDate = new DateTime(1997, 6, 4), Total = 2142.90m },
                    new Order { OrderID = 10741, OrderDate = new DateTime(1997, 11, 14), Total = 236.00m }
                }
            },
            new Customer
            {
                CustomerID = "BERGS",
                CompanyName = "Berglunds snabbköp",
                Address = "Berguvsvägen  8",
                City = "Luleå",
                Region = null,
                PostalCode = "S-958 22",
                Country = "Sweden",
                Phone = "0921-12 34 56",
                Orders = new Order[]
                {
                    new Order { OrderID = 10278, OrderDate = new DateTime(1996, 8, 12), Total = 1488.80m },
                    new Order { OrderID = 10280, OrderDate = new DateTime(1996, 8, 14), Total = 613.20m },
                    new Order { OrderID = 10384, OrderDate = new DateTime(1996, 12, 16), Total = 2222.40m },
                    new Order { OrderID = 10444, OrderDate = new DateTime(1997, 2, 12), Total = 1031.70m },
                    new Order { OrderID = 10445, OrderDate = new DateTime(1997, 2, 13), Total = 174.90m }
                }
            }
        };
}
