using Entities;

List<Product> products = new List<Product>();

products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 1200.00));
products.Add(new Product("Tablet", 450.00));

products.Sort();

foreach (Product x in products)
{
    Console.WriteLine(x);
}