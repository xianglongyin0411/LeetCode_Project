namespace LeetCode
{
    public class liangShuhe
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for(int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if(map.ContainsKey(complement))
                {
                    return [map[complement], i];
                }
                map[nums[i]] = i;
            }
            return [-1, -1];
        }
    }
    public static class Program
    {
        public static void Main(String[] arge)
        {
            int[] nums = {2,7,11,15};
            int target = 9;
            liangShuhe liangshuhe = new liangShuhe();
            int[] zuobiao = liangshuhe.TwoSum(nums, target);
            Console.WriteLine("两数坐标为："+ string.Join(",",zuobiao));
        }
    }
}