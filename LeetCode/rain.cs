using System.Globalization;
using System.Reflection.Metadata.Ecma335;

namespace LeetCode
{
    public class jieYushui
    {
        public int Trap(int[] height)
        {
            int total = 0;
            int x = 0;
            int y = 0;
            int j;
            for(int i = 0; i < height.Length - 1; i++)
            {
                if(height[i] > height[i + 1])
                {
                    for(j = i + 2; j < height.Length; j++)
                    {
                        if(height[j] >= height[i])
                        {
                            x = j;
                            break;
                        }
                    }
                    if(x != 0)
                    {
                        for(int k = i + 1; k < x; k++)
                        {
                            total += height[i] - height[k];
                        }
                        i = j - 1;
                    }
                    x = 0;
                }
            }
            return total;
        }
    }
    // public static class Program{
    //     public static void Main(string[] arge)
    //     {
    //         int[] height = {4,2,0,3,2,5};
    //         jieYushui m = new jieYushui();
    //         int Total = m.Trap(height);
    //         Console.WriteLine("雨水：" + Total);
    //     }
    // } 
}