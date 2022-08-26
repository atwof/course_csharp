using interface_exercise.Entities;
using interface_exercise.Services;
using System.Globalization;

Console.WriteLine("Enter contract data");

Console.Write("Number: ");
int number = int.Parse(Console.ReadLine());

Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

Console.Write("Contract value: ");
double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter number of installments: ");
int installment = int.Parse(Console.ReadLine());

ContractService contractService = new ContractService(new PaypalTax());
if (installment > 0)
{

    for (int i = 1; i <= installment; i++)
    {
        double valuePerInstallment = contractValue / installment;
        contractService.ProcessInstallment(valuePerInstallment, i, date);
    }
}

Console.WriteLine("INSTALLMENTS");
foreach (Installment x in contractService.Installments)
{
    Console.Write(x.DueDate + " - " + x.Amount);
    Console.WriteLine();
}