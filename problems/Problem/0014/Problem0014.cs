using System;
using System.Linq;

using Xunit;

using static Primes;

namespace Problems
{
    public class Problem0014
    {

        [Fact]
        public void Euler_0014()
        {
            Func<long, long> generator = n => n % 2 == 0 ? n / 2 : 3 * n + 1;
            Assert.Equal(
                new[] { 13L,40,20,10,5,16,8,4,2,1 }, 
                Sequence.Unfold(13L, generator, n => n == 1));
            
            var q = (
                from n in Enumerable.Range(500000, 499999)
                let size = Sequence.Unfold(n, generator, n => n == 1).Count()
                orderby size descending
                select n).First();

            Assert.Equal(837799, q);

        }
    }
}
