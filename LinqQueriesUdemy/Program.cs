﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;

namespace LinqQueriesUdemy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Acer Laptop",QuantityPerUnit="32 GB Ram",UnitPrice=10000,UnitsInStock=5},
                new Product{ProductId=2,CategoryId=1,ProductName="Asus Laptop",QuantityPerUnit="16 GB Ram",UnitPrice=18000,UnitsInStock=3},
                new Product{ProductId=3,CategoryId=1,ProductName="Hp Laptop",QuantityPerUnit="8 GB Ram",UnitPrice=18000,UnitsInStock=2},
                new Product{ProductId=4,CategoryId=2,ProductName="Samsung Laptop",QuantityPerUnit="4 GB Ram",UnitPrice=5000,UnitsInStock=15},
                new Product{ProductId=5,CategoryId=2,ProductName="Apple Laptop",QuantityPerUnit="4 GB Ram",UnitPrice=8000,UnitsInStock=0}
            };

            // Linq Queries

            // AnyTest(products);
            // FindTest(products);
            // FindAllTest(products);
            // AscDescTest(products);
            // ClassicLinqTest(products);

            var result = from p in products
                         join c in categories
                         on p.CategoryId equals c.CategoryId
                         where p.UnitPrice > 5000
                         orderby p.UnitPrice descending
                         select new ProductDto
                         {
                             ProductId = p.ProductId,
                             CategoryName = c.CategoryName,
                             ProductName = p.ProductName,
                             UnitPrice = p.UnitPrice
                         };


            foreach (var productDto in result)
            {
                Console.WriteLine($"{productDto.ProductName} ---- {productDto.CategoryName}");
            }


        }

        private static void ClassicLinqTest(List<Product> products)
        {
            var result = from p in products
                         where p.UnitPrice > 6000
                         orderby p.UnitPrice descending, p.ProductName ascending
                         select new ProductDto {ProductId = p.ProductId,ProductName=p.ProductName,UnitPrice=p.UnitPrice };

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void AscDescTest(List<Product> products)
        {
            var result = products.Where(p => p.ProductName.Contains("top")).OrderByDescending(p => p.UnitPrice).ThenBy(p => p.ProductName);

            foreach (var product in products)
            {
                Console.WriteLine(product.ProductName);
            }
        }
        private static void FindAllTest(List<Product> products)
        {
            var result = products.FindAll(p => p.ProductName.Contains("top"));
            Console.WriteLine(result);
        }
        private static void FindTest(List<Product> products)
        {
            var result = products.Find(p => p.ProductId == 3);
            Console.WriteLine(result.ProductName);
        }
        private static void AnyTest(List<Product> products)
        {
            var result = products.Any(p => p.ProductName == "Hp Laptop");
            Console.WriteLine(result);
        }
    }

    class ProductDto
    {
        public int ProductId { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
