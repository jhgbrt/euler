using System.Linq;

using Xunit;

using static Sequence;

namespace Problems
{
    public class Problem0001
    {
        [Theory]
        [InlineData(23, 10)]
        [InlineData(233168, 1000)]
        public void Euler_0001(int expected, int max)
        {
            var result = MultplesOf(3, 5).TakeWhile(i => i < max).Sum();
            Assert.Equal(expected, result);
        }
    }
}
