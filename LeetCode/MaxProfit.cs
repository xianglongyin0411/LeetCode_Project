public class maxProfit
{
    // //超出时间限制
    // public int MaxProfit(int[] price)
    // {
    //     int maxprofit = 0;
    //     int profit = 0;
    //     for(int i = 0; i < price.Length; i++)
    //     {
    //         for(int j = i + 1; j < price.Length; j++)
    //         {
    //             if(price[i] < price[j])
    //             {
    //                 profit = price[j] - price[i];
    //             }
    //             if(maxprofit < profit)
    //             {
    //                 maxprofit = profit;
    //             }
    //         }
    //     }
    //     return maxprofit;
    // }

        public int MaxProfit(int[] price)
    {
        int maxprofit = 0;
        int minPrice = int.MaxValue;

        foreach(int p in price)
        {
            if(p < minPrice)
            {
                minPrice = p;
            }
            else if(p - minPrice > maxprofit)
            {
                maxprofit = p - minPrice;
            }
        }

        return maxprofit;
    }
}