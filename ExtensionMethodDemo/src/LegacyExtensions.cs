using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethodDemo.src
{
    public static class LegacyExtensions
    {
        public static string ToLagacyFormat(this DateTime dateTime)
        {
            return dateTime.Year > 1930 ? dateTime.ToString("1yyMMdd")
                                        : dateTime.ToString("0yyMMdd");
        }

        public static string ToLagacyFormat(this string name)
        {
            var parts = name.ToUpper().Split(' ');

            return $"{parts[1]}, {parts[0]}";
        }
    }
}
