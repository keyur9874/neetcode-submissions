public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
#region Brute force T : O(n ^ 2) S : O(n)
// Brute force approce
// Time complexity:
// Space complexity:
// int n = nums.Length;
// int[] result = new int[n];

// for (int i = 0; i < n; i++) {
//     int product = 1;
//     for (int j = 0; j < n; j++) {
//         if(i==j)
//             continue;
//         product *= nums[j];
//     }

//     result[i] = product;
// }

// return result;
#endregion

#region Better Solution T : O(n) S : O(n)
        // int n = nums.Length;
        // int[] leftProduct = new int[n];
        // int[] rightProduct = new int[n];
        // leftProduct[0] = 1;
        // rightProduct[n-1] = 1;
        // for(int i=1; i<n; i++){
        //     leftProduct[i] = leftProduct[i-1] * nums[i-1];
        //     rightProduct[n-i-1] = rightProduct[n-i] * nums[n-i];
        // }

        // int[] result = new int[n];

        // for(int i=0; i<n; i++){
        //     result[i] = leftProduct[i] * rightProduct[i];
        // }
        // return result;
#endregion

        int n = nums.Length;
        int[] result = new int[n];
        result[0] = 1;

        for(int i=1; i<n; i++){
            result[i] = result[i-1] * nums[i-1];
        }

        int rightProduct = nums[n-1];
        for(int i=n-2; i>=0; i--){
            result[i] *= rightProduct;
            rightProduct *= nums[i]; 
        }

        return result;
    }
}
