public class RotateTheArray
{
    //超出时间限制
    // public void Rotate(int[] nums, int k)
    // {
    //     for(int i = 0; i < k; i++)
    //     {
    //         int x = nums[nums.Length - 1];
    //         for(int m = nums.Length - 2; m >= 0; m--)
    //         {
    //             nums[m + 1] = nums[m];
    //         }
    //         nums[0] = x;
    //     }
    // }
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k %= n;

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    public void Reverse(int[] nums, int start, int end)
    {
        while(start < end)
        {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}
