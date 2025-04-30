using System.Data;

namespace LeetCode
{
    public class Solution
    {
        // public int CanCompleteCircuit(int[] gas, int[] cost)
        // {
        //     int n = 2*gas.Length;
        //     int j = 0;
        //     int h = 0;
        //     int Gas = 0;
        //     int count = 0;
        //     int[] TwoGas = new int[n];
        //     int[] TwoCost = new int[n];
        //     for(int i = 0; i < gas.Length; i++)
        //     {
        //         TwoGas[i] = gas[i];
        //         TwoCost[i] = cost[i];           
        //     }
        //     for(int i = gas.Length; i < n; i++)
        //     {
        //         TwoGas[i] = gas[j];
        //         TwoCost[i] = cost[j];
        //         j++;
        //     }
        //     for(int i = 0; i < n - 1; i++)
        //     {
        //         Gas = TwoGas[i] + h;
        //         if(Gas >= TwoCost[i])
        //         {
        //             h = Gas - TwoCost[i];
        //             count++;
        //             if(count == gas.Length)
        //             {
        //                 return i - gas.Length + 1;
        //             }
        //         }
        //         else
        //         {
        //             h = 0;
        //             Gas = 0;
        //             count = 0;
        //         }
        //     }
        //     return -1;
        // }
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            int totalTank = 0; // 总油量
            int currTank = 0;  // 当前油量
            int startStation = 0; // 起点加油站

            for (int i = 0; i < gas.Length; i++)
            {
                totalTank += gas[i] - cost[i];
                currTank += gas[i] - cost[i];

                // 如果当前油量不足，重置起点
                if (currTank < 0)
                {
                    startStation = i + 1; // 从下一个加油站重新开始
                    currTank = 0; // 重置当前油量
                }
            }

            // 如果总油量 >= 0，说明可以完成一圈，否则返回 -1
            return totalTank >= 0 ? startStation : -1;
        }
    }
    // public static class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Solution cancom = new Solution();
    //         int[] gas = {1,2,3,4,5};
    //         int[] cost = {3,4,5,1,2};
    //         int h = cancom.CanCompleteCircuit(gas, cost);
    //         Console.WriteLine("加油站为："+ h);
    //     }
    // }
}