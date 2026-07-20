public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach (var str in strs) {
            sb.Append($"{str.Length}#{str}");
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        List<string> result = new();
        int i = 0, n = s.Length;
        while (i < s.Length) {
            StringBuilder numString = new StringBuilder();
            while (i < n && s[i] != '#') {
                numString.Append(s[i]);
                i++;
            }
            i++;

            int length = int.Parse(numString.ToString());
            StringBuilder sb = new();
            while (length > 0 && i < n) {
                sb.Append(s[i]);
                i++;
                length--;
            }
            result.Add(sb.ToString());
        }

        return result;
    }
}
