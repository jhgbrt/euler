using System;
using System.Diagnostics;

public static class Timed
{
    public static TimeSpan Execute(Action action)
    {
        var sw = Stopwatch.StartNew();
        action();
        return sw.Elapsed;
    }
    public static (TimeSpan,T) Execute<T>(Func<T> action)
    {
        var sw = Stopwatch.StartNew();
        var result = action();
        return (sw.Elapsed, result);
    }
}