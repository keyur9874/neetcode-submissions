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
    public void ReorderList(ListNode head) {
        if (head == null || head.next == null || head.next.next == null)
            return;
        // 1. Find the middle of the list
        ListNode slow = head;
        ListNode fast = head.next; // Start fast one step ahead
        
        while (fast != null && fast.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        
        // 2. Split the list into two halves
        ListNode secondHalf = slow.next;
        slow.next = null; // Sever the link between halves

        ListNode reverseHead = ReverseList(secondHalf);
        ListNode curr = head;
        while (curr != null && reverseHead != null) {
            ListNode next = curr.next;
            curr.next = reverseHead;
            reverseHead = reverseHead.next;
            curr.next.next = next;
            curr = next;
        }
    }

    private ListNode ReverseList(ListNode head) {
        ListNode prev = null, curr = head;

        while (curr != null) {
            ListNode next = curr.next;
            curr.next = prev;
            prev = curr;
            curr = next;
        }

        return prev;
    }
}
