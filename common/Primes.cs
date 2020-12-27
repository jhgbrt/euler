using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using static System.Math;
public static class Primes
{
    public static IEnumerable<int> SieveOfErastosthenes(int max)
    {
        var maxSquareRoot = (int)Math.Sqrt(max);
        var eliminated = new BitArray(max + 1);

        for (int i = 2; i <= max; ++i)
        {
            if (!eliminated[i])
            {
                yield return i;
                if (i <= maxSquareRoot)
                {
                    for (int j = i * i; j <= max; j += i)
                    {
                        eliminated[j] = true;
                    }
                }
            }
        }
    }
    public static IEnumerable<int> FactorsOf(long n) => DivisorsOf(n).Distinct();

    static IEnumerable<int> DivisorsOf(long n)
    {
        for (var divisor = 2; n > 1; divisor++)
            for (; n % divisor == 0; n /= divisor)
                yield return divisor;
    }
    
    public static bool IsPrime(this int n)
    {
        if (n <= 1) return false;
        if (n < 4) return true;
        if (n % 2 == 0) return false;
        if (n < 9) return true;
        if (n % 3 == 0) return false;
        var r = Floor(Sqrt(n));
        var f = 5;
        while (f<=r)
        {
            if (n % f == 0) return false;
            if (n % (f + 2) == 0) return false;
            f += 6;
        }
        return true;
    }
}
