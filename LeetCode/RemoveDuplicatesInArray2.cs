public class RemoveDuplicatesInArray2 {
    public int RemoveDuplicates2(int[] nums) {
        if(nums.Length <= 2) return nums.Length;
        int k = 2;
        for(int i = 2; i < nums.Length; i++)
        {
            if(nums[i] != nums[k - 2])
            {
                nums[k] = nums[i];
                k++;
            }
        }
        return k;
    }
}