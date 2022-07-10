using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_88_Merge_Sorted_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 1, n = 1;
            int[] nums1 = { 2, 0 };
            int[] nums2 = { 1 };

            new Solution().Merge(nums1, m, nums2, n);
        }
    }

    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int len = m + n;

            for (int i = 0; i < n; i++)
            {
                nums1[m + i] = nums2[i];
            }
            Array.Sort(nums1);
        }
    }
}
