using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_1_Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int target = 4;
            int[] nums = { 3, 3, 3, 3, 1 };

            nums = new Solution().TwoSum(nums, target);
            Console.WriteLine("{0},{1}",nums[0], nums[1]);
        }
    }

    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            dictionary.Add(nums[0], 0);

            for (int i = 1; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(target - nums[i]))
                {
                    result[0] = i;
                    result[1] = dictionary[target - nums[i]];
                    break;
                }
                else if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], i);
                }
            }

            return result;
        }
    }
}
