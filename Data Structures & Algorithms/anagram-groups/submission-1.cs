public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> groups = new();

        foreach(string str in strs){
            string key = BuildKey(str);
            if (!groups.TryGetValue(key, out List<string>? group))
            {
                group = new List<string>();
                groups[key] = group;
            }

            group.Add(str);
        }

        return groups.Values.ToList();                                                   
    }

    public string BuildKey(string s){
        int[] cnt = new int[26];
        foreach(var c in s){
            cnt[c-'a']++;
        }

        StringBuilder sb = new();
        for(int i=0; i<26; i++){
            sb.Append('#');
            sb.Append(cnt[i]);
        }

        return sb.ToString();
    }
}
