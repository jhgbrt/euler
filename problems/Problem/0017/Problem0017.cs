using NumberText;

using System.Linq;

using Xunit;
using Xunit.Abstractions;

using static Primes;

namespace Problems
{
    public class Problem0017
    {
        ITestOutputHelper _output;

        public Problem0017(ITestOutputHelper output) => _output = output;

        [Fact]
        public void Euler_0017()
        {
            var words = from i in Enumerable.Range(1, 1000)
                        select (i, i.ToText());

            foreach (var w in words) _output.WriteLine(w.ToString());

            var characters = from i in Enumerable.Range(1, 1000)
                        from c in i.ToText()
                        where c != ' ' && c != '-'
                        select c;

            int result = characters.Count();
            Assert.Equal(21124, result);
        }

        [Fact]
        public void NumToText()
        {
            Assert.Equal("one", 1.ToText());
            Assert.Equal("one hundred and fifteen", 115.ToText());
            Assert.Equal("three hundred and forty two", 342.ToText());
            Assert.Equal("nine hundred and ninety nine", 999.ToText());
        }

    }
}
