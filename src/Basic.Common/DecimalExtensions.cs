using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Basic.Common
{
    public static class DecimalExtensions
    {
        public static IEnumerable<decimal> ToDecimal(this IEnumerable<string> s)
        {
            foreach (var d in s)
            {
                yield return d.ToDecimal();
            }
        }

        public static decimal ToDecimal(this string s)
        {
            decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal value);
            return value;
        }
    }
}