using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_217_Contains_Duplicate
{
    public class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> hashNums = new HashSet<int>();
            hashNums.Add(nums[0]);

            for (int i = 1; i < nums.Length; i++)
            {
                if (hashNums.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    hashNums.Add(nums[i]);
                }
            }
            return false;
        }
    }
}
