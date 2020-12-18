using System.Linq;

using Xunit;

using static Sequence;

namespace Problems
{
    public class Problem0007
    {

        [Theory]
        [InlineData(17, 7)]
        [InlineData(19, 8)]
        [InlineData(104743, 10001)]
        public void Euler_0007(int expected, int n)
        {
            Assert.True(expected.IsPrime());
            var result = Odd().Where(c => c.IsPrime()).Take(n - 1).Last();
            Assert.Equal(expected, result);
        }
    }
}
