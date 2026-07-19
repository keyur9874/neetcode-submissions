public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        char[] c = new char[26];

        for(int i=0; i<s.Length; i++){
            c[s[i]-'a']++;
            c[t[i]-'a']--;
        }

        for(int i=0; i<26; i++){
            if(c[i] != 0)
                return false;
        }

        return true;
    }
}
