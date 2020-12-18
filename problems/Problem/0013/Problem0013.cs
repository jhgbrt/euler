
using Input;

using System;
using System.Linq;
using System.Numerics;
using System.Reflection;

using Xunit;
using Xunit.Abstractions;

namespace Problems
{
    public class Problem0013
    {
        ITestOutputHelper _output;

        public Problem0013(ITestOutputHelper output) => _output = output;

        [Fact]
        public void Euler_0013()
        {
            foreach (var n in Assembly.GetExecutingAssembly().GetManifestResourceNames())
                _output.WriteLine(n);
            var sum = (
                from line in InputReader.Read(13)
                select BigInteger.Parse(line)
                ).Aggregate(BigInteger.Zero, (x,y) => x+y);

            Assert.Equal(5537376230, long.Parse(sum.ToString().Substring(0, 10)));
        }


    }
}