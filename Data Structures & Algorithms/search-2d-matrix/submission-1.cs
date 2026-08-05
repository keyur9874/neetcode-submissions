public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int m = matrix.Length;
        int n = matrix[0].Length;

#region Good Approch T : O(mLog(n)) S : O(1)
// for (int i = 0; i < m; i++) {
//     if (matrix[i][n - 1] >= target && matrix[i][0] <= target) {
//         int left = 0, right = n - 1;

//         while (left <= right) {
//             int mid = left + (right - left) / 2;
//             if (matrix[i][mid] == target) {
//                 return true;
//             } else if (matrix[i][mid] > target) {
//                 right = mid - 1;
//             } else {
//                 left = mid + 1;
//             }
//         }
//     }
// }
#endregion
#region Optimal Solution T : O(log(m* n)) S : O(1)
        int left = 0, right = (m * n) - 1;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            int row = mid / n;
            int col = mid % n;

            if (matrix[row][col] == target) {
                return true;
            } else if (matrix[row][col] > target) {
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }
#endregion
        return false;
    }
}
