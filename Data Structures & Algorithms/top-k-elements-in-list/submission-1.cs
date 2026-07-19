public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new();
        foreach (var num in nums) {
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num) + 1;
        }

        // Time Complexity: O(nLogn) Sorting take this time
        // Space Complexity: O(n) Stored Dictionary value
        // return freq.OrderBy(o => o.Value).TakeLast(k).Select(o => o.Key).ToArray();

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var (number, count) in frequencyMap) {
            if (buckets[count] == null) {
                buckets[count] = new List<int>();
            }

            buckets[count].Add(number);
        }

        List<int> result = new();
        for (int i = buckets.Length - 1; i >= 0 && result.Count < k; i--) {
            if (buckets[i] != null) {
                foreach (int num in buckets[i]) {
                    result.Add(num);
                    if (result.Count == k) {
                        return result.ToArray();
                    }
                }
            }
        }

        return result.ToArray();
    }
}
