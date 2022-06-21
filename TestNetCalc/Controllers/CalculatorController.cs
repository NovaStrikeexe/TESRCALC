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
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Calc(string expression) 
        {
            ExpressionString expressionString = new ExpressionString();
            expressionString.StringExpression = Request.Form["ExpressionStr"];

            if (expressionString.StringExpression != "")
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
            else 
            { 
                return View(expressionString); 
            }

            return View( expressionString);
        }

    }
}
