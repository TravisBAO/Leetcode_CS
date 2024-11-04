using LeetCode_CS.Easy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS.Medium
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _2_AddTwoNumbers
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummy = new ListNode();
            ListNode current = new ListNode();
            current = dummy;
            return dummy;
        }
    }
}
