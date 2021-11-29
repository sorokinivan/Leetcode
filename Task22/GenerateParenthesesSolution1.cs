using System;
using System.Collections.Generic;

namespace GenerateParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        List<string> result = new List<string>();

        public IList<string> GenerateParenthesis(int n)
        {
            Generate("", 0, 0, n);
            return result;
        }

        private void Generate(string s, int left, int right, int n)
        {

            if (left == right && left == n)
            {
                result.Add(s);
                return;
            }
            if (left < n)
                Generate(s + "(", left + 1, right, n);
            if (right < left)
                Generate(s + ")", left, right + 1, n);
        }
    }
}
