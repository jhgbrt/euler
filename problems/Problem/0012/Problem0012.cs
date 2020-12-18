using System.Linq;

using Xunit;

using static Primes;

namespace Problems
{
    public class Problem0012
    {

        [Fact]
        public void Euler_0012()
        {
            var primes = SieveOfErastosthenes(1000).ToArray();
            var n = 3;
            var NofDivisors = 2;
            int NofDivisorsNext;
            int cnt = 0;
            while (cnt <= 500)
            {
                n++;
                int n1 = n;
                if (n1 % 2 == 0) n1 /= 2;
                NofDivisorsNext = 1;
                for (int i = 0; i < primes.Length; i++)
                {
                    if (primes[i] * primes[i] > n1)
                    {
                        NofDivisorsNext = 2 * NofDivisorsNext;
                        break;
                    }
                    var exponent = 1;
                    while (n1 % primes[i] == 0)
                    {
                        exponent++;
                        n1 /= primes[i];
                    }
                    if (exponent > 1)
                    {
                        NofDivisorsNext *= exponent;
                    }
                    if (n1 == 1)
                        break;
                }
                cnt = NofDivisors * NofDivisorsNext;
                NofDivisors = NofDivisorsNext;
            }
            Assert.Equal(76576500, n * (n - 1) / 2);
        }
    }
}
