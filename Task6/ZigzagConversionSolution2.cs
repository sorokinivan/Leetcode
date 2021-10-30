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

            var isBackDirection = false;
            var internalCounter = 0;
            var rows = new List<StringBuilder>();
            var result = new StringBuilder();

            for (int i = 0; i < numRows; i++)
            {
                rows.Add(new StringBuilder());
            }
            foreach (var c in s)
            {
                if (internalCounter == numRows - 1)
                    isBackDirection = true;
                else if (internalCounter == 0)
                    isBackDirection = false;

                rows[internalCounter].Append(c);

                if (isBackDirection == true)
                    internalCounter--;
                else
                    internalCounter++;
            }
            
            foreach (var row in rows)
            {
                result.Append(row);
            }
            return result.ToString();
        }
    }
}
