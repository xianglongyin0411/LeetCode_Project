using System.Security.Cryptography.X509Certificates;

namespace LeetCode
{
    public class LuoMaShuZi
    {
        Dictionary<char, int> values = new Dictionary<char, int>
            {
                {'I', 1}, {'V', 5}, {'X', 10}, {'L', 50}, {'C', 100}, {'D', 500}, {'M', 1000},
            };
        public int RomanToInt(string s)
        {
            int x = 0;
            for(int i = 0; i < s.Length; i++)
            {
                int value = values[s[i]];
                if(i < s.Length - 1 && value < values[s[i + 1]])
                {
                    x -= value;
                }
                else
                {
                    x += value;
                }
            }
            return x;
        }
    }
}