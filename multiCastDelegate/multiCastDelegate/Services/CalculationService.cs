using System;
namespace Services
{
    public class CalculationService
    {
        public delegate void BinaryNumerciOperation(double n1, double n2);

        public static void ShowMax(double x, double y)
        {
            double max = (x > y) ? x : y;
            Console.WriteLine(max);
        }

        public static void ShowSum(double x, double y)
        {
            double sum = x + y;
            Console.WriteLine(sum);
        }
    }
}

