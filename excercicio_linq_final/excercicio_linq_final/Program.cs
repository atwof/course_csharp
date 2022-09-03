using System.Globalization;
using Entities;

// Caminho do arquivo
string path = @"/Users/alissonf/Desktop/in.txt";
List<Employee> employees = new List<Employee>();

using(StreamReader sr = File.OpenText(path))
{
    while(!sr.EndOfStream)
    {
        string[] line = sr.ReadLine().Split(',');

        string name = line[0];
        string email = line[1];
        double salary = double.Parse(line[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(name, email, salary));
    }
}

// Ler valor do usuário
Console.Write("Digite um valor: ");
double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

// Ordem alfabética com salário superior ao valor informado pelo user
var e1 = employees.Where(p => p.Salary > value).OrderBy(p => p.Email).Select(p => p.Email);
Console.WriteLine("Email of people whose salary is more " + value.ToString("F2", CultureInfo.InvariantCulture));
foreach (var x in e1)
{
    Console.WriteLine(x);
}

// Soma dos salários dos funcionários com inicial M
var e2 = employees.Where(p => p.Name[0] == 'M').Select(p => p.Salary).DefaultIfEmpty(0.0).Sum();
Console.WriteLine("Sum of salary of people whose name start with M: " + e2.ToString("F2", CultureInfo.InvariantCulture));