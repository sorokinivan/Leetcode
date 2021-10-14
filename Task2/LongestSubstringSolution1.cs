using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LengthOfLongestSubstring("abba");
            Console.WriteLine(result);
        }

        public static int LengthOfLongestSubstring(string s)
        {
            string test = "";
            int maxLength = -1;
            if (String.IsNullOrEmpty(s))
                return 0;
            if (s.Length == 1)
                return 1;
            foreach (var c in s)
            {
                string currentChar = c.ToString();
                if (test.Contains(currentChar))
                    test = test.Substring(test.IndexOf(currentChar) + 1);
                test = test + currentChar;
                maxLength = Math.Max(test.Length, maxLength);
            }
            return maxLength;
        }
    }
}
