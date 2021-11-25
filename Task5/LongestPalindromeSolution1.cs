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
            int maxLength = 0;
            int maxStartIndex = 0;
            int length = s.Length;

            if (String.IsNullOrEmpty(s))
                return "";
            if (length == 1)
                return s;
            for (int i = 0; i < length; i++)
            {
                int currentIndex = i;

                for (int lastIndex = length - 1; lastIndex > currentIndex; lastIndex--)
                {
                    if (lastIndex - currentIndex + 1 < maxLength)
                    {
                        break;
                    }

                    bool isPalindrome = true;

                    if (s[currentIndex] != s[lastIndex])
                    {
                        continue;
                    }
                    else
                    {
                        int matched = lastIndex - 1;

                        for (int nextCharIndex = currentIndex + 1; nextCharIndex < matched; nextCharIndex++)
                        {
                            if (s[nextCharIndex] != s[matched])
                            {
                                isPalindrome = false;
                                break;
                            }
                            matched--;
                        }
                    }

                    if (isPalindrome)
                    {
                        if (lastIndex + 1 - currentIndex > maxLength)
                        {
                            maxStartIndex = currentIndex;
                            maxLength = lastIndex + 1 - currentIndex;
                        }
                        break;
                    }
                }
            }

            if (maxLength > 0)
            {
                return s.Substring(maxStartIndex, maxLength);
            }

            return s[0].ToString();
        }
    }
}
