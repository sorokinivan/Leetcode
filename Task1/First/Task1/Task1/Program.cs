using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };
            var target = 11;
            var result = TwoSum(nums, target);
            foreach (var r in result)
            {
                Console.WriteLine(r);
            }
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[2];
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if ((nums[i] + nums[j]) == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
                if (result[0] != 0 || result[1] != 0)
                    break;
            }
            return result;
        }
    }
}
