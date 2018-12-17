using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Array_Intersection
{
    class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> intersection = new List<int>();
            Array.Sort(nums1);
            Array.Sort(nums2);
        }
    }
}
