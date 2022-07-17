using System.Net.Http;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TestNetCalc.Models;
using TestNetCalc.Helpers;
using Newtonsoft.Json.Linq;


namespace TestNetCalc.Controllers
{
    public class CalculatorController : Controller
    {
        MathOpertionAPI _api = new MathOpertionAPI();

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
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:5010");
                var json = JsonSerializer.Serialize<MathExpression>(new MathExpression
                {
                    NumberOne = mathOPAndResult.MathExpression.NumberOne,
                    NumberTwo = mathOPAndResult.MathExpression.NumberTwo,
                    TypeOperation = mathOPAndResult.MathExpression.TypeOperation
                });
                var data = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage httpResponseMessage = await client.PostAsync("api/Calculator/calc", data);
                if (Response.StatusCode == Convert.ToInt64(HttpStatusCode.OK))
                {
                    var res = await httpResponseMessage.Content.ReadAsStringAsync();
                    dynamic resV2 = JObject.Parse(res);
                    mathOPAndResult.ResultOfMathExpression.value = resV2.value;
                }
            }
            return View(mathOPAndResult);

        }
    }
}
