public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroup = new();

        foreach(string str in strs){
            string hashCode = GetHashCode(str);
            if (!anagramGroup.ContainsKey(hashCode))
            {
                anagramGroup[hashCode] = new List<string>();
            }

            anagramGroup[hashCode].Add(str);
        }

        return anagramGroup.Values.ToList();                                                   
    }

    public string GetHashCode(string s){
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
