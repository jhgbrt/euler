using System.Linq;

using Xunit;

using static Sequence;

namespace Euler
{
    public class SequenceTests
    {
        [Fact]
        public void ReverseRangeTest()
        {
            Assert.Equal(new[] { 5, 4, 3 }, ReverseRange(5, 3));
        }

        [Fact]
        public void MultiplesOfTest()
        {
            Assert.Equal(new[] { 3, 5, 6, 9, 10 }, MultplesOf(3, 5).Take(5));
        }
        [Fact]
        public void MultiplesOfSingleNumberTest()
        {
            Assert.Equal(new[] { 3, 6, 9, 12, 15 }, MultplesOf(3).Take(5));
        }
        [Fact]
        public void FibonacciTest()
        {
            Assert.Equal(new[] { 1, 2, 3, 5, 8, 13, 21 }, Fibonacci().Take(7));
        }

        public void TriangleTest()
        {
            Assert.Equal(new[] { 1, 3, 6, 10, 15, 21, 28, 36, 45, 55 }, TriangleNumbers().Take(10));
        }

    }
}
