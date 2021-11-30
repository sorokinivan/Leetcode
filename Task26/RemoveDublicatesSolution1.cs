using System;

namespace RemoveDublicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = RemoveDuplicates(new int[] { 1, 1, 2 });
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static int RemoveDuplicates(int[] nums)
        {
            var length = nums.Length;

            if(length == 0)
            {
                return 0;
            }

            var result = 1;

            if (length == 1)
            {
                return result;
            }

            var currentElement = nums[0];
            

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != currentElement)
                {
                    nums[result] = nums[i];
                    currentElement = nums[i];
                    result++;
                }
            }

            return result;
        }
    }
}
