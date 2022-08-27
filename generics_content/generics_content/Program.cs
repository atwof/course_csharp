using Services;

PrintService printService = new PrintService();
Console.Write("How many values? ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    int n = int.Parse(Console.ReadLine());
    printService.AddValue(n);
}

printService.Print();
Console.WriteLine("First: " + printService.First());