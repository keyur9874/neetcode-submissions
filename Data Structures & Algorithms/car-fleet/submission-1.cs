public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int n = position.Length;
        var cars = new(int Position, int Speed)[n];

        for (int i = 0; i < n; i++) {
            cars[i] = (position[i], speed[i]);
        }

        Array.Sort(cars, (a, b) => a.Position.CompareTo(b.Position));
        double lastFleetTime = 0;
        int fleet = 0;
        for (int i = n - 1; i >= 0; i--) {
            double time = (double)(target - cars[i].Position) / cars[i].Speed;
            if (time > lastFleetTime) {
                fleet++;
                lastFleetTime = time;
            }
        }

        return fleet;
    }
}
