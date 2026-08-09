/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        ListNode curr1 = list1, curr2 = list2;
        while (curr1 != null && curr2 != null) {
            if (curr1.val < curr2.val) {
                curr.next = curr1;
                curr1 = curr1.next;
            } else {
                curr.next = curr2;
                curr2 = curr2.next;
            }

            curr = curr.next;
        }

        if (curr1 != null) {
            curr.next = curr1;
        }

        if (curr2 != null) {
            curr.next = curr2;
        }

        return dummy.next;
    }
}