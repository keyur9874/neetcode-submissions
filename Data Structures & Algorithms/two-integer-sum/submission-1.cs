public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        // Time complexity: O(n^2)
        // Space complexity: O(1)
        // int n = nums.Length;
        // for(int i=0; i<n; i++){
        //     for(int j=i+1; j<n; j++){
        //         if(nums[i]+nums[j] == target)
        //             return [i, j];
        //     }
        // }

        // Time complexity: O(n)
        // Space complexity: O(n)
        var keyPair = new Dictionary<int, int>();
        for(int i=0; i<nums.Length; i++){
            int remainingPart = target - nums[i];
            if(keyPair.TryGetValue(nums[i], out int ind)){
                return [ind, i];
            }else{
                keyPair.Add(remainingPart, i);
            }
        }

        return [-1, -1];
    }
}
