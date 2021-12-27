namespace Task3
{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            HashSet<char> set = new HashSet<char>();
            int j = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                while(j < s.Length && !set.Contains(s[j]))
                {
                    set.Add(s[j]);
                    ++j;
                }

                result = Math.Max(result, j - i);
                set.Remove(s[i]);
            }

            return result;
        }
    }
}