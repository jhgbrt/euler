using System.Collections.Generic;
using System.Linq;
using System.Numerics;

public static class MathEx
{
    public static bool IsPalindrome(this int n)
    {
        return Reverse(n) == n;
    }

    public static int Reverse(int n)
    {
        var result = 0;
        while (n > 0)
        {
            result = result * 10 + n % 10;
            n /= 10;
        }
        return result;
    }
    public static IEnumerable<int> Digits(this int n)
    {
        while (n > 0)
        {
            yield return n % 10;
            n /= 10;
        }
    }

    public static BigInteger Factorial(this int n) => Sequence.ReverseRange(n, n - 1).Aggregate(BigInteger.One, (x, y) => x * y);
}
