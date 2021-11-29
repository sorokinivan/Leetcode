using System;

namespace ContainerWithMostWater
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = MaxArea(new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 });
            Console.WriteLine(t);
            Console.WriteLine("Hello World!");
        }

        public static int MaxArea(int[] height)
        {
            if (height == null || height.Length == 0)
                return 0;

            int left = 0, right = height.Length - 1, result = 0;

            while (left < right)
            {
                int width = height[right] < height[left] ? height[right] : height[left];

                if (result < (right - left) * width)
                    result = (right - left) * width;

                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }

            return result;
        }
    }
}
