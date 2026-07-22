public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;
        int maxLength = 1;

#region Brute force approch T : O(nlog(n)) S : O(log(n))
        // Array.Sort(nums);
        // int currentMax = 1;
        // for (int i = 1; i < nums.Length; i++) {
        //     if (nums[i] == nums[i - 1])
        //         continue;

        //     if (nums[i] == (nums[i - 1] + 1)) {
        //         currentMax++;
        //     } else {
        //         maxLength = Math.Max(currentMax, maxLength);
        //         currentMax = 1;
        //     }
        // }
        // maxLength = Math.Max(currentMax, maxLength);
#endregion
#region Optimal Solution T : O(n) S : O(n)
        HashSet<int> set = new();
        foreach (var num in nums) {
            set.Add(num);
        }

        List<int> startSequence = new();
        foreach (var num in set) {
            if (!set.Contains(num - 1)) {
                startSequence.Add(num);
            }
        }

        foreach (var num in startSequence) {
            int current = num;
            int length = 1;
            while (set.Contains(current + 1)) {
                current++;
                length++;
            }

            maxLength = Math.Max(maxLength, length);
        }
#endregion
        return maxLength;
    }
}
