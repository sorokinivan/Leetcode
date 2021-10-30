using System;
using System.Linq;
using System.Text;

namespace Task6Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Reverse(123);
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }
        public static int Reverse(int x)
        {
            if (x / 10 == 0)
                return x;
            var intString = x.ToString();
            var stringResult = new string((intString.ToCharArray().Reverse()).ToArray());
            int result;
            try
            {
                result = Convert.ToInt32(stringResult);
            }
            catch (OverflowException ex)
            {
                return 0;
            }
            return result;
        }
    }
}
