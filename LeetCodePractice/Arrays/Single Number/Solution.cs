using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Single_Number
{
    class Solution
    {
        public int SingleNumber(int[] nums)
        {
            Array.Sort(nums);
            try
            {
                for (int index = 0; index < nums.Length; index++)
                {
                    if (nums[index] != nums[index + 1])
                    {
                        return nums[index];
                    }
                    ++index;
                }
            }
            catch (IndexOutOfRangeException)
            {
            }
            

            return nums[nums.Length - 1];
        }
    }
}
