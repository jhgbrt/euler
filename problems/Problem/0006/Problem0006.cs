using System.Linq;

using Xunit;

namespace Problems
{
    public class Problem0006
    {
        [Theory]
        [InlineData(2640, 10)]
        [InlineData(25164150, 100)]
        public void Euler_0006(int expected, int count)
        {
            var (sum, sumofsquares) = Enumerable.Range(1, count).Aggregate((sum: 0, sumofsquares: 0), (a, i) => (a.sum + i, a.sumofsquares + i * i));
            Assert.Equal(expected, sum * sum - sumofsquares);
        }
    }
}
