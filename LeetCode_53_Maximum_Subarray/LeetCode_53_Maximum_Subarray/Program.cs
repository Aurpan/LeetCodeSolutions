using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_53_Maximum_Subarray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { -3, -1, -8 };
            int maxSum = new Solution().MaxSubArray(nums);

            Console.WriteLine(maxSum);
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = nums[0], maxVal = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                sum += nums[i];

                if (sum < nums[i])
                {
                    sum = nums[i];
                }
                if (sum > maxVal)
                {
                    maxVal = sum;
                }
            }

            return maxVal;
        }
    }
}
