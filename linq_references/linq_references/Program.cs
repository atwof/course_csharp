using Entities;
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

//var r1 = products.Where(p => p.Category.Tier == 1 && p.Price <= 900);
var r1 = from p in products
         where p.Category.Tier == 1 && p.Price <= 900
         select p;
Print("TIER 1 AND PRICE BELOW 900", r1);

// var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
var r2 = from p in products
         where p.Category.Name == "Tools"
         select p.Name;
Print("NAME OF PRODUCTS FROM TOOLS", r2);

// var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new {p.Name, p.Price, CategoryName = p.Category.Name});
var r3 = from p in products
         where p.Name[0] == 'C'
         select new
         {
             p.Name,
             p.Price,
             CategoryName = p.Category.Name
         };
Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

// var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
var r4 = from p in products
         where p.Category.Tier == 1
         orderby p.Name
         orderby p.Price
         select p;
Print("TIER 1 AND ORDER BY PRICE THEN BY NAME", r4);

//var r5 = r4.Skip(2).Take(4);
var r5 = (from p in r4
          select p).Skip(2).Take(4);
Print("TIER 1 AND SKIP 2 AND TAKE 4", r5);

// var r6 = products.FirstOrDefault();
var r6 = (from p in products
          select p).FirstOrDefault();
Console.WriteLine("FIRST OR DEFAULT: " + r6);

// var r7 = products.Where(p => p.Price > 211200).FirstOrDefault();
var r7 = (from p in products
          where p.Price > 211200
          select p).FirstOrDefault();
Console.WriteLine("SECOND FIRST OR DEFAULT: " + r7);

// var r16 = products.GroupBy(p => p.Category);
var r16 = from p in products
          group p by p.Category;
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