using System;

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = RomanToInt("MMIX");
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static int RomanToInt(string s)
        {
            int result = 0;
            if (s.Contains("CM"))
            {
                s = s.Replace("CM", "");
                result += 900;
            }
            if (s.Contains("CD"))
            {
                s = s.Replace("CD", "");
                result += 400;
            }
            if (s.Contains("XL"))
            {
                s = s.Replace("XL", "");
                result += 40;
            }
            if (s.Contains("XC"))
            {
                s = s.Replace("XC", "");
                result += 90;
            }
            if (s.Contains("IV"))
            {
                s = s.Replace("IV", "");
                result += 4;
            }
            if (s.Contains("IX"))
            {
                s = s.Replace("IX", "");
                result += 9;
            }
            foreach (var c in s)
            {
                switch (c)
                {
                    case 'M':
                        result += 1000;
                        break;
                    case 'D':
                        result += 500;
                        break;
                    case 'C':
                        result += 100;
                        break;
                    case 'L':
                        result += 50;
                        break;
                    case 'X':
                        result += 10;
                        break;
                    case 'V':
                        result += 5;
                        break;
                    case 'I':
                        result += 1;
                        break;
                }
            }
            
            return result;
        }
    }
}
