using System;

namespace TestNetCalc.Models
{
    public class BaseCalculator : AbsractBaseCalculator<string>
    {
        public override string Addition(string a, string b)
        {
            double result = Convert.ToDouble(a) + Convert.ToDouble(b);
            return result.ToString();
        }
        public override string Subtraction(string a, string b)
        {
            double result = Convert.ToDouble(a) - Convert.ToDouble(b);
            return result.ToString();
        }
        public override string Multiplication(string a, string b)
        {
            double result = Convert.ToDouble(a) * Convert.ToDouble(b);
            return result.ToString();
        }
        public override string Division(string a, string b)
        {
            if (Convert.ToInt32(b) != 0)
            {
                double result = Convert.ToDouble(a) / Convert.ToDouble(b);
                return result.ToString();
            }
            else
            {
                return "Div by zero";
            }

        }
    }
}
