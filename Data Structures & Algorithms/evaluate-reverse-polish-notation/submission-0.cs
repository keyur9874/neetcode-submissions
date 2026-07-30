public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new();
        int val = 0;
        foreach (var token in tokens) {
            switch (token) {
                case "+":
                    val = stack.Pop() + stack.Pop();
                    stack.Push(val);
                    break;
                case "-":
                    int val1 = stack.Pop();
                    int val2 = stack.Pop();
                    val = val2 - val1;
                    stack.Push(val);
                    break;
                case "*":
                    val = stack.Pop() * stack.Pop();
                    stack.Push(val);
                    break;
                case "/":
                    int val3 = stack.Pop();
                    int val4 = stack.Pop();
                    val = val4 / val3;
                    stack.Push(val);
                    break;
                default:
                    stack.Push(int.Parse(token));
                    break;
            }
        }

        return stack.Pop();
    }
}
