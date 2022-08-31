using Entities;

List<Product> list = new List<Product>();

list.Add(new Product("tv", 900));
list.Add(new Product("Carro", 4000));
list.Add(new Product("note", 22));

// Func<Product, string> func = p => p.Name.ToUpper();
// Func<Product, string> func = NameUpper;

// List<string> result = list.Select(NameUpper).ToList();
// List<string> result = list.Select(func).ToList();
List<string> result = list.Select(p => p.Name.ToUpper()).ToList();

foreach (string p in result)
{
    Console.WriteLine(p);
}

static string NameUpper(Product p)
{
    return p.Name.ToUpper();
}


