using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Rotate_Array
{
    class SolutionTester
    {
        public static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] test = new[] {1, 2, 3, 4, 5, 6, 7};
            var k = 3;

            solution.Rotate(test, k);



        }
    }
}
