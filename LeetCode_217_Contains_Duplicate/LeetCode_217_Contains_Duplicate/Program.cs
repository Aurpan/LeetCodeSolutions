namespace LeetCode_217_Contains_Duplicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 };

            bool returnVal = new Solution().ContainsDuplicate(nums);

            Console.WriteLine(returnVal);

        }
    }

}