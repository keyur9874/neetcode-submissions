public class Solution {
    public bool hasDuplicate(int[] nums) {
        // nLog(n)
        // Sort the error
        // if Array length > 1 and i-1 == i then return true 
        // Otherwise return false
        // if(nums.Length==1)
        //     return false;
        // Array.Sort(nums);

        // for(int i=1; i<nums.Length; i++){
        //     if(nums[i]==nums[i-1])
        //         return true;            
        // }
        // return false;

        // Time complexity: O(n)
        // Space complexity: O(n)
        HashSet<int> set = new HashSet<int>();
        foreach(var num in nums){
            if(!set.Add(num))
                return true;
        }

        return false;
    }
}