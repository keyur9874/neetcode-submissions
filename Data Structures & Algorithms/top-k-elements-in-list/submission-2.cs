public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> frequencyMap = new();

        foreach (var num in nums) {
            frequencyMap[num] = frequencyMap.GetValueOrDefault(num, 0) + 1;
        }

        List<int>[] buckets = new List<int>[nums.Length+1];

        foreach(var (number, count) in frequencyMap){
            buckets[count] ??= new List<int>();
            buckets[count].Add(number);
        }

        List<int> results = new List<int>(k);

        for(int i=buckets.Length-1; i>=0; i--){
            if(buckets[i] != null){
                foreach(var number in buckets[i]){
                    results.Add(number);

                    if(results.Count == k)
                        return results.ToArray();
                }
            }
        }

        return results.ToArray();

    }

    private string BuildKey(string str) {
        int[] count = new int[26];
        foreach (var c in str) {
            count[c - 'a']++;
        }
        StringBuilder sb = new();
        for (int i = 0; i < 26; i++) {
            sb.Append("#");
            sb.Append(count[i]);
        }

        return sb.ToString();
    }
}
