using System;
using System.Linq;

namespace Task5Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LongestPalindrome("aacabdkacaa");
            Console.WriteLine(t);
        }

        public static string LongestPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
                return "";
            if (s.Length == 1)
                return s;
            var length = s.Length;
            var minStart = 0;
            var maxLength = 1;
            for (var i = 0; i < length;)
            {
                if (length - i <= maxLength / 2)
                    break;
                var j = i;
                var k = i;
                while (k < length - 1 && s[k + 1] == s[k])
                    ++k;
                i = k + 1;
                while (k < length - 1 && j > 0 && s[k + 1] == s[j - 1])
                {
                    ++k;
                    --j;
                }
                var newLength = k - j + 1;
                if (newLength > maxLength)
                {
                    minStart = j;
                    maxLength = newLength;
                }
            }
            return s.Substring(minStart, maxLength);
    }
        }
    }
}
