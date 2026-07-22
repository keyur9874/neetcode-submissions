public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        Array.Sort(nums);
        int left = 0, maxLength = 1, currentMax = 1;
        for (int i = 1; i < nums.Length; i++) {
            if (nums[i] == nums[i - 1])
                continue;

            if (nums[i] == (nums[i - 1] + 1)) {
                currentMax++;
            } else {
                maxLength = Math.Max(currentMax, maxLength);
                currentMax = 1;
            }
        }
        maxLength = Math.Max(currentMax, maxLength);
        return maxLength;
    }
}
