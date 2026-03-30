class Solution {
    public int maxArea(int[] heights) {
        int n = heights.length;
        int left = 0, right = n-1;
        int maxWater = 0;
        while(left < right){
            int water = Math.min(heights[left], heights[right]) * (right-left);
            maxWater = Math.max(water, maxWater);

           if (heights[left] > heights[right]) {
                int h = heights[right];
                while (left < right && heights[right] == h) right--;
            } else {
                int h = heights[left];
                while (left < right && heights[left] == h) left++;
            }
        }

        return maxWater;
    }
}
