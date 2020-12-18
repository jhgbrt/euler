using Input;

using System.Collections.Generic;
using System.Linq;

using Xunit;
using Xunit.Abstractions;

using static Primes;

namespace Problems
{
    public class Problem0018
    {
        ITestOutputHelper _output;

        public Problem0018(ITestOutputHelper output) => _output = output;

        [Fact]
        public void Euler_0018()
        {
            var input = (
                from line in InputReader.Read(18)
                let integers = line.Split(" ").Select(int.Parse).ToArray()
                select integers
                ).Reverse().ToArray();

            foreach (var (line, previous) in input.Skip(1).Zip(input))
            {
                foreach (var (n,i) in line.Indexed())
                {
                    line[i] += previous.Skip(i).Take(2).Max();
                }
            }

            var sum = input.Last()[0];
            Assert.Equal(1074, sum);

        }
    }
}
