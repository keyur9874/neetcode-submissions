class Solution {
    public int trap(int[] height) {
        int n = height.length;
        if (n == 0) return 0;
        int maxLeft = 0, maxRight = 0, left = 0, right = n-1;
        int water = 0;

        while(left < right){
            if(height[left] <= height[right]){
                if(maxLeft <= height[left]){
                    maxLeft = height[left];
                }else{
                    water += maxLeft - height[left];
                }
                left++;
            }else{
                if(maxRight <= height[right]){
                    maxRight = height[right];
                }else{
                    water += maxRight - height[right];
                }

                right--;
            }
        }

        return water;
    }
}
