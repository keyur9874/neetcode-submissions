public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){
            return false;
        }
        // int[] c1 = new int[26];
        // int[] c2 = new int[26];

        // for(int i=0; i<s.Length; i++){
        //     c1[s[i]-'a']++;
        //     c2[t[i]-'a']++;
        // }

        // for(int i=0; i<26; i++){
        //     if(c1[i] != c2[i])
        //         return false;
        // }


        int[] c = new int[26];

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
