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
            MathOPAndResult mathOPAndResult = new MathOPAndResult();
            mathOPAndResult.MathExpression = new MathExpression();
            mathOPAndResult.ResultOfMathExpression = new ResultOfMathExpression();
            return View(mathOPAndResult);
        }
        [HttpPost]
        public async Task<ActionResult<MathOPAndResult>> Calc(MathOPAndResult mathOPAndResult)
        {
            mathOPAndResult.MathExpression = new MathExpression();
            mathOPAndResult.ResultOfMathExpression = new ResultOfMathExpression();
            mathOPAndResult.MathExpression.NumberOne = Convert.ToDouble(Request.Form["NumberOne"]);
            mathOPAndResult.MathExpression.NumberTwo = Convert.ToDouble(Request.Form["NumberTwo"]);
            mathOPAndResult.MathExpression.TypeOperation = Convert.ToChar(Request.Form["TypeOperation"]);
            mathOPAndResult.ResultOfMathExpression.value = 0;

            if (mathOPAndResult.MathExpression.NumberOne.ToString() == "" || mathOPAndResult.MathExpression.NumberTwo.ToString() == "" || mathOPAndResult.MathExpression.TypeOperation.ToString() == "")
            {
                return View(mathOPAndResult);
            }
            else
            {
                try
                {
                    var expTask = Task.Run(() => BaseCalculatorService.ReturnResultOfExpession(mathOPAndResult.MathExpression));
                    mathOPAndResult.ResultOfMathExpression.value = await expTask;
                }
                catch (Exception)
                {
                    mathOPAndResult.ResultOfMathExpression.value = mathOPAndResult.MathExpression.NumberOne;
                }
            }
            return View(mathOPAndResult);

        }
    }
}
