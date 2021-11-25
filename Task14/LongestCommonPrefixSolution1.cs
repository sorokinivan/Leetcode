using System;
using System.Text;

namespace LongestPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
			var t = LongestCommonPrefix(new string[] { "flower", "flow", "flight" });
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static string LongestCommonPrefix(string[] strs)
        {


            string result = "";
            var length = strs.Length;
            if (length == 0)
                return result;
            if (strs.Length == 1)
                return strs[0];
            Array.Sort(strs);

            var array1 = strs[0].ToCharArray();
            var array2 = strs[length - 1].ToCharArray();

            for (int i = 0; i < array1.Length; i++)
            {
                if (array2.Length > i && array2[i] == array1[i])
                {
                    result += array2[i];
                }
                else
                {
                    return result;
                }
            }
            return result;
        }
    }
}
