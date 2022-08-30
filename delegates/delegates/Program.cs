using Services;

double a = 10;
double b = 12;

CalculationService.BinaryNumericOperation opMax = CalculationService.Max;
CalculationService.BinaryNumericOperation opSum = CalculationService.Sum;

Console.WriteLine(opMax(a, b));
Console.WriteLine(opSum(a, b));
Console.WriteLine(CalculationService.Square(a));
