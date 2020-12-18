using System.Linq;

using Xunit;

using static Sequence;

namespace Problems
{
    public class Problem0004
    {
        [Fact]
        public void Euler_0004()
        {
            var palindromes =
                from i in ReverseRange(999, 899)
                from j in ReverseRange(i, i)
                let p = i * j
                where p.IsPalindrome()
                select p;

            Assert.Equal(906609, palindromes.Max());
        }
    }
}
