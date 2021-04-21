using System;
using System.Text;
using System.Text.RegularExpressions;

namespace ReverseWordOrder
{
    public class WordReverser
    {

        public static string ReverseWords(string input)
        {
            var reverse = "";
            string[] split = input.Split(' ');

            for (int i = split.Length-1; i >= 0; i--)
            {
                reverse += split[i] + " ";
               
            }

            return reverse.Trim();
        }

    }
}
