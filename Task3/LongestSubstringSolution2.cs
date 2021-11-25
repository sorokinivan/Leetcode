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
            var length = s.Length;
            if (length == 0)
                return 0;
            if (length == 1)
                return 1;
            int target = 0;
            int currentMaxLength;
            int maxLength = 0;
            int i;
            Dictionary<char, int> dict = new Dictionary<char, int>() { [s[0]] = 0 };

            for (i = 1; i < length; i++)
            {
                if (!dict.TryAdd(s[i], i))
                {
                    if (dict[s[i]] >= target)
                    {
                        currentMaxLength = i - target;
                        if (maxLength < currentMaxLength)
                        {
                            maxLength = currentMaxLength;
                        }
                        target = dict[s[i]] + 1;
                    }
                    dict[s[i]] = i;
                }
            }
            if (maxLength < i - target)
            {
                maxLength = i - target;
            }
            return maxLength;
        }
    }
}
