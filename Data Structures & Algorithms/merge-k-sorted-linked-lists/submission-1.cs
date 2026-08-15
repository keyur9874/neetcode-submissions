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
    public ListNode MergeKLists(ListNode[] lists) {
        if (lists.Length == 0)
            return null;
        int interval = 1;

        while (interval < lists.Length) {
            for (int i = 0; (i + interval) < lists.Length; i += interval * 2) {
                lists[i] = MergeSortedList(lists[i], lists[i + interval]);
            }
            interval *= 2;
        }

        return lists[0];
    }

    private ListNode MergeSortedList(ListNode head1, ListNode head2) {
        ListNode dummy = new();
        ListNode curr = dummy;

        while (head1 != null && head2 != null) {
            if (head1.val <= head2.val) {
                curr.next = head1;
                head1 = head1.next;
            } else {
                curr.next = head2;
                head2 = head2.next;
            }
            curr = curr.next;
        }

        if (head1 != null) {
            curr.next = head1;
        }

        if (head2 != null) {
            curr.next = head2;
        }

        return dummy.next;
    }
}
