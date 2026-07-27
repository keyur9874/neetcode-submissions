public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> charCount = new();
        int maxLength = 0;
        int left = 0, right = 0, maxFrequency = 0;
        while (right < s.Length) {
            char inChar = s[right];
            charCount[inChar] = charCount.GetValueOrDefault(inChar, 0) + 1;
            maxFrequency = Math.Max(maxFrequency, charCount[inChar]);
            if (((right - left + 1) - maxFrequency) > k) {
                char outChar = s[left];
                charCount[outChar]--;

                if (charCount[outChar] == 0) {
                    charCount.Remove(outChar);
                }
                left++;
            }
            maxLength = Math.Max(maxLength, right - left + 1);
            right++;
        }

        return maxLength;
    }
}
