namespace LeetCode
{
    public class Zuihouzimuchangdu
    {
        public int LengthOfLastWord(string s)
        {
            // string[] words = s.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            // if(words.Length == 0)
            // {
            //     return 0;
            // }
            // return words[words.Length - 1].Length;
            int index = s.Length - 1;
            while(s[index] == ' ')
            {
                index--;
            }
            int wordLength = 0;
            while(index >= 0 && s[index] != ' ')
            {
                wordLength++;
                index--;
            }
            return wordLength;
        }
    }
}