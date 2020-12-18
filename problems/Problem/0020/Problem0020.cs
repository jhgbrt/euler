using System.Linq;

using Xunit;

namespace Problems
{
    public class Problem0020
    {
        [Fact]
        public void Euler_0020()
        {
            Assert.Equal(648, 100.Factorial().ToString().Select(char.GetNumericValue).Sum());
        }
    }
}
