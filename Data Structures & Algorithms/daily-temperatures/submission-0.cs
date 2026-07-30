public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int n = temperatures.Length;
        int[] result = new int[n];
        Stack<int> stack = new();

        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count != 0 && temperatures[stack.Peek()] <= temperatures[i]) {
                stack.Pop();
            }
            
            if (stack.Count == 0) {
                result[i] = 0;
            } else {
                result[i] = stack.Peek() - i;
            }

            stack.Push(i);
        }

        return result;
    }
}
