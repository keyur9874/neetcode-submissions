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
        List<string> result = new();
        int index = 0;

        while (index < s.Length) {
            int start = index;
            while(s[index] != '#'){
                index++;
            }

            int length = int.Parse(s.Substring(start, index-start));
            index++;

            result.Add(s.Substring(index, length));
            index += length;
        }

        return result;
    }
}
