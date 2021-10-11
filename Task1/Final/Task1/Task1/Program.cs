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
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(target - nums[i]))
                {
                    result[0] = dict.GetValueOrDefault(target - nums[i]);
                    result[1] = i;
                    break;
                }
                dict.TryAdd(nums[i], i);
            }
            return result;
        }
    }
}
