using System.Collections.Concurrent;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using System;

namespace Linq_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ProductList
            var ProductList = new List<Product>() {
              new Product{ ProductID = 1, ProductName = "Chai", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 39 },
              new Product{ ProductID = 2, ProductName = "Chang", Category = "Beverages",
                UnitPrice = 19.0000M, UnitsInStock = 17 },
              new Product{ ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments",
                UnitPrice = 10.0000M, UnitsInStock = 13 },
              new Product{ ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments",
                UnitPrice = 22.0000M, UnitsInStock = 53 },
              new Product{ ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments",
                UnitPrice = 21.3500M, UnitsInStock = 0 },
              new Product{ ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments",
                UnitPrice = 25.0000M, UnitsInStock = 120 },
              new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                UnitPrice = 30.0000M, UnitsInStock = 15 },
              new Product{ ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments",
                UnitPrice = 40.0000M, UnitsInStock = 6 },
              new Product{ ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry",
                UnitPrice = 97.0000M, UnitsInStock = 29 },
              new Product{ ProductID = 10, ProductName = "Ikura", Category = "Seafood",
                UnitPrice = 31.0000M, UnitsInStock = 31 },
              new Product{ ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products",
                UnitPrice = 21.0000M, UnitsInStock = 22 },
              new Product{ ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products",
                UnitPrice = 38.0000M, UnitsInStock = 86 },
              new Product() { ProductID = 13, ProductName = "Konbu", Category = "Seafood",
                UnitPrice = 6.0000M, UnitsInStock = 24 },
              new Product() { ProductID = 14, ProductName = "Tofu", Category = "Produce",
                UnitPrice = 23.2500M, UnitsInStock = 35 },
              new Product() { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments",
                UnitPrice = 15.5000M, UnitsInStock = 39 },
              new Product() { ProductID = 16, ProductName = "Pavlova", Category = "Confections",
                UnitPrice = 17.4500M, UnitsInStock = 29 },
              new Product() { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry",
                UnitPrice = 39.0000M, UnitsInStock = 0 },
              new Product() { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood",
                UnitPrice = 62.5000M, UnitsInStock = 42 },
              new Product() { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections",
                UnitPrice = 9.2000M, UnitsInStock = 25 },
              new Product() { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections",
                UnitPrice = 81.0000M, UnitsInStock = 40 },
              new Product() { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections",
                UnitPrice = 10.0000M, UnitsInStock = 3 },
              new Product() { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals",
                UnitPrice = 21.0000M, UnitsInStock = 104 },
              new Product() { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals",
                UnitPrice = 9.0000M, UnitsInStock = 61 },
              new Product() { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages",
                UnitPrice = 4.5000M, UnitsInStock = 20 },
              new Product() { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections",
                UnitPrice = 14.0000M, UnitsInStock = 76 },
              new Product() { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections",
                UnitPrice = 31.2300M, UnitsInStock = 15 },
              new Product() { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections",
                UnitPrice = 43.9000M, UnitsInStock = 49 },
              new Product() { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce",
                UnitPrice = 45.6000M, UnitsInStock = 26 },
              new Product() { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry",
                UnitPrice = 123.7900M, UnitsInStock = 0 },
              new Product() { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood",
                UnitPrice = 25.8900M, UnitsInStock = 10 },
              new Product() { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products",
                UnitPrice = 12.5000M, UnitsInStock = 0 },
              new Product() { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products",
                UnitPrice = 32.0000M, UnitsInStock = 9 },
              new Product() { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products",
                UnitPrice = 2.5000M, UnitsInStock = 112 },
              new Product() { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages",
                UnitPrice = 14.0000M, UnitsInStock = 111 },
              new Product() { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 20 },
              new Product() { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood",
                UnitPrice = 19.0000M, UnitsInStock = 112 },
              new Product() { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood",
                UnitPrice = 26.0000M, UnitsInStock = 11 },
              new Product() { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages",
                UnitPrice = 263.5000M, UnitsInStock = 17 },
              new Product() { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 69 },
              new Product() { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood",
                UnitPrice = 18.4000M, UnitsInStock = 123 },
              new Product() { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood",
                UnitPrice = 9.6500M, UnitsInStock = 85 },
              new Product() { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals",
                UnitPrice = 14.0000M, UnitsInStock = 26 },
              new Product() { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages",
                UnitPrice = 46.0000M, UnitsInStock = 17 },
              new Product() { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments",
                UnitPrice = 19.4500M, UnitsInStock = 27 },
              new Product() { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood",
                UnitPrice = 9.5000M, UnitsInStock = 5 },
              new Product() { ProductID = 46, ProductName = "Spegesild", Category = "Seafood",
                UnitPrice = 12.0000M, UnitsInStock = 95 },
              new Product() { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections",
                UnitPrice = 9.5000M, UnitsInStock = 36 },
              new Product() { ProductID = 48, ProductName = "Chocolade", Category = "Confections",
                UnitPrice = 12.7500M, UnitsInStock = 15 },
              new Product() { ProductID = 49, ProductName = "Maxilaku", Category = "Confections",
                UnitPrice = 20.0000M, UnitsInStock = 10 },
              new Product() { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections",
                UnitPrice = 16.2500M, UnitsInStock = 65 },
              new Product() { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce",
                UnitPrice = 53.0000M, UnitsInStock = 20 },
              new Product() { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals",
                UnitPrice = 7.0000M, UnitsInStock = 38 },
              new Product() { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry",
                UnitPrice = 32.8000M, UnitsInStock = 0 },
              new Product() { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry",
                UnitPrice = 7.4500M, UnitsInStock = 21 },
              new Product() { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry",
                UnitPrice = 24.0000M, UnitsInStock = 115 },
              new Product() { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals",
                UnitPrice = 38.0000M, UnitsInStock = 21 },
              new Product() { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals",
                UnitPrice = 19.5000M, UnitsInStock = 36 },
              new Product() { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood",
                UnitPrice = 13.2500M, UnitsInStock = 62 },
              new Product() { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products",
                UnitPrice = 55.0000M, UnitsInStock = 79 },
              new Product() { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products",
                UnitPrice = 34.0000M, UnitsInStock = 19 },
              new Product() { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments",
                UnitPrice = 28.5000M, UnitsInStock = 113 },
              new Product() { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections",
                UnitPrice = 49.3000M, UnitsInStock = 17 },
              new Product() { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments",
                UnitPrice = 43.9000M, UnitsInStock = 24 },
              new Product() { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals",
                UnitPrice = 33.2500M, UnitsInStock = 22 },
              new Product() { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments",
                UnitPrice = 21.0500M, UnitsInStock = 76 },
              new Product() { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments",
                UnitPrice = 17.0000M, UnitsInStock = 4 },
              new Product() { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages",
                UnitPrice = 14.0000M, UnitsInStock = 52 },
              new Product() { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections",
                UnitPrice = 12.5000M, UnitsInStock = 6 },
              new Product() { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products",
                UnitPrice = 36.0000M, UnitsInStock = 26 },
              new Product() { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages",
                UnitPrice = 15.0000M, UnitsInStock = 15 },
              new Product() { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products",
                UnitPrice = 21.5000M, UnitsInStock = 26 },
              new Product() { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products",
                UnitPrice = 34.8000M, UnitsInStock = 14 },
              new Product() { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood",
                UnitPrice = 15.0000M, UnitsInStock = 101 },
              new Product() { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce",
                UnitPrice = 10.0000M, UnitsInStock = 4 },
              new Product() { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages",
                UnitPrice = 7.7500M, UnitsInStock = 125 },
              new Product() { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages",
                UnitPrice = 18.0000M, UnitsInStock = 57 },
              new Product() { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments",
                UnitPrice = 13.0000M, UnitsInStock = 32 }
            };
            #endregion

            #region CustomerList
            var CustomerList = (
                from e in XDocument.Load("customers.xml").
                          Root.Elements("customer")
                select new Customer
                {
                    CustomerID = (string)e.Element("id"),
                    CompanyName = (string)e.Element("name"),
                    Address = (string)e.Element("address"),
                    City = (string)e.Element("city"),
                    Region = (string)e.Element("region"),
                    PostalCode = (string)e.Element("postalcode"),
                    Country = (string)e.Element("country"),
                    Phone = (string)e.Element("phone"),
                    Fax = (string)e.Element("fax"),
                    Orders = (
                        from o in e.Elements("orders").Elements("order")
                        select new Order
                        {
                            OrderID = (int)o.Element("id"),
                            OrderDate = (DateTime)o.Element("orderdate"),
                            Total = (decimal)o.Element("total")
                        })
                        .ToArray()
                }
                ).ToList();
            #endregion
            //-----------------------------------------------------

            #region LINQ - Restriction Operators
            //1. Find all products that are out of stock.

            var Result = ProductList.Where(p => p.UnitsInStock == 0);
            /*out is 
            ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            ProductID:17,ProductName:Alice Mutton,CategoryMeat/Poultry,UnitPrice:39.0000,UnitsInStock:0
            ProductID:29,ProductName:Thüringer Rostbratwurst,CategoryMeat/Poultry,UnitPrice:123.7900,UnitsInStock:0
            ProductID:31,ProductName:Gorgonzola Telino,CategoryDairy Products,UnitPrice:12.5000,UnitsInStock:0
            ProductID:53,ProductName:Perth Pasties,CategoryMeat/Poultry,UnitPrice:32.8000,UnitsInStock:0
            */
            //2.Find all products that are in stock and cost more than 3.00 per unit.
             Result = ProductList.Where(p => (p.UnitsInStock != 0 && p.UnitPrice>3));

            //3.Returns digits whose name is shorter than their value.
            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var ArrResult = from x in Arr
                     where x !="zero" && x != "one" && x != "two" && x != "three"&&x!="four"
                     select x;
            #endregion

            //-----------------------------------------------------
            #region LINQ - Element Operators

            //1.Get first Product out of Stock
            /*out
             ProductID:5,ProductName:Chef Anton's Gumbo Mix,CategoryCondiments,UnitPrice:21.3500,UnitsInStock:0
            */
            var Result1 = ProductList.First(p => p.UnitsInStock == 0);

            //2.Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            Result1 = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);

            //Console.WriteLine(Result1?.ProductName ?? "Na");

            //3.Retrieve the second number greater than 5
            int[] Arr1 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var arr1res = Arr1.Where(p => p > 5).ElementAt(1);
            Console.WriteLine( arr1res );
            #endregion

            //-----------------------------------------------------

            #region LINQ - Set Operators

            //1.Find the unique Category names from Product List
            var setRes = ProductList.Select(p => p.Category).Distinct();
            //foreach(var item in setRes)
            //{
            //    Console.WriteLine( item );
            //}
            //2.Produce a Sequence containing the unique first letter from both product and customer names.
            var setRes1 = (ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CompanyName[0]))).Distinct();
            //foreach (var item in setRes1)
            //{
            //    Console.WriteLine(item);
            //}
            //3.Create one sequence that contains the common first letter from both product and customer names.
            setRes1 = (ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CompanyName[0]))).Distinct();
            //foreach (var item in setRes1)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            setRes1 = (ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CompanyName[0]))).Distinct();
            //foreach (var item in setRes1)
            //{
            //    Console.WriteLine(item);
            //}

            //5.Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            var setRes2 = (ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3))).Union(CustomerList.Select(p => p.CompanyName.Substring(p.CompanyName.Length - 3)));
            //foreach (var item in setRes2)
            //{
            //    Console.WriteLine( item );
            //}
            #endregion
            //-----------------------------------------------------

            #region LINQ - Aggregate Operators

            //1.Uses Count to get the number of odd numbers in the array
            int[]Arr3 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var cnt =Arr3.Count(n=>n%2==1);
            Console.WriteLine( cnt );
            //            Use ListGenerators.cs & Customers.xml
            //2.Return a list of customers and how many orders each has.
            var res1= CustomerList.Select(c => new {id=c.CustomerID,name=c.CompanyName ,orderCnt=c.Orders.Count() });
            //foreach(var item in res1)
            //{
            //    Console.WriteLine( item );
            //}
            //3.Return a list of categories and how many products each has
            var res2 = ProductList.GroupBy(c => c.Category); 
            //foreach (var item in res2)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Get the total of the numbers in an array.
            int[] Arr4 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res3 = Arr4.Sum();
            //Console.WriteLine( res3 );

            //5.Get the total number of characters of all words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            res3 = File.ReadAllLines("dictionary_english.txt").Sum(x=>x.Length);
            //Console.WriteLine( res3 );

            //6.Get the total units in stock for each product category.
             res2 = ProductList.GroupBy(c => c.Category);
            //foreach( var item in res2)
            //{
            //    Console.WriteLine( item.Key+" ->  "+item.Sum(p=>p.UnitsInStock) );
            //}

            //7.Get the length of the shortest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Use ListGenerators.cs & Customers.xml
            var res4 = File.ReadAllLines("dictionary_english.txt").MinBy(x=>x.Length);
            Console.WriteLine(res4);


            //8.Get the cheapest price among each category's products


            //9.Get the products with the cheapest price in each category(Use Let)


            //10.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).
            //Use ListGenerators.cs & Customers.xml


            //11.Get the most expensive price among each category's products.


            //12.Get the products with the most expensive price in each category.


            //13.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).


            //14.Get the average price of each category's products.

            #endregion
            //-----------------------------------------------------


            #region LINQ - Ordering Operators

            //1.Sort a list of products by name
            var ressort = ProductList.OrderBy(p => p.ProductName);
            //foreach(var item in ressort)
            //{
            //    Console.WriteLine( item );
            //}

            //2.Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] sArr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //            Use ListGenerators.cs & Customers.xml
            //3.Sort a list of products by units in stock from highest to lowest.
            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //            5.Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //            Use ListGenerators.cs & Customers.xml
            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //7.Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //            8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            #endregion
            //-----------------------------------------------------

            #region LINQ - Partitioning Operators

            //Use ListGenerators.cs & Customers.xml
            //1.Get the first 3 orders from customers in Washington
            var res11 = CustomerList.Where(c => c.Country == "Washington").Take(3);
            foreach(var c in res11)
            {
                Console.WriteLine(c);
                
            }

            //2.Get all but the first 2 orders from customers in Washington.
            res11 = CustomerList.Where(c => c.Country == "Washington").Skip(3);
            foreach (var c in res11)
            {
                Console.WriteLine(c);

            }
            //3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var r = numbers.TakeWhile((value, index) => value >= index);

            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
             r = numbers.SkipWhile((value) => value % 3 != 0);

            //5.Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            #endregion
            //-----------------------------------------------------

            #region LINQ - Projection Operators

            //            Use ListGenerators.cs & Customers.xml
            //1.Return a sequence of just the names of a list of products.
            var res7 = ProductList.Select(p => new { name = p.ProductName });

            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
              string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            var w = words.Select(w => new { u = w.ToUpper(), l = w.ToLower() });

            //            Use ListGenerators.cs & Customers.xml
            //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            var res8 = ProductList.Select(p => new { Price = p.UnitPrice });


            //4.Determine if the value of ints in an array match their position in the array.
            int[] Arr6 = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var res9 = Arr6.Select((value, indx) => new { num = value, b = value == indx });
            //foreach(var item in res9)
            //{
            //    Console.WriteLine(item);
            //}
           

            //5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var cmp = from a in numbersA
                                           from b in numbersB
                                           where a < b
                                           select new { a = a, b = b };
            foreach(var x in cmp)
            {
                Console.WriteLine(x);
            }
            

            //Use ListGenerators.cs & Customers.xml
            //6.Select all orders where the order total is less than 500.00.
            var OrderList = CustomerList.Where(c => (c.Orders.Sum(c => c.Total)) > 50000).Select(c => new { CustomerID = c.CustomerID, TotalOrders = c.Orders.Sum(c => c.Total) });

            //7.Select all orders where the order was made in 1998 or later.
            var allOrders= CustomerList.Select(c => new { Name = c.CompanyName, Orders = c.Orders.Where(o => o.OrderDate.Year >= 1998) });

            #endregion
            //-----------------------------------------------------

            #region LINQ - Quantifiers finished

            //1.Determine if any of the words in dictionary_english.txt
            //(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            string[] str = File.ReadAllLines("dictionary_english.txt");
            Console.WriteLine(str.Any(p=>p.Contains("ei")));

            //Use ListGenerators.cs & Customers.xml
            //2.Return a grouped a list of products only for categories that have at least one product that is out of stock.
            var res6=ProductList.GroupBy(c => c.Category).Where(c=>c.Any(p=>p.UnitsInStock!=0));
            //3.Return a grouped a list of products only for categories that have all of their products in stock.
             res6 = ProductList.GroupBy(c => c.Category).Where(c => c.All(p => p.UnitsInStock != 0));

            //foreach( var item in res6)
            //{
            //    foreach( var i in item)
            //    {
            //        Console.WriteLine(i.ToString());
            //    }
            //}
            #endregion
            //-----------------------------------------------------

            #region LINQ - Grouping Operators not finished

            //
            //1.Use group by to partition a list of numbers by their remainder when divided by 5
            var lst1 = Enumerable.Range(0, 15).GroupBy(p => p % 5);
            //foreach (var x in lst1 )
            //{
            //    //Console.WriteLine( x );
            //    foreach( var xx in x)
            //    {
            //        Console.WriteLine( xx );
            //    }
            //    Console.WriteLine("---------------");
            //}


            //2.Uses group by to partition a list of words by their first letter.
            //Use dictionary_english.txt for Input
            var res5 = File.ReadAllLines("dictionary_english.txt").GroupBy(x => x.ToCharArray()[0]);
            //foreach (var x in res5)
            //{
            //    Console.WriteLine( x );
            //    foreach (var xx in x)
            //         {
            //              Console.WriteLine( xx );
            //           }
            //        Console.WriteLine("---------------");
            //}

            //3.Consider this Array as an Input
            string[] Arr5 = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };
           // var s2 = Arr5.GroupBy(w => w.Trim(), new comparer());

            //            Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //Result...
            //from
            //form
            //...
            //salt
            //last
            //...
            //earn
            //near



            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in ArrResult)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}