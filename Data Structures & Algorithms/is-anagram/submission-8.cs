public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        int[] freqCount = new int[26];
        for (int i = 0; i < t.Length; i++) {
            freqCount[s[i] - 'a']++;
            freqCount[t[i] - 'a']--;
        }

        for (int i = 0; i < 26; i++) {
            if (freqCount[i] != 0)
                return false;
        }

        return true;
    }
}
