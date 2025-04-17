using InvestLab.Business;
using InvestLab.Business.Factories;
using InvestLab.Models.Interfaces;
using InvestLab.Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvestLab.Api.Controllers
{
    public class FixedIncomeController : BaseController
    {
        /// <summary>
        /// Simula o retorno do Investimento de renda Fixa
        /// </summary>
        /// <param name="investiment"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Simulate(Investiment investiment)
        {
            
            IInterest interest = InterestFactory.CreateInterest(investiment);

            var fixedIncome = new FixedIncome(investiment, interest);

            var financialIncome = fixedIncome.FinancialCalculate();
            var manualIncome = fixedIncome.ManualCalculate();

            return Ok(new { financialIncome, manualIncome });
        }
    }
}
