using System;
namespace interface_exercise.Services
{
    public class PaypalTax : ITaxService
    {
        public double Tax(double amount, int parcela)
        {
            double montlyInterest = amount * 0.01 * parcela;
            double paymentFee = (amount + montlyInterest) * 0.02;
            return amount + montlyInterest + paymentFee;
        }
    }
}

