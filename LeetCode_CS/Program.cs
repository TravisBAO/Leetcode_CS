using LeetCode_CS.Easy;
using System;

class Program
{
    public static void Main(string[] args)
    {
        // LottoMax
        //LottoMax MyLottoMax = new();
        //MyLottoMax.Odds_calc(7, false);
        //MyLottoMax.Odds_calc(6, false);
        //MyLottoMax.Odds_calc(5, false);
        //MyLottoMax.Odds_calc(4, false);
        //MyLottoMax.Odds_calc(3, false);
        //MyLottoMax.Odds_calc(2, false);
        //MyLottoMax.Odds_calc(1, false);
        //MyLottoMax.Odds_calc(0, false);

        // LeetCode 55
        //_55_JumpGame _55_JumpGame = new _55_JumpGame();
        ////int[] SampleArray = { 2, 3, 1, 1, 4 };
        //int[] SampleArray = { 2, 5, 0, 0 };
        //bool _55_JumpGameResult = _55_JumpGame.CheckToJumpToEnd(SampleArray);
        //Console.WriteLine(_55_JumpGameResult.ToString());

        // Leetcode 21
        //{
        //    _21_MergeTwoSortedLists _21_MergeTwoSortedLists = new _21_MergeTwoSortedLists();
        //    ListNode List1_1 = new ListNode(1);
        //    ListNode List1_2 = new ListNode(2);
        //    ListNode List1_3 = new ListNode(4);
        //    List1_1.next = List1_2;
        //    List1_2.next = List1_3;

        //    ListNode List2_1 = new ListNode(1);
        //    ListNode List2_2 = new ListNode(3);
        //    ListNode List2_3 = new ListNode(4);
        //    List2_1.next = List2_2;
        //    List2_2.next = List2_3;

        //    _21_MergeTwoSortedLists.MergeTwoLists(List1_1, List2_1);
        //}

        //_26_RemoveDuplicatesFromSortedArray _26_RemoveDuplicatesFromSortedArray = new();
        //int[] Testcase_1 = { 1, 1, 2 };
        //int[] Testcase_2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        //_26_RemoveDuplicatesFromSortedArray.RemoveDuplicates(Testcase_2);

        // 27_RemoveElement
        {
            _27_RemoveElement _27_RemoveElement = new _27_RemoveElement();
            int[] nums = { 3, 2, 2, 3 };
            int val = 2;
            int return_k;
            return_k = _27_RemoveElement.RemoveElement(nums, val);
            Console.WriteLine(return_k);
        }
    }
}