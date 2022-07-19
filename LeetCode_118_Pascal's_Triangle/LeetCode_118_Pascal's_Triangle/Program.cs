using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_118_Pascal_s_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRows = 5;

            var result = new Solution().Generate(numRows);
        }

        public class Solution
        {
            public IList<IList<int>> Generate(int numRows)
            {
                IList<IList<int>> retVal = null;


                if (numRows < 2)
                    return [[1]];


                return retVal; 
            }
        }
    }
}
