using Services;

PrintServiceString printServiceString = new PrintServiceString();
PrintService printService = new PrintService();
Console.Write("How many values? ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    string n = Console.ReadLine();
    printServiceString.AddValue(n);
}

printServiceString.Print();
Console.WriteLine("First: " + printServiceString.First());