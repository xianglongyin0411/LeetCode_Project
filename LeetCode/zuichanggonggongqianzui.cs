using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    public class Zuichanggonggongqianzhui
    {
        public string LongestCommonPrefix(string[] strs)
        {
            // if (strs == null || strs.Length == 0)
            // {
            //     return "";
            // }

            // int x = strs[0].Length;
            // for (int i = 0; i < strs.Length - 1; i++)
            // {
            //     for (int j = 0; j < Math.Min(x, strs[i + 1].Length); j++) // 确保 j 不超过 strs[i + 1] 的长度
            //     {
            //         if (strs[i][j] != strs[i + 1][j])
            //         {
            //             x = j; // 更新公共前缀长度
            //             break;
            //         }
            //     }
            //     x = Math.Min(x, strs[i + 1].Length); // 更新 x，确保不超过当前字符串长度
            //     if (x == 0)
            //     {
            //         return ""; // 如果公共前缀长度为 0，直接返回空字符串
            //     }
            // }

            // string m = strs[0];
            // string result = m.Substring(0, x); // 获取前 x 个字符
            // return result;
            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            // 对字符串数组进行排序
            Array.Sort(strs);

            string first = strs[0];
            string last = strs[strs.Length - 1];

            int i = 0;
            while (i < first.Length && i < last.Length && first[i] == last[i])
            {
                i++;
            }
            return first.Substring(0, i);
        }
    }
}