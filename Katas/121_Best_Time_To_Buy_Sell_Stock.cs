namespace Katas
{
    public class _121_Best_Time_To_Buy_Sell_Stock
    {
        public int MaxProfit(int[] prices)
        {
            var buyAt = 0;
            var profit = 0;

            while (buyAt < prices.Length) 
            { 
                for (var i = buyAt + 1; i < prices.Length; i++)
                {
                    if (prices[i] > prices[buyAt])
                    {
                        profit = Math.Max(profit, prices[i] - prices[buyAt]);
                    }
                    else
                    {
                        buyAt = i;
                    }
                    
                }
                buyAt++;
            }

            return profit;
        }
    }
}
