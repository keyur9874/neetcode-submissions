public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length < t.Length) {
            return "";
        }

        Dictionary<char, int> tCharMap = new();
        Dictionary<char, int> sCharMap = new();

        foreach (char c in t) {
            tCharMap[c] = tCharMap.GetValueOrDefault(c, 0) + 1;
        }

        int required = tCharMap.Count;
        int formed = 0;

        int left = 0, right = 0;
        int start = -1;
        int minLength = 1001;
        while (right < s.Length) {
            char inChar = s[right];

            if (tCharMap.ContainsKey(inChar)) {
                sCharMap[inChar] = sCharMap.GetValueOrDefault(inChar, 0) + 1;

                if (sCharMap[inChar] == tCharMap[inChar])
                    formed++;
            }

            while (formed == required) {
                if (minLength > (right - left + 1)) {
                    minLength = right - left + 1;
                    start = left;    
                }
                char outChar = s[left];
                if (tCharMap.ContainsKey(outChar)) {
                    if (sCharMap[outChar] == tCharMap[outChar]) {
                        formed--;
                    }
                    sCharMap[outChar]--;
                }
                left++;
            }
            right++;
        }

        if (start == -1)
            return "";

        return s.Substring(start, minLength);
    }
}
