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
				if (c == '('
					|| c == '{'
					|| c == '[')
					stack.Push(c);
				else
				{
					if (stack.Count == 0
						|| (stack.Peek() == '(' && c != ')')
						|| (stack.Peek() == '{' && c != '}')
						|| (stack.Peek() == '[' && c != ']'))
						return false;
					stack.Pop();
				}

			}
			return stack.Count == 0;
		}
	}
}
