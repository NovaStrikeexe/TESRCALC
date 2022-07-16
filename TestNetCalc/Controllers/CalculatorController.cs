using TestNetCalc.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
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
        public async Task<ActionResult<MathExpression>> Calc(MathExpression mathExpression)
        {
            ResultOfMathExpression resultOfMathExpression = new ResultOfMathExpression();
            if (mathExpression.NumberOne.ToString() == "" || mathExpression.NumberTwo.ToString() == "" || mathExpression.TypeOperation.ToString() == "")
            {
                return View(mathExpression);
            }
            else
            {
                try
                {
                    var expTask = Task.Run(() => BaseCalculatorService.ReturnResultOfExpession(mathExpression));
                    resultOfMathExpression.value = await expTask;
                }
                catch (Exception)
                {
                    resultOfMathExpression.value = mathExpression.NumberOne;
                }
            }
            mathExpression.NumberOne = resultOfMathExpression.value;
            mathExpression.NumberTwo = 0;
            return View(mathExpression);

        }
    }
}
