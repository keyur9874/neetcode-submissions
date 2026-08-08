public class TimeMap {
    Dictionary<string, List<(string Value, int Timestamp)>> timeMap;
    public TimeMap() {
        timeMap = new();
    }

    public void Set(string key, string value, int timestamp) {
        if (!timeMap.ContainsKey(key)) {
            timeMap[key] = new List<(string Value, int Timestamp)>();
        }

        timeMap[key].Add((value, timestamp));
    }

    public string Get(string key, int timestamp) {
        if (!timeMap.TryGetValue(key, out var valueList))
            return "";
        int left = 0, right = valueList.Count - 1;
        string value = "";
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (valueList[mid].Timestamp <= timestamp) {
                value = valueList[mid].Value;
                left = mid + 1;
            } else {
                right = mid - 1;
            }
        }

        return value;
    }
}
