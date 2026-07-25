public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set  = new();

        foreach(var num in nums){
            if(!set.Add(num))
                return true;
        }

        return false;
    }
}