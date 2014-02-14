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
    }
}
