using Entities;

List<Product> list = new List<Product>();

list.Add(new Product("TV", 20));
list.Add(new Product("Notebook", 2340));
list.Add(new Product("Tablet", 2220));

Action<Product> actionProduct = UpdatePrice;
Action<Product> actionP = p => { p.Price += p.Price * 0.1; };

list.ForEach(actionProduct);
list.ForEach(actionP);
list.ForEach(p => { p.Price += p.Price * 0.1; });

list.ForEach(UpdatePrice);

foreach (Product p in list)
{
    Console.WriteLine(p);
}

static void UpdatePrice(Product p)
{
    p.Price += p.Price * 0.1;
}
