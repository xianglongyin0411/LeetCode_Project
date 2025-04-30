namespace LeetCode
{
    public class productExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] answer = new int [n];
            
            
            int[] L = new int [n];
            L[0] = 1;
            for(int i = 1; i < n; i++)
            {
                L[i] = L[i - 1] * nums[i - 1];
            }

            int[] R = new int [n];
            R[n - 1] = 1;
            for(int i = n - 2; i >= 0; i--)
            {
                R[i] = R[i + 1] * nums[i + 1];
            }
            for(int i = 0; i < n; i++)
            {
                answer[i] = L[i] * R[i];
            }
            return answer;
        }
    }

    // public static class Program
    // {
    //     public static void Main(string[] args)
    //     {

    //     }
    // }
}