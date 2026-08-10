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
        if(head == null)
            return null;
        Dictionary<Node, Node> nodeMap = new();
        Node curr = head;
        while (curr != null) {
            Node newNode = new Node(curr.val);
            nodeMap[curr] = newNode;
            curr = curr.next;
        }

        curr = head;

        while (curr != null) {
            Node newNode = nodeMap[curr];
            if (curr.next != null) {
                newNode.next = nodeMap[curr.next];
            }

            if (curr.random != null) {
                newNode.random = nodeMap[curr.random];
            }

            curr = curr.next;
        }

        return nodeMap[head];
    }
}
