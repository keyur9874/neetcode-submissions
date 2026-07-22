public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);

        int n = nums.Length;
        List<List<int>> result = new();

        for (int i = 0; i < n-2; i++) {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            if (nums[i] + nums[i + 1] + nums[i + 2] > 0)
                break;
            if (nums[i] + nums[n - 2] + nums[n - 1] < 0)
                continue;

            int left = i+1, right = n - 1;
            while (left < right) {
                int sum = nums[i] + nums[left] + nums[right];

                if (sum == 0) {
                    result.Add([nums[i], nums[left], nums[right]]);
                    while (left < right && nums[left] == nums[left + 1]) left++;
                    while (left < right && nums[right] == nums[right - 1]) right--;

                    left++;
                    right--;
                } else if (sum < 0) {
                    left++;
                } else {
                    right--;
                }
            }
        }

        return result;
    }
}
