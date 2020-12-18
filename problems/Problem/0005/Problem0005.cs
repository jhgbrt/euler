using System.Linq;

using Xunit;

namespace Problems
{
    public class Problem0005
    {


        [Fact]
        public void Euler_0005()
        {
            Assert.Equal(2520, MathNet.Numerics.Euclid.LeastCommonMultiple(Enumerable.Range(1, 10).Select(i => (long)i).ToArray()));
            Assert.Equal(232792560, MathNet.Numerics.Euclid.LeastCommonMultiple(Enumerable.Range(1, 20).Select(i => (long)i).ToArray()));
        }

    }
}
