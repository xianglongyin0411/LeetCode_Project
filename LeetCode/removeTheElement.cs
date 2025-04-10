namespace LeetCode;

public class removeTheElement
{
    public int RemoveElement(int[] nums, int val) 
    {
        int k = 0; // 记录不等于 val 的元素数量
        
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[k] = nums[i];
                k++;
            }
        }
        
        return k;
    }
}
