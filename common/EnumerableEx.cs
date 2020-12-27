using System.Collections.Generic;
using System.Linq;

public static class EnumerableEx
{
    public static IEnumerable<IEnumerable<T>> SlidingWindow<T>(this IEnumerable<T> input, int size)
    {
        var enumerator = input.GetEnumerator();
        var q = new Queue<T>();
        while (q.Count < size && enumerator.MoveNext())
        {
            q.Enqueue(enumerator.Current);
        }
        while (enumerator.MoveNext())
        {
            yield return q.ToArray();
            q.Dequeue();
            q.Enqueue(enumerator.Current);
        }
        yield return q;
    }

    public static IEnumerable<(T item, int index)> Indexed<T>(this IEnumerable<T> input) => input.Select((item, i) => (item, i));
}
