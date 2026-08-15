public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> indexMap = new();

        for (int i = 0; i < nums.Length; i++) {
            int remainingTarget = target - nums[i];
            if (indexMap.TryGetValue(remainingTarget, out int index)) {
                return [index, i];
            }
            indexMap[nums[i]] = i;
        }

        return [-1, -1];
    }
}
