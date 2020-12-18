using System.Linq;

using Xunit;

using static Sequence;

namespace Problems
{
    public class Problem0002
    {
        [Fact]
        public void Euler_0002()
        {
            var q = from i in Fibonacci().TakeWhile(i => i < 4_000_000)
                    where i % 2 == 0
                    select i;

            Assert.Equal(4613732, q.Sum());
        }
    }
}
