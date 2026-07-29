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
        int matches = 0;
        for (int i = 0; i < 26; i++) {
            if (cnt1[i] == 0)
                matches++;
        }

        int left = 0, right = 0;

        while (right < s2.Length) {
            int inChar = s2[right] - 'a';
            if (cnt1[inChar] == cnt2[inChar]) {
                matches--;
            }

            cnt2[inChar]++;
            if (cnt1[inChar] == cnt2[inChar]) {
                matches++;
            }

            if ((right - left + 1) > s1.Length) {
                int outChar = s2[left] - 'a';
                if (cnt1[outChar] == cnt2[outChar])
                    matches--;

                cnt2[outChar]--;

                if (cnt1[outChar] == cnt2[outChar])
                    matches++;

                left++;
            }

            if (matches == 26)
                return true;

            right++;
        }

        return false;
    }
}
