public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // Brute force approce
        // Time complexity:
        // Space complexity:
        int n = nums.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++) {
            int product = 1;
            for (int j = 0; j < n; j++) {
                if(i==j)
                    continue;
                product *= nums[j];
            }

            result[i] = product;
        }

        return result;
    }
}
