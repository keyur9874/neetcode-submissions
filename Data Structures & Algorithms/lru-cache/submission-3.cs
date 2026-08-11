public class LRUCache {
    private class ListNode {
        public int val;
        public int key;
        public ListNode prev;
        public ListNode next;

        public ListNode(int key, int val) {
            this.key = key;
            this.val = val;
        }
    }

    ListNode nodeList;
    ListNode tail;
    Dictionary<int, ListNode> nodeMap;
    int capacity;

    public LRUCache(int capacity) {
        nodeMap = new Dictionary<int, ListNode>(capacity);
        this.capacity = capacity;
    }

    public int Get(int key) {
        if (!nodeMap.TryGetValue(key, out ListNode node)) {
            return -1;
        }
        if (node != nodeList) {
            MoveToFront(node);
        }

        return node.val;
    }

    public void Put(int key, int value) {
        if (nodeMap.TryGetValue(key, out ListNode node)) {
            node.val = value;
            MoveToFront(node);
            return;
        }

        if (capacity == nodeMap.Count) {
            nodeMap.Remove(tail.key);
            if (capacity == 1) {
                tail = null;
                nodeList = null;
            } else {
                ListNode temp = tail;
                tail = tail.prev;
                temp.prev = null;
                tail.next = null;
            }
        }

        node = new ListNode(key, value);
        nodeMap[key] = node;

        MoveToFront(node);
    }

    private void MoveToFront(ListNode node) {
        if (node == nodeList) return;

        if (node.prev != null) {
            node.prev.next = node.next;
        }

        if (node.next != null) {
            node.next.prev = node.prev;
        }

        if (nodeList != null) {
            if(tail == node){
                tail = tail.prev;
            }
            node.next = nodeList;
            node.prev = null;
            nodeList.prev = node;
            nodeList = node;
        } else {
            nodeList = node;
            tail = node;
        }
    }
}