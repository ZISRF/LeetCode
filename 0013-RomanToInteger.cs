namespace Task13
{
    public class Solution
    {
        public int RomanToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default:
                    return 0;
            }
        }
        public int RomanToInt(string s)
        {
            int result = 0;

            for (int i = 1; i < s.Length; ++i)
                if (RomanToInt(s[i]) > RomanToInt(s[i - 1]))
                    result -= RomanToInt(s[i - 1]);
                else
                    result += RomanToInt(s[i - 1]);
            result += RomanToInt(s[s.Length - 1]);

            return result;
        }
    }
}