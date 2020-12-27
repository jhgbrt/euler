using System;
using System.Collections.Generic;
using System.Linq;

using static System.Math;

public static class Sequence
{
    public static IEnumerable<int> ReverseRange(int start, int count)
    {
        for (int i = 0; i < count; i++)
            yield return start--;
    }

    public static IEnumerable<T> Unfold<T>(T seed, Func<T, T> f, Func<T, bool> stopcondition)
    {
        T n = seed;
        yield return n;
        while (!stopcondition(n))
        {
            n = f(n);
            yield return n;
        }
    }

    public static IEnumerable<int> MultplesOf(int n)
    {
        var result = n;
        while (true)
        {
            yield return result;
            result += n;
        }
    }
    public static IEnumerable<Range> SlidingRanges(int rangeSize)
    {
        int i = 0;
        while (true)
        {
            yield return i..(i + rangeSize);
            i++;
        }
    }

    public static IEnumerable<int> Odd()
    {
        int n = 1;
        while (true)
            yield return n += 2;
    }

    public static IEnumerable<int> MultplesOf(int n, params int[] m)
    {
        var i = 1;
        while (true)
        {
            i++;
            if (i % n ==0 || m.Any(j => i % j == 0)) yield return i;
        }
    }

    public static IEnumerable<int> Fibonacci()
    {
        int n = 1, m = 2;
        yield return n;
        yield return m;
        while (true)
        {
            var next = n + m;
            yield return next;
            n = m;
            m = next;
        }
    }

    public static IEnumerable<int> TriangleNumbers()
    {
        var n = 1;
        var sum = 1;
        while (true)
        {
            yield return sum;
            n += 1;
            sum += n;
        }
    }
}
