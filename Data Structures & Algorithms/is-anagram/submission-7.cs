public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        int[] frequency = new int[26];

        foreach(char c in s){
            frequency[c-'a']++;
        }

        foreach(char c in t){
            frequency[c-'a']--;
        }

        for(int i=0; i<26; i++){
            if(frequency[i] != 0)
                return false;
        }

        return true;
    }
}
