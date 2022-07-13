using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TestNetCalc.Models;
using TestNetCalc.Services;


namespace TestNetCalc.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Calc()
        {
            MathExpression mathExpression = new MathExpression();
            return View(mathExpression);
        }
        [HttpPost]
        public async Task<ActionResult> Calc(MathExpression mathExpression)
        {

            mathExpression.NumberOne = Request.Form["NumberOne"];
            mathExpression.NumberTwo = Request.Form["NumberTwo"];
            mathExpression.TypeOperation = Request.Form["TypeOperation"];

            if (mathExpression.NumberOne == "" || mathExpression.NumberTwo == "" || mathExpression.TypeOperation == "")
            {
                return View(mathExpression);
            }
            else
            {
                try
                {
                    var expTask = Task.Run(() => BaseCalculatorService.ReturnResultOfExpession(mathExpression));
                    mathExpression.ResultOfMathExpression = await expTask;
                }
                catch (Exception)
                {
                    mathExpression.ResultOfMathExpression = "Unexpected expression";
                }
            }

            return View(mathExpression);
        }

    }
}
