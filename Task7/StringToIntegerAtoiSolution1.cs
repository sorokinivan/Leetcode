using System;
using System.Linq;

namespace StringToIntegerAtoi
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = MyAtoi("   -hello123");
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }
        public static int MyAtoi(string s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                return 0;
            }
            var isPositive = true;
            string processedString = String.Empty;
            if (s[0] == ' ')
            {
                processedString = s.TrimStart(' ');
            }
            else
            {
                processedString = s;
            }
            if (processedString[0] == '+')
            {
                processedString = processedString.Substring(1);
            }
            else if (processedString[0] == '-')
            {
                isPositive = false;
                processedString = processedString.Substring(1);
            }
            string result = String.Empty;
            foreach (var c in processedString)
            {
                var check = Char.IsDigit(c);
                if (!check)
                {
                    break;
                }
                else if (check)
                {
                    result += c;
                }
            }
            int intResult;
            if (String.IsNullOrEmpty(result))
            {
                return 0;
            }
            try
            {
                intResult = Convert.ToInt32(result);
            }
            catch (OverflowException ex)
            {
                return isPositive ? Int32.MaxValue : Int32.MinValue;
            }
            return isPositive ? intResult : intResult * -1;
        }
    }
}
