public class HIndex
{
    public int hIndex(int[] citations)
    {
        int hindex = 0;
        int h = 0;
        int count = 0;
        int hmax = 0;
        for(int i = 0; i < citations.Length; i++)
        {
            hmax = Math.Max(hmax, citations[i]);
        }
        h = hmax;
        for(int i = 0; i < hmax; i++)
        {
            
            for(int j = 0; j < citations.Length; j++)
            {

                if(citations[j] >= h)
                {
                    count++;
                }
                if(count >= h)
                {
                    int Hindex = h;
                    return  Hindex;
                }
            }
            hindex = count;
            h--;
            count = 0;
        }
        return  hindex;
    }

    public static void Main(string[] args)
    {
        int[] citations = { 11, 15}; // 输入数组
        HIndex solution = new HIndex();
        int h_Index = solution.hIndex(citations);
        Console.WriteLine("最大h指数为: " + h_Index); 
    }
}
 