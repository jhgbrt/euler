using System.Linq;

using Xunit;

using static Primes;

namespace Problems
{
    public class Problem0010
    {
        [Theory]
        [InlineData(17, 10)]
        [InlineData(142913828922, 2_000_000)]
        public void Euler_0010(long expected, int max)
        {
            Assert.Equal(expected, SieveOfErastosthenes(max).Select(i => (long)i).Sum());
        }

    }
}
