using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

using Xunit;

using static Sequence;

namespace Problems
{
    public class Problem0019
    {
        [Fact]
        public void Euler_0019()
        {
            var sundaysOnFirstDayOfMonth = 
                from day in Weekly(DayOfWeek.Sunday, new DateTime(1901, 1, 1), new DateTime(2000, 12, 31))
                where day.Day == 1
                select day;

            static IEnumerable<DateTime> Weekly(DayOfWeek day, DateTime start, DateTime end)
            {
                // make sure to start from sunday
                var d = start.AddDays(7 - (int)start.DayOfWeek + (int)day);
                while (d <= end)
                {
                    yield return d;
                    d = d.AddDays(7);
                }
            }

            Assert.Equal(171, sundaysOnFirstDayOfMonth.Count());
        }


    }
}
