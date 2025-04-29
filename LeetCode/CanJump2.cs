public class CanJump2
{
    public int Jump(int[] nums)
    {
        int count = 0; // 跳跃次数
        int maxReach = 0; // 当前能到达的最远位置
        int end = 0; // 当前跳跃的边界
        for (int i = 0; i < nums.Length - 1; i++)
        {
            maxReach = Math.Max(maxReach, i + nums[i]); // 更新能到达的最远位置
            if (i == end) // 到达当前跳跃的边界
            {
                count++; // 增加跳跃次数
                end = maxReach; // 更新边界为最远位置
                if (end >= nums.Length - 1) // 如果已经可以到达最后一个位置，提前退出
                {
                    break;
                }
            }
        }
        return count;
    }

    // public static void Main(string[] args)
    // {
    //     int[] nums = { 2, 3, 1, 1, 4 }; // 输入数组
    //     CanJump2 solution = new CanJump2();
    //     int result = solution.Jump(nums);
    //     Console.WriteLine("最小跳跃次数：" + result);
    // }
}