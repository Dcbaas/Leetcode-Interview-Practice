using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Rotate_Array
{
    class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = nums[nums.Length - 1];
                for (int j = nums.Length - 1; j >= 0; j--)
                {
                    if (j == 0)
                    {
                        break;
                    }

                    nums[j] = nums[j - 1];
                }

                nums[0] = temp;
            }

        }
    }
}
