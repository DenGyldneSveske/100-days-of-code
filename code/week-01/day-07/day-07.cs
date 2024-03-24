namespace SortedArray
{
    public class MergeSortedArray
    {
        public static int[] mergeArray(int[] nums1, int[] nums2)
        {
            for (int j = 0, i = 0; j < nums1.Length; j++)
            {
                if (nums1[j] == 0)
                {
                    nums1[j] = nums2[i];
                    if (i < 2)
                    {
                        i++;
                    }

                }
                else if (nums1[j] > nums2[i])
                {
                    // Shift 1 right in nums1
                    for (int k = nums1.Length - 1; k >= j; k--)
                    {
                        nums1[k] = nums1[k - 1];
                    }
                    nums1[j] = nums2[i];
                    if (i < 2)
                    {
                        i++;
                    }
                }
            }
            return nums1;
        }
    }
}