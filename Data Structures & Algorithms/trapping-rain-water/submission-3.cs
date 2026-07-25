public class Solution {
    public int Trap(int[] height) {
        int trappedWater = 0;
        int n = height.Length;

        // Better Solution T: O(n) S: O(n)
        // int[] leftMax = new int[n];
        // int[] rightMax = new int[n];

        // leftMax[0] = height[0];
        // rightMax[n-1] = height[n-1];
        // for(int i=1; i<n; i++){
        //     leftMax[i] = Math.Max(leftMax[i-1], height[i]);
        //     rightMax[n-i-1] = Math.Max(rightMax[n-i], height[n-i-1]);
        // }

        // for(int i=0; i<n; i++){
        //     trappedWater += Math.Min(leftMax[i], rightMax[i]) - height[i];
        // }

        int left = 1, right = n - 2;
        int leftMax = height[0], rightMax = height[n - 1];

        while (left <= right) {
            if (leftMax <= rightMax) {
                if (height[left] >= leftMax) {
                    leftMax = height[left];
                } else {
                    trappedWater += leftMax - height[left];
                }
                left++;
            } else {
                if (height[right] >= rightMax) {
                    rightMax = height[right];
                } else {
                    trappedWater += rightMax - height[right];
                }
                right--;
            }
        }

        return trappedWater;
    }
}
