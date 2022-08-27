using Services;

PrintService<string> printService = new PrintService<string>();

Console.Write("How many values? ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    string n = Console.ReadLine();
    printService.AddValue(n);
}

printService.Print();
Console.WriteLine("First: " + printService.First());