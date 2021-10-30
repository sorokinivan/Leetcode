using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Zigzag
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = Convert("PAYPALISHIRING", 2);
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            var internalCounter = 0;
            var rows = new List<StringBuilder>();
            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new StringBuilder());
            }
            if (numRows == 2)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        rows[0].Append(s[i]);
                    }

                    else
                    {
                        rows[1].Append(s[i]);
                    }
                }
            }
            else
            {
                int i = 0;
                while (i < s.Length)
                {
                    do
                    {
                        rows[internalCounter].Append(s[i]);
                        i++;
                        if (i == s.Length)
                            break;
                        internalCounter++;
                    } while (internalCounter != numRows - 1);
                    if (i == s.Length)
                        break;
                    do
                    {
                        rows[internalCounter].Append(s[i]);
                        i++;
                        if (i == s.Length)
                            break;
                        internalCounter--;
                    } while (internalCounter != 0);
                }
            }
            string result = String.Empty;
            foreach (var row in rows)
            {
                result += row;
            }
            return result;
        }
    }
}
