namespace Task4
{
    public class Solution
    {
        static int[] Merge(int[] nums1, int[] nums2)
        {
            int[] result = new int[nums1.Length + nums2.Length];

            int i = 0, j = 0;
            while (i < nums1.Length || j < nums2.Length)
            {
                if (i == nums1.Length)
                {
                    result[i + j] = nums2[j];
                    ++j;
                }
                else if (j == nums2.Length)
                {
                    result[i + j] = nums1[i];
                    ++i;
                }
                else if (nums1[i] < nums2[j])
                {
                    result[i + j] = nums1[i];
                    ++i;
                }
                else
                {
                    result[i + j] = nums2[j];
                    ++j;
                }
            }

            return result;
        }
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] nums = Merge(nums1, nums2);

            if (nums.Length % 2 == 0)
                return (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2.0;
            return nums[nums.Length / 2];
        }
    }
}