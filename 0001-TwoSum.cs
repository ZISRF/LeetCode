namespace Task1
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            HashSet<int> set = new HashSet<int>();
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; ++i)
            {
                if (set.Contains(target - nums[i]))
                    return new int[] { map[target - nums[i]], i };
                set.Add(nums[i]);
                map[nums[i]] = i;
            }

            return new int[] { nums.Length, nums.Length };
        }
    }
}