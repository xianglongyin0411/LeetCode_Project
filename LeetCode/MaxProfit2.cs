using System.IO.Pipes;

public class MaxProfit2 
{
    public int maxProfit2(int[] price)
    {
        int maxProfit = 0;
        int Profit = 0;
        int minPrice = int.MaxValue;

        foreach(int p in price)
        {
            if(p < minPrice)
            {
                minPrice = p;
            }
            else
            {
                Profit = p - minPrice;
                maxProfit += Profit;
                minPrice = p;
            }
        }

        return maxProfit;
    }
    public static void Main(string[] args)
    {
        int[] price = { 1, 2, 3, 4, 5}; // 输入数组
        MaxProfit2 solution = new MaxProfit2();
        int result = solution.maxProfit2(price); // 调用 maxProfit2 方法
        Console.WriteLine("最大利润为: " + result); // 输出结果
    }
}