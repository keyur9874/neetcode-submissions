public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new();
        foreach(var num in nums){
            if(!freq.TryGetValue(num, out int count)){
                freq[num] = 0;
            }

            freq[num]++;
        }

        return freq.OrderBy(o => o.Value).TakeLast(k).Select(o => o.Key).ToArray();
    }
}
