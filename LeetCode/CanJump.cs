public class CanJump
{
    public bool canJump(int[] nums)
    {
        int k = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(i > k) return false;
            k = Math.Max(k, i + nums[i]);
        }
        return true;
    }
}