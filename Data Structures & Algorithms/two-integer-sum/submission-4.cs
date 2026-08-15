public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexMap = new();

        for (int i = 0; i < nums.Length; i++) {
            int remainingTarget = target - nums[i];
            if (indexMap.ContainsKey(remainingTarget)) {
                return [indexMap[remainingTarget], i];
            } else {
                indexMap[nums[i]] = i;
            }
        }

        return [-1, -1];
    }
}
