using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_566_Reshape_the_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            //int r = 0, c = 0;
            //int[2][] mat = { { 1, 2 }, { 3, 4 } };

            //var x = new Solution().MatrixReshape(mat, r, c);
            //Console.Write("");
        }
    }

    public class Solution
    {
        public int[][] MatrixReshape(int[][] mat, int r, int c)
        {
            int m = mat.Length;
            int n = mat[0].Length;

            if (m * n != r * c)
            {
                return mat;
            }

            int[][] result = new int[r][];
            int index, a, b;
            for (int i = 0; i < r; i++)
            {
                int[] mid = new int[c];
                for (int j = 0; j < c; j++)
                {
                    index = i * c + j;
                    a = index / n;
                    b = index - a * n;
                    mid[j] = mat[a][b];
                }
                result[i] = mid;
            }

            return result;
        }
    }
}
