public class Solution {
    public int[] TwoSum(int[] nums, int target) {
#region Optimal Solution T : O(n) S : O(1)
        int left = 0, right = nums.Length - 1;

        while (left < right) {
            int sum = nums[left] + nums[right];

            if (sum > target) {
                right--;
            } else if (sum < target) {
                left++;
            } else {
                return [left + 1, right + 1];
            }
        }
#endregion
        return [];
    }
}
