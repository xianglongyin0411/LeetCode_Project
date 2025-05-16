using System.Data;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LeetCode
{
    public class Strstr
    {
        public int StrStr(string haystack, string needle)
        {
            // int h = 0;
            // int n = 0;
            // int i;
            // int j;
            // int index = -1;
            // for (i = 0; i < needle.Length; i++)
            // {
            //     for (j = h; j < haystack.Length; j++)
            //     {
            //         if (index == -1)
            //         {
            //             index = h;
            //         }
            //         if (needle[i] == haystack[j])
            //         {
            //             h = j + 1;
            //             n++;
            //             break;
            //         }
            //         else if (needle[i] != haystack[j])
            //         {
            //             i = -1;
            //             h = index + 1;
            //             n = 0;
            //             index = 0;
            //             break;
            //         }
            //     }
            //     if (j == haystack.Length)
            //     {
            //         break;
            //     }
            // }
            // if (n != needle.Length)
            // {
            //     return -1;
            // }
            // return h - needle.Length;

            // //一行代码
            // return haystack.IndexOf(needle);

            //暴力
            // int n = haystack.Length, m = needle.Length;
            // for (int i = 0; i <= n - m; i++)
            // {
            //     Boolean flag = true;
            //     for (int j = 0; j < m; j++)
            //     {
            //         if (haystack[i + j] != needle[j])
            //         {
            //             flag = false;
            //             break;
            //         }
            //     }
            //     if (flag)
            //     {
            //         return i;
            //     }
            // }
            // return -1;

            //KMP
            int n = haystack.Length, m = needle.Length;
            if (m == 0)
            {
                return 0;
            }
            //构建next数组
            int[] next = new int[m];
            for (int i = 1, j = 0; i < m; i++)
            {
                while (j > 0 && needle[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (needle[i] == needle[j])
                {
                    j++;
                }
                next[i] = j;
            }

            for (int i = 0, j = 0; i < n; i++)
            {
                while (j > 0 && haystack[i] != needle[j])
                {
                    j = next[j - 1];
                }
                if (haystack[i] == needle[j])
                {
                    j++;
                }
                if (j == m)
                {
                    return i - m + 1;
                }
            }
            return -1;
        }
    }
    // public static class Program
    // {
    //     public static void Main(string[] arge)
    //     {
    //         string haystack = "leetcode";
    //         string needle = "cod";
    //         Strstr STR = new();
    //         int index = STR.StrStr(haystack, needle);
    //         Console.WriteLine("Index:" + index);
    //     }
    // }
}