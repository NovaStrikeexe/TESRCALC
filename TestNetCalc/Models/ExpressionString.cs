using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestNetCalc.Models
{
    public class ExpressionString
    {
#nullable enable
        public string? StringExpression;

        public ExpressionString()
        {
        }

        public ExpressionString(string? stringExpression)
        {
            StringExpression = stringExpression;
        }
    }
}
