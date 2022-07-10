using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_350._Intersection_of_Two_Arrays_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 4, 9, 5 };
            int[] nums2 = { 9, 4, 9, 8, 4 };

            int[] returnVal = new Solution().Intersect(nums1, nums2);
            Console.Write("");
        }
    }

    public class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> liValues = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
            int m = nums1.Length - 1;
            int n = nums2.Length - 1;

            while (m >= 0 && n >=0)
            {
                if (nums1[m] == nums2[n])
                {
                    liValues.Add(nums1[m]);
                    m--;
                    n--;
                }
                else if (nums1[m] < nums2[n])
                {
                    n--;
                }
                else if (nums1[m] > nums2[n])
                {
                    m--;
                }
            }

            return liValues.ToArray();
        }
    }
}
