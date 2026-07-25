public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> keyPair = new();

        for(int i=0; i<nums.Length; i++){
            int remainingPart = target - nums[i];

            if(keyPair.TryGetValue(remainingPart, out int index)){
                return [index, i];
            }else{
                keyPair[nums[i]] = i;
            }
        }

        return [0, 0];
    }
}
