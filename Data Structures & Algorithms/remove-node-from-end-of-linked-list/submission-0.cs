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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        int nodeCount = 0;
        ListNode curr = head;        
        while(curr != null){
            nodeCount++;
            curr = curr.next;
        }

        if(nodeCount == n)
            return head.next;
        curr = head;
        for(int i=0; i<(nodeCount-n-1); i++){
            curr = curr.next;
        }

        curr.next = curr.next.next;
        return head;
    }
}
