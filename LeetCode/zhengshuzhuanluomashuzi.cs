using System.Text;

namespace LeetCode
{
    public class IntToRomanA{
        readonly Tuple<int, string>[] valueSymbols = {
            new Tuple<int, string>(1000, "M"),
            new Tuple<int, string>(900, "CM"),
            new Tuple<int, string>(500, "D"),
            new Tuple<int, string>(400, "CD"),
            new Tuple<int, string>(100, "C"),
            new Tuple<int, string>(90, "XC"),
            new Tuple<int, string>(50, "L"),
            new Tuple<int, string>(40, "XL"),
            new Tuple<int, string>(10, "X"),
            new Tuple<int, string>(9, "IX"),
            new Tuple<int, string>(5, "V"),
            new Tuple<int, string>(4, "IV"),
            new Tuple<int, string>(1, "I")
        };

        public string IntToRoman(int num) {
            StringBuilder roman = new StringBuilder();
            foreach(Tuple<int, string> tuple in valueSymbols)
            {
                int value = tuple.Item1;
                string symbol = tuple.Item2;
                while(num >= value)
                {
                    num -= value;
                    roman.Append(symbol);
                }
                if(num == 0)
                {
                    break;
                }
            }
            return roman.ToString();
        }
    }
}