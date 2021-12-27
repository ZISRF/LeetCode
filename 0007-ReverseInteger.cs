namespace Task7
{
    public class Solution
    {
        public int Reverse(int x)
        {
            long result = 0;
            int sign = Math.Sign(x);
            x *= sign;

            while (x > 0)
            {
                result = result * 10 + x % 10;
                x /= 10;
            }
            result *= sign;

            if (result < -(1L << 31))
                return 0;
            if (result >= (1L << 31))
                return 0;
            return (int)result;
        }
    }
}