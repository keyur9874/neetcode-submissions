public class Solution {
    public int MaxArea(int[] heights) {
        int maxWater = 0;
#region Brute Force Approce T : O(n ^ 2) S : O(1)
        int n = heights.Length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                int currentWater = Math.Min(heights[i], heights[j]) * (j - i);
                maxWater = Math.Max(maxWater, currentWater);
            }
        }
#endregion

        int left = 0, right = heights.Length-1;
        while(left < right){
            int currentWater = Math.Min(heights[left], heights[right]) * (right-left);
            maxWater = Math.Max(maxWater, currentWater);

            if(heights[left] < heights[right]){
                left++;
            }else{
                right--;
            }
        }
        return maxWater;
    }
}
