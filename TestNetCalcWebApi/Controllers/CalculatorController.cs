using TestNetCalcWebApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using TestNetCalcWebApi.Services;

namespace TestNetCalcWebApi.Controllers
{
    /**
    * CalculatorController - контроллер отвечающий за получения результата математической операции
    */

    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        // Post: api/<TestNetCalcWebApiController>
        [HttpPost]
        [Route("calc")]
        public async Task<ActionResult<ResultOfMathExpression>> Calc(MathExpression mathExpression)
        {
            ResultOfMathExpression resultOfMathExpression = new ResultOfMathExpression();
            if (mathExpression.NumberOne.ToString() == "" || mathExpression.NumberTwo.ToString() == "" || mathExpression.TypeOperation.ToString() == "")
            {
                resultOfMathExpression.value = 0;
                return resultOfMathExpression;
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
            return resultOfMathExpression;
        }
    }
}
