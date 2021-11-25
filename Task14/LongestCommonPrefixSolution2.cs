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
            var length = strs.Length;
            if (length == 0)
                return "";
            Array.Sort(strs);
            var index = 0;
            for(int i = 0; i < length; i++)
            {
                if (strs[i].Length <= index || strs[i][index] != strs[0][index])
                    break;
                if(i == length - 1)
                {
                    index++;
                    i = -1;
                }
                    
            }
            return strs[0].Substring(0, index);
        }
    }
}
