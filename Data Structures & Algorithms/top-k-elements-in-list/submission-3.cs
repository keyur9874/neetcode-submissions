public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyCount = new();
        foreach (var num in nums) {
            int count = frequencyCount.GetValueOrDefault(num, 0);
            frequencyCount[num] = count + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach (var (number, count) in frequencyCount) {
            buckets[count] ??= new List<int>();
            buckets[count].Add(number);
        }
        List<int> result = new List<int>(k);
        for(int i=buckets.Length-1; i>=0; i--){
            if(buckets[i] != null){
                foreach(var num in buckets[i]){
                    result.Add(num);

                    if(result.Count == k)
                        return result.ToArray();
                }
            }
        }

        return result.ToArray();
    }
}
