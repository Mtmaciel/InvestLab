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
            decimal valorFinal = investiment.InitialBudget * (1m + 0.011875m);

            for (int i = 0; i < 24; i++)
            {
                valorFinal = (valorFinal + 250) * (1m + 0.011875m);
            }
            return Ok();
        }
    }
}
