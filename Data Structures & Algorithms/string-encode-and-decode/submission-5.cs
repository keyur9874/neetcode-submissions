public class Solution {
    // Encode:
    // Time: O(total characters)
    // Space: O(total characters)
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (var str in strs) {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    // Decode:
    // Time: O(total characters)
    // Space: O(total characters)
    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0;
        while (i < s.Length) {
            StringBuilder numString = new StringBuilder();
            while (s[i] != '#') {
                numString.Append(s[i]);
                i++;
            }
            i++;

            int length = int.Parse(numString.ToString());
            result.Add(s.Substring(i, length));
            i += length;
        }

        return result;
    }
}
