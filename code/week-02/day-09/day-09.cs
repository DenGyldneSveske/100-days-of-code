namespace TrappedWater
{
    public class TrappedWater
    {
        public static int trappedWater(int[] arr)
        {
            int n = arr.Length;
            int[] left = new int[n];
            int[] right = new int[n];
            int water = 0;

            left[0] = arr[0];
            for (int i = 1; i < n; i++)
            {
                left[i] = Math.Max(left[i - 1], arr[i]);
            }

            right[n - 1] = arr[n - 1];
            for (int i = n - 2; i >= 0; i--)
            {
                right[i] = Math.Max(right[i + 1], arr[i]);
            }

            for (int i = 0; i < n; i++)
            {
                water += Math.Min(left[i], right[i]) - arr[i];
            }

            return water;
        }
    }
}