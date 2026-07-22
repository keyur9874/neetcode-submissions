public class Solution {
    public bool IsPalindrome(string s) {
#region Optimal Solution T : O(n) S : O(1)
        int left = 0, right = s.Length - 1;

        while (left < right) {
            while (left < right && !char.IsLetterOrDigit(s[left])) left++;
            while (left < right && !char.IsLetterOrDigit(s[right])) right--;

            if (char.ToLower(s[left]) != char.ToLower(s[right])) {
                return false;
            }

            left++;
            right--;
        }

#endregion
        return true;
    }
}
