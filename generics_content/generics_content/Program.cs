using System.Globalization;
using Services;
using Entities;

// PRINT SERVICES
/*
PrintService<int> printService = new PrintService<int>();

Console.Write("How many values? ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    int a = int.Parse(Console.ReadLine());
    printService.AddValue(a);
}

printService.Print();
Console.WriteLine("First: " + printService.First());

// MAX
Console.WriteLine();
List<Product> list = new List<Product>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] vect = Console.ReadLine().Split(",");
    string name = vect[0];
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    list.Add(new Product(name, price));
}

CalculationService calculationService = new CalculationService();

Product max = calculationService.Max(list);

Console.WriteLine("Max: " + max);
*/

// Equals e HashCode
string a = "Alisson ";
string xa = "Alisson";
string b = "Pedro";

// Mais lento, porém mais acertivo
Console.WriteLine(a.Equals(b));

// Mais rápido, porém podem ocorrer diferenças
Console.WriteLine(a.GetHashCode());
Console.WriteLine(xa.GetHashCode());
Console.WriteLine(b.GetHashCode());

// Comparando hashs e equals
Client c1 = new Client() { Name = "Maria", Email = "maria@email.com" };
Client c2 = new Client() { Name = "Alex", Email = "alex@email.com" };

Console.WriteLine(c1.Equals("Equals: " + c2));

int hashC1 = c1.GetHashCode();
int hashC2 = c2.GetHashCode();

Console.WriteLine("Hashcode C1: " + hashC1);
Console.WriteLine("Hashcode C2: " + hashC2);

Console.WriteLine("Compare hash: " + hashC1.Equals(hashC2));