using System;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using Microsoft.VisualBasic.FileIO;

namespace LeetCode
{
    public class Fanzhuanzifuchuanzhongdeanci
    {
        public string ReverseWords(string s)
        {
            int n = s.Length;
            char[] shuzu = new char[n];
            int x = 0;
            for(int i = n - 1; i >= 0; i--)
            {
                if(i > 0 && s[i] != ' ' && s[i - 1] == ' ')
                {
                    for(int j = i; j < n; j++)
                    {
                        if(s[j] != ' ')
                        {
                            shuzu[x] = s[j];
                            x++;
                        }
                        else
                        {
                            break;
                        }

                    }
                    shuzu[x] = ' ';
                    x++;
                }
                else if(i == 0 && s[0] != ' ')
                {
                    for(int j = 0; j < n; j++)
                    {
                        if(s[j] != ' ')
                        {
                            shuzu[x] = s[j];
                            x++;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return new string(shuzu, 0, x).TrimEnd();

            //调用api
            // s = s.Trim();
            // List<string> wordlist = Regex.Split(s, "\\s+").ToList();
            // wordlist.Reverse();
            // return string.Join(" ", wordlist);

            //双指针
            // int m = s.Length - 1;
            // string res = "";
            // while(m >= 0)
            // {
            //     while(m >= 0 && s[m] == ' ')
            //     {
            //         m--;
            //     }
            //     if(m < 0)
            //     {
            //         break;
            //     }

            //     int n = m;
            //     while(m >= 0 && s[m] != ' ')
            //     { 
            //         m--;
            //     }
            //     res = res + s.Substring(m + 1, n - m) + " ";
            // }
            // return res.Substring(0, res.Length - 1);
        }
    }
    // public class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         Fanzhuanzifuchuanzhongdeanci Fsddf = new();
    //         string input = "the sky is blue";
    //         string result = Fsddf.ReverseWords(input);
    //         Console.WriteLine($"Reversed words: " + result);
    //     }
    // }
}