
using System.Linq;

using Xunit;
using static Primes;
namespace Euler
{
    public class PrimesTests
    {
        [Fact]
        public void FactorsOfTest()
        {
            Assert.Equal(new[] { 2, 3, 5, 7, 11 }, FactorsOf(2 * 2 * 3 * 3 * 3 * 5 * 7 * 7 * 11));
        }
    }
}
