using System;
using interface_exercise.Entities;
namespace interface_exercise.Services
{
    public class ContractService
    {
        public HashSet<Installment> Installments { get; set; }
        private ITaxService _taxService;

        public ContractService(ITaxService taxService)
        {
            _taxService = taxService;
            Installments = new HashSet<Installment>();
        }

        public void ProcessInstallment(double amount, int parcela, DateTime date)
        {
            double installmentValue = _taxService.Tax(amount, parcela);
            DateTime dueDate = date.AddMonths(1);

            Installment installment = new Installment(dueDate, installmentValue);
            Installments.Add(installment);
        }
    }
}

