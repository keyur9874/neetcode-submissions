public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (s.Length == 0)
            return 0;

        int left = 0, right = 0;
        HashSet<char> charSet = new();
        int maxLength = 0;
        while (right < s.Length) {
            while(charSet.Contains(s[right])){
                charSet.Remove(s[left]);
                left++;
            }

            charSet.Add(s[right]);
            maxLength = Math.Max(maxLength, charSet.Count);
            right++;
        }

        return maxLength;
    }
}
