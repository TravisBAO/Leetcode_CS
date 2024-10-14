using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_CS
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _21_MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode List1, ListNode List2)
        {
            // Create a dummy node to serve as the starting point of the merged list.
            ListNode dummy = new ListNode();
            ListNode current = dummy;

            // Iterate while both lists have elements
            while (List1 != null && List2 != null)
            {
                if (List1.val <= List2.val)
                {
                    current.next = List1; // Append List1's node
                    List1 = List1.next;   // Move to next node in List1
                }
                else
                {
                    current.next = List2; // Append List2's node
                    List2 = List2.next;   // Move to next node in List2
                }
                current = current.next;   // Move to next node in the merged List
            }

            // If any nodes are left in either list, append them to the merged List
            if (List1 != null)
            {
                current.next = List1;
            }
            else if (List2 != null)
            {
                current.next = List2;
            }

            // Return the merged list, starting from the first real node (dummy.next).
            return dummy.next;
        }
    }
}
