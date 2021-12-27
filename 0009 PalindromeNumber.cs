namespace Task9
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            string s = x.ToString();

            for (int i = 0; i < s.Length / 2; ++i)
                if (s[i] != s[s.Length - 1 - i])
                    return false;

            return true;
        }
    }
}