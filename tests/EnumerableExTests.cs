using System.Linq;

using Xunit;

namespace problems
{
    public class EnumerableExTests
    {
        [Fact]
        public void SlidingWindowTest()
        {
            var result = new[] { 1, 2, 3, 4, 5 }.SlidingWindow(3).ToArray();
            Assert.Equal(new[] { 1, 2, 3 }, result.First().ToArray());
            Assert.Equal(new[] { 2, 3, 4 }, result.Skip(1).First().ToArray());
            Assert.Equal(new[] { 3, 4, 5 }, result.Last().ToArray());
        }
    }
}
