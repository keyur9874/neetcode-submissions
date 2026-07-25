public class Solution {
    public int Trap(int[] height) {
        // Optimal Solution T: O(n) S: O(n)
        int n = height.Length;
        int[] leftMax = new int[n];
        int[] rightMax = new int[n];

        leftMax[0] = height[0];
        rightMax[n-1] = height[n-1];
        for(int i=1; i<n; i++){
            leftMax[i] = Math.Max(leftMax[i-1], height[i]);
            rightMax[n-i-1] = Math.Max(rightMax[n-i], height[n-i-1]);
        }

        int trapedWater = 0;
        for(int i=0; i<n; i++){
            trapedWater += Math.Min(leftMax[i], rightMax[i]) - height[i];
        }

        return trapedWater;
    }
}
