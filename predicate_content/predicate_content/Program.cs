using Entities;

List<Product> products = new List<Product>();

products.Add(new Product("TV", 90));
products.Add(new Product("Notebook", 1200.00));
products.Add(new Product("Tablet", 350.00));

products.RemoveAll(ProductTest);
// products.RemoveAll(p => p.Price >= 100);

foreach (Product x in products)
{
    Console.WriteLine(x);
}

static bool ProductTest(Product p)
{
    return p.Price >= 100;
}

