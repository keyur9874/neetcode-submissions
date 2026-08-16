public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        int trappedWater = 0;
        int left = 1, right = n - 2;
        int leftMax = height[0], rightMax = height[n - 1];

        while (left <= right) {
            if (leftMax <= rightMax) {
                if(height[left] >= leftMax){
                    leftMax = height[left];
                }
                else{
                    trappedWater += leftMax - height[left];
                }
                left++;
            } else {
                if(height[right] >= rightMax){
                    rightMax = height[right];
                }else{
                    trappedWater += rightMax - height[right];
                }
                right--;
            }
        }

        return trappedWater;
    }
}
