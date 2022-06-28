using System;
using TestNetCalc.Models;
using TestNetCalc.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace TestNetCalc.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Calc()
        {
            ExpressionString expressionString = new ExpressionString();
            expressionString.StringExpression = "0";
            return View(expressionString);
        }

        [HttpPost]
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
                    expressionString.StringExpression = CalculatorService.ReturnResultOfExpession(expressionString.StringExpression);
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
