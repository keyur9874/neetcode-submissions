public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyCount = new();
        int n = nums.Length;

        foreach (int num in nums) {
            int count = frequencyCount.GetValueOrDefault(num, 0);
            frequencyCount[num] = count + 1;
        }

        List<int>[] buckets = new List<int>[n + 1];

        foreach (var (number, count) in frequencyCount) {
            if (buckets[count] == null) {
                buckets[count] = new List<int>();
            }

            buckets[count].Add(number);
        }

        int[] result = new int[k];
        int index = 0;

        for (int i = n; i > 0; i--) {
            if (buckets[i] != null) {
                foreach (var num in buckets[i]) {
                    result[index++] = num;
                    if (index == k)
                        return result;
                }
            }
        }

        return result;
    }
}
