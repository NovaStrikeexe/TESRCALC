using TestNetCalcWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestNetCalcWebApi.Services;

namespace TestNetCalcWebApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Post: api/<TestNetCalcWebApiController>
        [HttpPost]
        public async Task<ActionResult<MathExpression>> Calc(MathExpression mathExpression)
        {
            ResultOfMathExpression resultOfMathExpression = new ResultOfMathExpression();
            if (mathExpression.NumberOne.ToString() == "" || mathExpression.NumberTwo.ToString() == "" || mathExpression.TypeOperation.ToString() == "")
            {
                return mathExpression;
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
            return mathExpression;
        }
    }
}
