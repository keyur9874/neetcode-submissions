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
        ListNode prev = null, slow = head, fast = head;

        while (fast != null && fast.next != null) {
            prev = slow;
            slow = slow.next;
            fast = fast.next.next;
        }
        prev.next = null;
        ListNode reverseHead = ReverseList(slow);
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        // ListNode curr1 = he, curr1 = reverseHead;
        while (head != null && reverseHead != null) {
            curr.next = head;
            head = head.next;
            curr = curr.next;
            curr.next = reverseHead;
            reverseHead = reverseHead.next;
            curr = curr.next;
        }
        head = dummy.next;
        // return dummy.next;
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
