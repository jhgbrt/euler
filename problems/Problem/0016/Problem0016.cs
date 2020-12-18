using System.Linq;
using System.Numerics;

using Xunit;

using static System.Numerics.BigInteger;
using static System.Char;
namespace Problems
{
    public class Problem0016
    {

        [Fact]
        public void Euler_0016()
        {
            Assert.Equal(1366, Pow(2, 1000).ToString().Select(GetNumericValue).Sum());
        }
    }
}
