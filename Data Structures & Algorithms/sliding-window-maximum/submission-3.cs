public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        LinkedList<int> deque = new();
        int n = nums.Length;
        int[] result = new int[n - k + 1];
        for (int i = 0; i < n; i++) {
            while (deque.Count != 0 && nums[deque.Last!.Value] <= nums[i]) {
                deque.RemoveLast();
            }
            deque.AddLast(i);

            if (deque.First!.Value <= i-k)
                deque.RemoveFirst();

            if ((i + 1) >= k) {
                result[i - k + 1] = nums[deque.First!.Value];
            }
        }

        return result;
    }
}
