using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Basic.Common
{
    public static class IntExtensions
    {
        public static IEnumerable<int> ToInt(this IEnumerable<string> s)
        {
            foreach (var i in s)
            {
                int.TryParse(i, NumberStyles.Integer, CultureInfo.CurrentCulture, out int value);
                yield return value;
            }
        }
    }
}