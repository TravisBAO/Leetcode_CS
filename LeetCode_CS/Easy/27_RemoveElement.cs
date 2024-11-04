using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS.Easy
{
    internal class _27_RemoveElement
    {
        public int RemoveElement(int[] nums, int val)
        {
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[j] = nums[i];
                    j++;
                }
            }
            return j;
        }
    }
}
