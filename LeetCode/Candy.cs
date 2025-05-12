namespace LeetCode
{
    public class Fenfatangguo
    {
        public int Candy(int[] ratings)
        {
            int total = 0;
            int n = ratings.Length;
            int[] count = new int[n];
            for(int i = 0; i < n; i++)
            {
                count[i] = 1;
            }
            for(int i = 1; i < n; i++)
            {
                if(ratings[i - 1] > ratings[i])
                {
                    count[i - 1] += 1;
                }
                else if(ratings[i - 1] < ratings[i])
                {
                    count[i] += 1;
                }
            }
            for(int i = 0; i < n; i++)
            {
                total += count[i];
            }
            return total;
        }
    }

    // public static class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         int[] ratings = {1,3,2,2,1};
    //         Fenfatangguo fenfatangguo = new Fenfatangguo();
    //         int Total = fenfatangguo.Candy(ratings);
    //         Console.WriteLine("最少糖果为：" + Total);
    //     }
    // }
}