using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _50_My_Pow
    {
        public double MyPow(double x, int n)
        {
            double result = 1;
            if (n == 0) return result;

            if (n < 0)
            {
                n = Math.Abs(n);
                x = 1 / x;
            }

            double product = x;

            while(n > 0)
            {
                if (n % 2 == 1)
                {
                    result = result * product;
                }
                product = product * product;
                n = n / 2;
            }

            return result;

        }
    }
}
