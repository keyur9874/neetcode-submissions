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
    public ListNode ReverseKGroup(ListNode head, int k) {
        if (k == 1)
            return head;
        ListNode dummy = new();
        ListNode dCurr = dummy;
        ListNode curr = head;

        while (curr != null) {
            ListNode startNode = curr;
            int index = 1;
            while (index < k && curr.next != null) {
                curr = curr.next;
                index++;
            }

            if (index != k){
                dCurr.next = startNode;
                break;
            }


            ListNode next = curr.next;
            curr.next = null;
            dCurr.next = ReverseList(startNode);
            dCurr = startNode;
            curr = next;
        }

        return dummy.next;
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
