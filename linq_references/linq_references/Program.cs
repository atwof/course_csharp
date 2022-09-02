﻿using Entities;
using System.Linq;

Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

List<Product> products = new List<Product>()
{
    new Product() {Id = 1, Name = "Computer", Price = 900, Category = c2},
    new Product() {Id = 2, Name = "TV", Price = 345, Category = c3},
    new Product() {Id = 3, Name = "Screwdriver", Price = 11111, Category = c1},
    new Product() {Id = 4, Name = "Saw", Price = 32, Category = c1},
    new Product() {Id = 5, Name = "Level", Price = 323, Category = c1},
    new Product() {Id = 6, Name = "Printer", Price = 9999, Category = c2},
    new Product() {Id = 7, Name = "Tablet", Price = 900, Category = c3},
    new Product() {Id = 8, Name = "Fridge", Price = 77456, Category = c2},
    new Product() {Id = 9, Name = "Aven", Price = 9300, Category = c3},
    new Product() {Id = 10, Name = "PC", Price = 900, Category = c2}
};

var r1 = products.Where(p => p.Category.Tier == 1 && p.Price <= 900);
Print("TIER 1 AND PRICE BELOW 900", r1);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
Print("NAME OF PRODUCTS FROM TOOLS", r2);

var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
Print("TIER 1 AND ORDER BY PRICE THEN BY NAME", r4);

var r5 = r4.Skip(2).Take(4);
Print("TIER 1 AND SKIP 2 AND TAKE 4", r5);

var r6 = products.FirstOrDefault();
Console.WriteLine("FIRST OR DEFAULT: " + r6);

var r7 = products.Where(p => p.Price > 211200).FirstOrDefault();
Console.WriteLine("SECOND FIRST OR DEFAULT: " + r7);

var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
Console.WriteLine("SINGLE OR DEFAULT: " + r8);

var r9 = products.Where(p => p.Id == 30).SingleOrDefault();
Console.WriteLine("SINGLE OR DEFAULT [NULL]: " + r9);

var r10 = products.Max(p => p.Price);
Console.WriteLine("MAX PRICE: " + r10);

var r11 = products.Min(p => p.Price);
Console.WriteLine("MIN PRICE: " + r11);

var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("CATEGORY SUM PRICES: " + r12);

var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
Console.WriteLine("CATEGORY 1 AVERAGE PRICES: " + r13);

var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty().Average();
Console.WriteLine("CATEGORY 5 AVERAGE PRICES: " + r14);

var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
Console.WriteLine("CATEGORY 1 AND AGGREGATE SUM: " + r15);
Console.WriteLine();

var r16 = products.GroupBy(p => p.Category);
foreach (IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("CATERGORY: " + group.Key.Name);
    foreach (Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}

// FUNÇÃO PARA EXIBIR A LISTA
static void Print<T>(string message, IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach (T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}