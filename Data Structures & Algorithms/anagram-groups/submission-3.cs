public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> stringKeyMap = new();

        foreach (var str in strs) {
            string stringKey = BuildKey(str);
            if (!stringKeyMap.TryGetValue(stringKey, out List<string> list)) {
                list = new List<string>();
                stringKeyMap[stringKey] = list;
            }

            list.Add(str);
        }

        return stringKeyMap.Values.ToList();
    }

    private string BuildKey(in string str) {
        int[] frequency = new int[26];

        foreach (char c in str) {
            frequency[c - 'a']++;
        }

        StringBuilder sb = new();

        for (int i = 0; i < 26; i++) {
            sb.Append('#');
            sb.Append(frequency[i]);
        }

        return sb.ToString();
    }
}
