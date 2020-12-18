using System.Linq;

using Xunit;

using static Primes;

namespace Problems
{
    public class Problem0003
    {


        [Fact]
        public void Euler_0003()
        {
            Assert.Equal(6857, FactorsOf(600851475143).Max());
        }
    }
}
