public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        char[] c1 = new char[26];
        char[] c2 = new char[26];

        for(int i=0; i<s.Length; i++){
            c1[s[i]-'a']++;
            c2[t[i]-'a']++;
        }

        for(int i=0; i<26; i++){
            if(c1[i] != c2[i])
                return false;
        }

        return true;
    }
}
