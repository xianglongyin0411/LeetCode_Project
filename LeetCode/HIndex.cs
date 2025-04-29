using System.Reflection;

namespace LeetCode
{
    public class HIndex
    {
        // public int hIndex(int[] citations)
        // {
        //     int hindex = 0;
        //     int h = 0;
        //     int count = 0;
        //     int hmax = 0;
        //     for(int i = 0; i < citations.Length; i++)
        //     {
        //         hmax = Math.Max(hmax, citations[i]);
        //     }
        //     h = hmax;
        //     for(int i = 0; i < hmax; i++)
        //     {
                
        //         for(int j = 0; j < citations.Length; j++)
        //         {

        //             if(citations[j] >= h)
        //             {
        //                 count++;
        //             }
        //             if(count >= h)
        //             {
        //                 int Hindex = h;
        //                 return  Hindex;
        //             }
        //         }
        //         hindex = count;
        //         h--;
        //         count = 0;
        //     }
        //     return  hindex;
        // }

        // public int hIndex(int[] citations)
        // {
        //     Array.Sort(citations);
        //     int h = 0;
        //     int H = 0;
        //     int hindex;

        //     if(citations[0] > citations.Length)
        //     {
        //         hindex = citations.Length;
        //     }
        //     else{
        //         for(int i = 0; i < citations.Length; i++)
        //         {
        //             if(citations[i] <= citations.Length - i)
        //             {
        //                 h = citations[i];
        //             }
        //             else
        //             {
        //                 H = citations.Length - i;
        //                 break;
        //             }
        //         }
        //         hindex = Math.Max(H, h);
        //     }
        //     return hindex;
        // }

        public int hIndex(int[] citations)
        {
            Array.Sort(citations);
            int h = 0, i = citations.Length - 1; 
            while (i >= 0 && citations[i] > h) {
                h++; 
                i--;
            }
            return h;
        }
    }
    public static class Program
    {
        public static void Main(string[] args)
        {
            int[] citations = {4,4,0,0};
            HIndex hIndex = new HIndex();
            int h_Index = hIndex.hIndex(citations);
            Console.WriteLine("最大h指数："+ h_Index);
        }
    }
}
 