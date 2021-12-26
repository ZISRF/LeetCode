namespace Task14
{
    public class Solution
    {
        int MinLength(string[] strs)
        {
            int result = strs[0].Length;

            for (int i = 1; i < strs.Length; i++)
                result = Math.Min(result, strs[i].Length);

            return result;
        }
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0)
                return "";

            int maxPrefixLength = 0;
            int minLength = MinLength(strs);

            HashSet<char> set = new HashSet<char>();
            for (int i = 0; i < minLength; ++i)
            {
                for (int j = 0; j < strs.Length; ++j)
                    set.Add(strs[j][i]);
                if (set.Count > 1)
                    break;
                set.Clear();

                ++maxPrefixLength;
            }

            return strs[0].Substring(0, maxPrefixLength);
        }
    }
}