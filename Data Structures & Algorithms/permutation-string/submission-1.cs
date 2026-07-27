public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) {
            return false;
        }

        int[] cnt1 = new int[26];
        int[] cnt2 = new int[26];

        foreach (char c in s1) {
            cnt1[c - 'a']++;
        }

        for (int i = 0; i < s1.Length; i++) {
            cnt2[s2[i] - 'a']++;
        }

        if (cnt1.SequenceEqual(cnt2))
            return true;

        int left = 0, right = s1.Length;
        while (right < s2.Length) {
            cnt2[s2[right]-'a']++;
            cnt2[s2[left]-'a']--;
            left++;
            right++;

            if (cnt1.SequenceEqual(cnt2))
                return true;
        }

        return false;
    }
}
