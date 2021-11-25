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
            var sign = 1;
            string processedString = s.TrimStart(' ');
            if(processedString[0]=='+')
                processedString = processedString.Substring(1);
            else if(processedString[0] == '-')
            {
                sign = -1;
                processedString = processedString.Substring(1);
            }
            int i = 0;
            while(i<processedString.Length && processedString[i] >= '0' && processedString[i] <= '9')
            {
                i++;
            }
            var result = processedString.Substring(0, i);
            int intResult;
            if (String.IsNullOrEmpty(result))
            {
                return 0;
            }
            try
            {
                intResult = Convert.ToInt32(result);
            }
            catch(OverflowException ex)
            {
                return sign == -1 ? Int32.MinValue : Int32.MaxValue;
            }
            return intResult * sign;
        }
    }
}
