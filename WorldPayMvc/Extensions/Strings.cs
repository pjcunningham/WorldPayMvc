using System;
using System.Collections.Generic;
using System.Linq;

namespace WorldPayMvc {
    public static class Strings {
        // http://stackoverflow.com/questions/2776673/how-do-i-truncate-a-net-string
        public static string Truncate(this string value, int maxLength) {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Length <= maxLength ? value : value.Substring(0, maxLength);
        }

        public static DateTime FromWorldPayTransactionTime(this string value) {

            if (string.IsNullOrEmpty(value))
                return DateTime.MinValue;

            long num = Convert.ToInt64(value);
            return new DateTime(num * 10000L + 621355968000000000L);
        }
    }
}
