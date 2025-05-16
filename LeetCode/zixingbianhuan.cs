using System.Text;

namespace LeetCode
{
    public class Zixingbianhuan
    {
        public string Convert(string s, int numRows)
        {
            // int n = s.Length;
            // int m = (n + numRows - 1) / numRows;
            // int x = 0, y = 0;
            // int count = 0;
            // int S = 0;
            // char[ , ] chars = new char[numRows , n];
            // for (int i = 0; i < numRows; i++)
            // {
            //     for (int j = 0; j < n; j++)
            //     {
            //         chars[i, j] = ' ';
            //     }
            // }
            // for(int N = 0; N < n; N++)
            // {
            //     if(count < numRows)
            //     {
            //         chars[x, y] = s[S];
            //         S++;
            //         if(x < numRows - 1)
            //         {
            //             x++;
            //         }
            //         count++;               
            //     }
            //     else
            //     {
            //         y++;
            //         if(x > 0)
            //         {
            //             x--;
            //         }
            //         chars[x, y] = s[S];
            //         S++;
            //         if(x == 0)
            //         {
            //             x++;
            //             count = 1;
            //         }
            //     }
            // }
            // StringBuilder result = new StringBuilder();
            // for(int i = 0; i < numRows; i++)
            // {
            //     for(int j  = 0; j < n; j++)
            //     {
            //         if(chars[i, j] != ' ')
            //         {
            //             result.Append(chars[i, j]);
            //         }
            //     }
            // }
            // return result.ToString();

            // if (numRows < 2) return s;
            // List<StringBuilder> rows = new List<StringBuilder>();
            // for (int j = 0; j < numRows; j++)
            // { 
            //     rows.Add(new StringBuilder());
            // }
            // int i = 0, flag = -1;
            // foreach (char c in s)
            // {
            //     rows[i].Append(c);
            //     if (i == 0 || i == numRows - 1)
            //     {
            //         flag = -flag;
            //     }
            //     i += flag;
            // }
            // StringBuilder res = new StringBuilder();
            // foreach (var row in rows)
            // {
            //     res.Append(row);
            // }
            // return res.ToString();
            if (numRows < 2)
            {
                return s;
            }
            List<StringBuilder> row = new();
            for (int i = 0; i < numRows; i++)
            {
                row.Add(new StringBuilder());
            }
            int j = 0;
            int flag = -1;
            foreach (char c in s)
            {
                row[j].Append(c);
                if (j == 0 || j == numRows - 1)
                {
                    flag = -flag;
                }
                j += flag;
            }

            StringBuilder res = new();
            foreach (var rows in row)
            {
                res.Append(rows);
            }
            return res.ToString();
        }
    }
    // public static class Program
    // {
    //     public static void Main(string[] arge)
    //     {
    //         int numRows = 3;
    //         string s = "PAYPALISHIRING";
    //         Zixingbianhuan zixingbianhuan = new();
    //         string zixing = zixingbianhuan.Convert(s, numRows);
    //         Console.WriteLine("zixing:" + zixing);
    //     }
    // }
}