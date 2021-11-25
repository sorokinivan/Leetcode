using System;
using System.Collections.Generic;

namespace ValidParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
			var t = isValid("()");
			Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

		public static bool isValid(String s)
		{
			var stack = new Stack<char>();

			foreach(var c in s)
			{
				if (c == '(')
					stack.Push(')');
				else if (c == '{')
					stack.Push('}');
				else if (c == '[')
					stack.Push(']');
				else if (stack.Count == 0 || stack.Pop() != c)
					return false;
			}
			return stack.Count == 0;
		}
	}
}
