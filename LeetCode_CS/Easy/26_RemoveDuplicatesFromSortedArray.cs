using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS.Easy
{
    internal class _26_RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {

            int ResultArray_CurrentIndex = 0;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != nums[ResultArray_CurrentIndex])
                {
                    ResultArray_CurrentIndex++;
                    nums[ResultArray_CurrentIndex] = nums[i];
                }

            }


            Console.WriteLine(ResultArray_CurrentIndex.ToString());
            Console.WriteLine("----------");
            foreach (int i in nums)
            {
                Console.WriteLine(i.ToString());
            }
            return ResultArray_CurrentIndex + 1;
        }
    }
}
