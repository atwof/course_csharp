using System.Globalization;
using System.Collections.Generic;
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

// HashSet e SortedSet - Parte 1
HashSet<string> set = new HashSet<string>();

set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");

Console.WriteLine(set.Contains("Notebook"));

foreach (string x in set)
{
    Console.WriteLine(x);
}

SortedSet<int> a = new SortedSet<int>() { 1, 2, 3, 4, 5 };
SortedSet<int> b = new SortedSet<int>() { 1, 7, 4, 9, 3 };

PrintCollection(a);

// union
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
PrintCollection(c);

// intersection - Somente o que há em ambos os conjuntos
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);

PrintCollection(d);

// difference - Somente aquilo que não há em um dos hash
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);

PrintCollection(e);


static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T x in collection)
    {
        Console.Write(x + " ");
    }
    Console.WriteLine();
}

HashSet<ProductHash> a = new HashSet<ProductHash>();
a.Add(new ProductHash("TV", 900));
a.Add(new ProductHash("Notebook", 1200));

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(1,2));
b.Add(new Point(3, 4));

ProductHash prod = new ProductHash("TV", 900);
Point p = new Point(1, 2);

// Compara a referência - Classe
Console.WriteLine(a.Contains(prod));

// Compara os valores - Struct
Console.WriteLine(b.Contains(p));

// Atividade de leitura de arquivo

string path = @"/Users/alissonf/Desktop/in.txt";
Arquivo a = new Arquivo();
a.LerArquivo(path);
a.MostrarArquivoLidoSemRepeticao();
a.MostrarTodasAsLinhasLidas();
Console.WriteLine("Total de registros do arquivo: " + a.TotalRegistrosDistintos());

*/

// Exercício proposto

Professor p = new Professor("Alisson");
Console.Write("Digite a quantidade de cursos: ");
int x = int.Parse(Console.ReadLine());

for (int i = 0; i < x; i++)
{
    Console.Write("Digite a quantidade de alunos do curso " + i + ": ");
    int qtdeAlunos = int.Parse(Console.ReadLine());

    for (int j = 0; j < qtdeAlunos; j++)
    {
        int aluno = int.Parse(Console.ReadLine());
        p.AdicionarAluno(aluno);
    }
}

Console.WriteLine("Total de alunos do professor " + p.Name + ": " + p.RetornarTotalDeAlunos());