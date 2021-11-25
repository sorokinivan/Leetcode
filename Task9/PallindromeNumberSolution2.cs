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
            if (x < 0 || (x != 0 && x % 10 == 0))
                return false;
            int reverse = 0;

            while (x > reverse)
            {
                reverse = reverse * 10 + x % 10;
                x = x / 10;
            }

            return (x == reverse || x == reverse / 10);
        }
    }
}
