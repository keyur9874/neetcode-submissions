public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramMap = new();

        foreach(string str in strs){
            string hashKey = GetHashKey(str);
            if(!anagramMap.TryGetValue(hashKey, out List<string> group)){
                group = new List<string>();
                anagramMap[hashKey] = group;
            }

            group.Add(str);
        }

        return anagramMap.Values.ToList();
    }

    private string GetHashKey(string str){
        int[] charCount = new int[26];
        foreach(char c in str){
            charCount[c-'a']++;
        }

        StringBuilder sb = new();

        for(int i=0; i<26; i++){
            sb.Append('#');
            sb.Append(charCount[i]);
        }


        return sb.ToString();
    }
}
