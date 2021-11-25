using System;

namespace _3SumClosest
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = ThreeSumClosest(new int[] { -1, 2, 1, -4 }, 1);
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static int ThreeSumClosest(int[] nums, int target)
        {
            int result = 0;
            int intermadiateResult = 0;
            for()
            {
                foreach(var num2 in nums)
                {
                    foreach (var num3 in nums)
                    {
                        intermadiateResult = num + num2 + num3;
                        if (intermadiateResult - target > result)
                            result = intermadiateResult;
                    }
                }
            }
            return result;
        }
    }
}
