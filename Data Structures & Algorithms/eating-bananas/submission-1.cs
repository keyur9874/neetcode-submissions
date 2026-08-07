public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int maxBanana = 0;
        int n = piles.Length;
        for (int i = 0; i < n; i++) {
            if (maxBanana < piles[i])
                maxBanana = piles[i];
        }

        int left = 1, right = maxBanana;
        int minSpeed = maxBanana;

        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (HasFinishAllPiles(piles, h, mid)) {
                minSpeed = mid;
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        return minSpeed;
    }

    private bool HasFinishAllPiles(int[] piles, int h, int speed) {
        int n = piles.Length - 1;
        while (n >= 0 && h > 0) {
            h -= (piles[n] + speed - 1) / speed;
            n--;
        }

        return n == -1 && h >= 0;
    }
}
