using InvestLab.Business.Services;
using InvestLab.Models.Interfaces;
using InvestLab.Models.Models;
using Microsoft.VisualBasic;

namespace InvestLab.Business
{
    public class FixedIncome(Investiment invest, IInterest interest)
    {
        private Investiment Investiment { get; set; } = invest;
        private IInterest Interest { get; set; } = interest;

        public Income FinancialCalculate()
        {
            var monthsDiference = (Investiment.DueDate - DateTime.Now).Days / 30;

            var grossProfit = (decimal)Financial.FV((double)Interest.GetMonthlyInterest()/100, monthsDiference, -(double)Investiment.MonthlyBudget, -(double)Investiment.InitialBudget, DueDate.BegOfPeriod);

            return new Income
            {
                GrossProfrit = grossProfit,
                NetProfit = Investiment.ConsiderIncomeTax ? grossProfit * (1 - IncomeTaxService.CalculateIncomeTax(Investiment.DueDate)) : grossProfit,
                IncomeTax= Investiment.ConsiderIncomeTax ? grossProfit * IncomeTaxService.CalculateIncomeTax(Investiment.DueDate) : 0
            };
        }

        public Income ManualCalculate()
        {
            var monthsDiference = (Investiment.DueDate - DateTime.Now).Days / 30;

            decimal grossProfit = Investiment.InitialBudget * (1m + Interest.GetMonthlyInterest() / 100);
            for (int i = 0; i < monthsDiference; i++)
            {
                grossProfit = (grossProfit + Investiment.MonthlyBudget) * (1m + Interest.GetMonthlyInterest() / 100);
            }

            return new Income
            {
                GrossProfrit = grossProfit,
                NetProfit = Investiment.ConsiderIncomeTax ? grossProfit * (1 - IncomeTaxService.CalculateIncomeTax(Investiment.DueDate)) : grossProfit,
                IncomeTax = Investiment.ConsiderIncomeTax ? grossProfit * IncomeTaxService.CalculateIncomeTax(Investiment.DueDate) : 0
            };
        }
    }
}
