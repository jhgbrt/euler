using System.Linq;

using Xunit;

namespace Problems
{
    public class Problem0009
    {

        [Theory]
        [InlineData(60, 12)]
        [InlineData(31875000, 1000)]
        public void Euler_0009(int expected, int s)
        {
            var (a, b, c) = (
                from x in Enumerable.Range(3, (s - 6) / 3)
                from y in Enumerable.Range(x + 1, (s - 2 * x - 2) / 2 + 1)
                let z = s - x - y
                where x * x + y * y == z * z
                select (x, y, z)
                ).First();

            Assert.Equal(expected, a * b * c);
        }
    }
}
