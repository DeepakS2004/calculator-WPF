using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class Arith
    {
        public int ConverttoInt(string value)
        {
            int val = 0;
            if (!string.IsNullOrEmpty(value))
            {
                val = Convert.ToInt32(value);
            }
            return val;
        }

        public string Calculation(string value1, string value2, string oper)
        {
            int first = ConverttoInt(value1);
            int second = ConverttoInt(value2);
            int result = 0;
            if (oper == "+")
            {
                result = first + second;

            }

            else if (oper == "-")
            {
                result = first - second;
            }
            else if (oper == "*")
            {
                result = first * second;
            }
            return result.ToString();
        }
    }
}
