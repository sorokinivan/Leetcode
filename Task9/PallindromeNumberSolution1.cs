using System;
using System.Linq;

namespace PallindromeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            IsPalindrome(121);
            Console.WriteLine("Hello World!");
        }

        public static bool IsPalindrome(int x)
        {
            var intString = x.ToString();
            return intString.Equals(new string((intString.ToCharArray().Reverse()).ToArray()));
        }
    }
}
