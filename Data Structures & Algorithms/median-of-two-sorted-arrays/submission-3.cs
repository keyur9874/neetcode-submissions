public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int m = nums1.Length, n = nums2.Length;
        if (m > n) {
            return FindMedianSortedArrays(nums2, nums1);
        }
        int totalNum = m + n;

        int left = 0, right = m;
        while (left <= right) {
            int mid1 = left + (right - left) / 2;
            int mid2 = (totalNum + 1) / 2 - mid1;

            int l1 = mid1 == 0 ? int.MinValue : nums1[mid1 - 1];
            int r1 = mid1 == m ? int.MaxValue : nums1[mid1];
            int l2 = mid2 == 0 ? int.MinValue : nums2[mid2 - 1];
            int r2 = mid2 == n ? int.MaxValue : nums2[mid2];

            if (l1 <= r2 && l2 <= r1) {
                if (totalNum % 2 == 1) {
                    return Math.Max(l1, l2);
                    ;
                } else {
                    return (double)(Math.Max(l1, l2) + Math.Min(r1, r2)) / 2;
                }
            } else if (l1 > r2) {
                right = mid1-1;
            } else {
                left = mid1 + 1;
            }
        }

        return -1;
    }
}
