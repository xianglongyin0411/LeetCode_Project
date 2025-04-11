public class MostElements
{
    //双循环
    // public int MajorityElement(int[] nums)
    // {

    //     int s = 0;
    //     for(int i = 0; i < nums.Length; i++)
    //     {
    //         int k = 0;
    //         for(int j = 0; j < nums.Length; j++)
    //         {
    //             if(nums[i] == nums[j])
    //             {
    //                 k++;
    //             }
    //         }
    //         if(k > nums.Length / 2)
    //         {
    //             s = nums[i];
    //             break;
    //         }
    //     }

    //     return s;
    // }
    public int MajorityElement(int[] nums)
    {
        int count = 0;
        int candidate = nums[0];

        foreach(int num in nums)
        {
            if(count == 0)
            {
                candidate = num;
            }
            count += (num == candidate) ? 1 : -1;
        }

        count = 0;
        foreach(int num in nums)
        {
            if(num == candidate)
            {
                count++;
            }
        }
        return count > nums.Length / 2 ? candidate : -1;
    }
}