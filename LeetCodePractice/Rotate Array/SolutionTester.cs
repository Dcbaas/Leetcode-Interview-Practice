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
//            PrintList(ref test);
            solution.Rotate(test, k);

            
            PrintList(ref test);


        }

        private static void PrintList(ref int[] nums)
        {
            foreach (var number in nums)
            {
                Console.Write(number +", ");
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
