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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carry = 0;
        ListNode dummy = new ListNode();
        ListNode curr = dummy;
        ListNode curr1 = l1;
        ListNode curr2 = l2;

        while (curr1 != null && curr2 != null) {
            int sum = curr1.val + curr2.val + carry;

            ListNode newNode = new ListNode(sum % 10);
            carry = sum / 10;
            curr.next = newNode;
            curr = newNode;
            curr1 = curr1.next;
            curr2 = curr2.next;
        }
        curr1 = curr1 == null ? curr2 : curr1;
        while (curr1 != null) {
            int sum = curr1.val + carry;
            ListNode newNode = new ListNode(sum % 10);
            carry = sum / 10;
            curr.next = newNode;
            curr = newNode;
            curr1 = curr1.next;
        }

        if (carry > 0) {
            ListNode newNode = new ListNode(carry);
            curr.next = newNode;
        }
        return dummy.next;
    }
}
