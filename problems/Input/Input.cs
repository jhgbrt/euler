using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Input
{
    public static class InputReader
    {
        public static IEnumerable<string> Read(int problem)
        {
            var name = $"problems.Input.{problem:0000}.txt";
            using var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name);
            using var sr = new StreamReader(stream);
            while (sr.Peek() >= 0)
                yield return sr.ReadLine();
        }

    }
}