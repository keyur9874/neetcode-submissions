/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        if (head == null)
            return null;
        Node curr = head;

        while (curr != null) {
            Node newNode = new Node(curr.val);
            newNode.next = curr.next;
            curr.next = newNode;
            curr = newNode.next;
        }

        Node newHead = head.next;
        curr = head;
        while (curr != null) {
            Node newNode = curr.next;
            if (curr.random != null) {
                newNode.random = curr.random.next;
            }
            curr = newNode.next;
        }

        curr = head;

        while (curr != null) {
            Node newNode = curr.next;
            curr.next = newNode.next;
            // if (curr.next != null)
            newNode.next = curr.next?.next;
            curr = curr.next;
        }

        return newHead;
    }
}
