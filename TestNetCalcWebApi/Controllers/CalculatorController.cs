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
        // GET: api/<TestNetCalcWebApiController>
        [HttpGet]
        public async Task<ActionResult<String>> Calc(string expression)
        {

            ExpressionString expressionString = new ExpressionString();
            if (expressionString.StringExpression == "" || expressionString.StringExpression == "0")
            {
                return expressionString.StringExpression;
            }
            else
            {
                try
                {
                    var expTask = Task.Run(() => BaseCalculatorService.ReturnResultOfExpession(expression));
                    expressionString.StringExpression = await expTask;
                }
                catch (Exception)
                {
                    expressionString.StringExpression = "Unexpected expression";
                }
            }
            return expressionString.StringExpression;
        }
    }
}
