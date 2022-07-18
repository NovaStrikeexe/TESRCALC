using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models
{
    /**
    *  MathOPAndResult - класс содержащий информацию о данном математическом выражении и о результате проведенной математической операции.
    *  Используется для работы с TestNetCalc\Views\Calculator\Calc.cshtml
    */
    public class MathOPAndResult
    {
        public MathExpression MathExpression { get; set; }
        public ResultOfMathExpression ResultOfMathExpression { get; set; }
    }
}