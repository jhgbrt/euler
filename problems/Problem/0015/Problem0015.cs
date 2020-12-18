using System;
using System.Linq;
using System.Security.Cryptography;

using Xunit;

using static Primes;

namespace Problems
{
    public class Problem0015
    {

        [Fact]
        public void Euler_0015()
        {
            var n = 20;
            var result = Enumerable.Range(1, 20).Aggregate(1L, (r, i) => r * (n + i) / i);
            Assert.Equal(137846528820, result);

        }
    }
}
