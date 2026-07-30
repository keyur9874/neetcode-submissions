public class MinStack {
    Stack<int> stack;
    Stack<int> minStack;

    public MinStack() {
        stack = new();
        minStack = new();
    }

    public void Push(int val) {
        stack.Push(val);
        if (minStack.Count == 0 || minStack.Peek() >= val) {
            minStack.Push(val);
        }
    }

    public void Pop() {
        if (stack.Count == 0)
            return;

        int val = stack.Pop();
        if(minStack.Peek() == val){
            minStack.Pop();
        }
    }

    public int Top() {
        return stack.Peek();
    }

    public int GetMin() {
        return minStack.Peek();
    }
}
