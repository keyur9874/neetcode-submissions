public class Solution {
    public int LongestConsecutive(int[] nums) {
        HashSet<int> numSet = new();

        foreach(var num in nums){
            numSet.Add(num);            
        }

        int maxLength = 0;
        foreach(var num in numSet){
            if(numSet.Contains(num-1)){
                continue;
            }

            int current = num;
            int length = 1;
            while (numSet.Contains(current + 1)) {
                current++;
                length++;
            }

            maxLength = Math.Max(maxLength, length);
        }

        return maxLength;
    }
}
