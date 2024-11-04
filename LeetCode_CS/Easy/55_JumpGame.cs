using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS.Easy
{
    internal class _55_JumpGame
    {
        public bool CheckToJumpToEnd(int[] SampleArray)
        {
            int ArrayLength = SampleArray.Length;
            int ElementValue;
            int TargetElement_Index = ArrayLength - 1;
            bool IsAbleToReachLastIndex = false;

            for (int i = ArrayLength - 2; i >= 0; i--)
            {
                ElementValue = SampleArray[i];
                if (ElementValue >= TargetElement_Index - i)
                {
                    IsAbleToReachLastIndex = true;
                    TargetElement_Index--;
                }
                else
                {
                    //pass
                }
            }
            return IsAbleToReachLastIndex;
        }
    }
}
