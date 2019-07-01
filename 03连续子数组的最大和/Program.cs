using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03连续子数组的最大和
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -12, 1, 3, -4, 2, 9 };
            Console.WriteLine(FindGreatestSumOfSubArray(nums));
            Console.ReadKey();
        }


        public static int FindGreatestSumOfSubArray(int[] nums)
        {
            int curretSum = 0;
            int MaxSum = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] <= 0)
                {
                    curretSum = 0;
                }
                else
                {
                    curretSum += nums[i];
                }
                if (curretSum>MaxSum)
                {
                    MaxSum = curretSum;
                }
            }
            return MaxSum;
        }

    }
}
