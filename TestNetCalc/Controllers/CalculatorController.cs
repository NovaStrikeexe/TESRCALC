using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TestNetCalc.Models;
using TestNetCalc.Service;

namespace TestNetCalc.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Calc()
        {
            ExpressionString expressionString = new ExpressionString();
            return View(expressionString);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status503ServiceUnavailable)]
        public async Task<ActionResult> Calc(string expression)
        {

            ExpressionString expressionString = new ExpressionString();
            expressionString.StringExpression = Request.Form["ExpressionStr"];

            if (expressionString.StringExpression == "" || expressionString.StringExpression == "0")
            {
                return View(expressionString);
            }
            else
            {
                try
                {
                    var expTask = Task.Run(() => CalculatorService.ReturnResultOfExpession(expressionString.StringExpression));
                    expressionString.StringExpression = await expTask;
                }
                catch (Exception)
                {
                    expressionString.StringExpression = "Unexpected expression";
                }
            }

            return View(expressionString);
        }

    }
}
