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
            int[] temp = new int[nums.Length];
            for (var i = 0; i < nums.Length; ++i)
            {
                temp[(i + k) % nums.Length] = nums[i];
            }

            for (int i = 0; i < nums.Length; ++i)
            {
                nums[i] = temp[i];
            }

        }
    }
}
