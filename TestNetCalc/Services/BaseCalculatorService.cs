﻿using TestNetCalc.Models;
namespace TestNetCalc.Services
{
    public class BaseCalculatorService 
    {
        public static string ReturnResultOfExpession(string expression)
        {
            return AdditionMultiplicationCalcService.Execute(ConverterExpressionType.JsonToExpressionType(ExpresionToJsonService.ExpresionToJson(expression)));
        }
    }
}
