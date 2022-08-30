using Services;

double a = 10;
double b = 12;

CalculationService.BinaryNumerciOperation op = CalculationService.ShowSum;
op += CalculationService.ShowMax;

op.Invoke(a, b);
op(a, b);