using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class _2706_Buy_Two_Chocolates
    {
        public int BuyChoco(int[] prices, int money)
        {
            //Trivial solution: Sort() prices, check two first prices.

            var firstPrice = int.MaxValue;
            var secondPrice = int.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] < secondPrice)
                {
                    secondPrice = prices[i];
                }
                if (secondPrice < firstPrice)
                {
                    var temp = firstPrice;
                    firstPrice = secondPrice;
                    secondPrice = temp;
                }
            }

            if (firstPrice + secondPrice <= money)
            {
                return money - firstPrice - secondPrice;
            }

            return money;
        }
    }
}
