using Entities;

List<Product> products = new List<Product>();

products.Add(new Product("TV", 900.00));
products.Add(new Product("Notebook", 1200.00));
products.Add(new Product("Tablet", 450.00));

Comparison<Product> comp = CompareProducts;

// Lambda
Comparison<Product> comp2 = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

products.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

foreach (Product x in products)
{
    Console.WriteLine(x);
}

// Comparison<T>
static int CompareProducts(Product p1, Product p2)
{
    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
}