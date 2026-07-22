public class Solution {
    public int MaxArea(int[] heights) {
#region Brute Force Approce T : O(n ^ 2) S : O(1)
        int n = heights.Length;
        int maxWater = 0;
        for (int i = 0; i < n - 1; i++) {
            for (int j = i + 1; j < n; j++) {
                int currentWater = Math.Min(heights[i], heights[j]) * (j-i);
                maxWater = Math.Max(maxWater, currentWater);
            }
        }
#endregion

return maxWater;
    }
}
