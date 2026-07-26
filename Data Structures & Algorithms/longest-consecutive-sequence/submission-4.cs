public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0)
            return 0;

        HashSet<int> numbers = new();
        foreach (var num in nums) {
            numbers.Add(num);
        }

        int maxLength = 1;
        foreach (var num in numbers) {
            if (numbers.Contains(num - 1)) {
                continue;
            }
            int current = num;
            int length = 1;
            while (numbers.Contains(current + 1)) {
                current++;
                length++;
            }

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;
    }
}
