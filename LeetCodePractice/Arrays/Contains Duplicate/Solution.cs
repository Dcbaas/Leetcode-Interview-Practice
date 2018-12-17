using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePractice.Contains_Duplicate
{
    class Solution
    {
        public bool ContainsDuplicate(int[] nums)
        {
            SortedSet<int> found_items = new SortedSet<int>();
            foreach (var i in nums)
            {
                if (!found_items.Add(i))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
