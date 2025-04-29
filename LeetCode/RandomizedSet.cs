namespace LeetCode
{
    public class RandomizedSet
    {
        IList<int> nums;
        Dictionary<int, int> indices;
        Random random;
        public RandomizedSet()
        {
            nums = new List<int>();
            indices = new Dictionary<int, int>();
            random = new Random();
        }
        public Boolean Insert(int val)
        {
            if(indices.ContainsKey(val))
            {
                return false;
            }
            int index = nums.Count;
            nums.Add(val);
            indices.Add(val, index);
            return true;
        }
        public Boolean Remove(int val)
        {
            if(!indices.ContainsKey(val))
            {
                return false;
            }
            int index = indices[val];
            int last = nums[nums.Count - 1];
            nums[index] = last;
            indices[last] = index;

            nums.RemoveAt(nums.Count - 1);
            indices.Remove(val);
            return true;
        }
        public int GetRandom()
        {
            int randomIndex = random.Next(nums.Count);
            return nums[randomIndex];
        }
    }
    // public static class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         RandomizedSet randomizedSet = new RandomizedSet();
    //         Console.WriteLine(randomizedSet.Insert(1)); // 输出: true
    //         Console.WriteLine(randomizedSet.Insert(2)); // 输出: true
    //         Console.WriteLine(randomizedSet.GetRandom()); // 随机输出: 1 或 2
    //         Console.WriteLine(randomizedSet.Remove(1)); // 输出: true
    //         Console.WriteLine(randomizedSet.Remove(1)); // 输出: false
    //     }
    // }
}
