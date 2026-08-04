public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length;

        Stack<int> stack = new();
        int[] leftMin = new int[n];
        int[] rightMin = new int[n];

        for (int i = n - 1; i >= 0; i--) {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i]) {
                stack.Pop();
            }

            if (stack.Count == 0) {
                rightMin[i] = n;
            } else {
                rightMin[i] = stack.Peek();
            }

            stack.Push(i);
        }

        stack.Clear();
        for (int i = 0; i < n; i++) {
            while (stack.Count != 0 && heights[stack.Peek()] >= heights[i]) {
                stack.Pop();
            }

            if (stack.Count == 0) {
                leftMin[i] = -1;
            } else {
                leftMin[i] = stack.Peek();
            }

            stack.Push(i);
        }

        int maxArea = 0;
        for (int i = 0; i < n; i++) {
            int width = rightMin[i] - leftMin[i] - 1;
            int area = heights[i] * width;
            maxArea = Math.Max(maxArea, area);
        }

        return maxArea;
    }
}
