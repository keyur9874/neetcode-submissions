public class Solution {
    public string Encode(IList<string> strs) {
        StringBuilder sb = new();

        foreach (var str in strs) {
            sb.Append(str.Length);
            sb.Append('#');
            sb.Append(str);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) {
        int i = 0;
        List<string> result = new();

        while (i < s.Length) {
            int start = i;
            while (s[i] != '#') {
                i++;
            }
            int length = int.Parse(s.Substring(start, i - start));
            i++;
            result.Add(s.Substring(i, length));
            i+= length;
        }
        return result;
    }
}
