using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NumberText
{

    public static class NumberTextExtensionMethod
    {
        public static string ToText(this int num)
        {
            var builder = new StringBuilder();

            if (num == 0)
            {
                return builder.Append(textStrings[num]).ToString();
            }

            num = scales.Aggregate(num, (current, scale) => Append(builder, current, scale.Key));
            builder.AppendLessThanOneThousand(num);

            return builder.ToString().Trim();
        }

        private static readonly Dictionary<int, string> textStrings = new()
        {
            { 0, "zero" },
            { 1, "one" },
            { 2, "two" },
            { 3, "three" },
            { 4, "four" },
            { 5, "five" },
            { 6, "six" },
            { 7, "seven" },
            { 8, "eight" },
            { 9, "nine" },
            { 10, "ten" },
            { 11, "eleven" },
            { 12, "twelve" },
            { 13, "thirteen" },
            { 14, "fourteen" },
            { 15, "fifteen" },
            { 16, "sixteen" },
            { 17, "seventeen" },
            { 18, "eighteen" },
            { 19, "nineteen" },
            { 20, "twenty" },
            { 30, "thirty" },
            { 40, "forty" },
            { 50, "fifty" },
            { 60, "sixty" },
            { 70, "seventy" },
            { 80, "eighty" },
            { 90, "ninety" },
            { 100, "hundred" }
        };
        private static readonly Dictionary<int, string> scales = new()
        {
            { 1000000000, "billion" },
            { 1000000, "million" },
            { 1000, "thousand" }
        };

        private static int Append(this StringBuilder builder, int num, int scale)
        {
            if (num > scale - 1)
            {
                var baseScale = num / scale;
                builder.AppendLessThanOneThousand(baseScale);
                builder.AppendFormat("{0} ", scales[scale]);
                num -= baseScale * scale;
            }
            return num;
        }

        private static int AppendLessThanOneThousand(this StringBuilder builder, int num)
        {
            if (num > 99)
            {
                num = builder.AppendHundreds(num);
                if (num % 100 > 0) builder.Append("and ");
            }
            num = builder.AppendTens(num);
            builder.AppendUnits(num);
            return num;
        }

        private static void AppendUnits(this StringBuilder builder, int num)
        {
            if (num > 0)
            {
                builder.AppendFormat("{0} ", textStrings[num]);
            }
        }

        private static int AppendTens(this StringBuilder builder, int num)
        {
            if (num > 20)
            {
                var tens = num / 10 * 10;
                builder.AppendFormat("{0} ", textStrings[tens]);
                num -= tens;
            }
            return num;
        }

        private static int AppendHundreds(this StringBuilder builder, int num)
        {
            if (num > 99)
            {
                var hundreds = num / 100;
                builder.AppendFormat("{0} hundred ", textStrings[hundreds]);
                num -= hundreds * 100;
            }
            return num;
        }
    }
}