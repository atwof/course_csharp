using Services;

// PRINT SERVICES
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

List<int> list = new List<int>();

Console.Write("Enter N: ");
int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    x = int.Parse(Console.ReadLine());
    list.Add(x);
}

CalculationService calculationService = new CalculationService();

int max = calculationService.Max(list);

Console.WriteLine("Max: " + max);
