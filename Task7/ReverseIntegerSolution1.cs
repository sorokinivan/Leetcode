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
            char[] array = x.ToString().ToArray();
            string stringResult = "";
            if (array.Contains('-'))
            {
                stringResult += '-';
                array = array.Where(x => x != '-').ToArray();
            }
            foreach(var res in array.Reverse())
            {
                stringResult += res;
            }
            var result = Convert.ToInt64(stringResult);
            if (result > Int32.MaxValue || result < Int32.MinValue)
                return 0;
            return (int)result;
        }
    }
}
