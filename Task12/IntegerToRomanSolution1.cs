using System;

namespace IntegerToRoman
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = IntToRoman(3242);
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static string IntToRoman(int num)
        {
            int[] numbers = new int[] { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = new string[] { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = String.Empty;

            for(int i = 0; i < romans.Length; i++)
            {
                if (num <= 0)
                    break;
                while(num-numbers[i] >= 0)
                {
                    num -= numbers[i];
                    result += romans[i];
                }
            }

            return result;
        }
    }
}
