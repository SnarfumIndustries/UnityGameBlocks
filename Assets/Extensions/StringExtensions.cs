using System.Globalization;
using System.Text;
using UnityEngine;

namespace SI.Extensions
{
    /// <summary>
    ///     Extension methods for the String class.
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        ///     Splits a camel case string into separate words.
        /// </summary>
        /// <param name="str">The string to split.</param>
        /// <returns>
        ///     A new string with a space between words which begin with an uppercase letter in the input string,
        ///     or the original string if it is null or empty.
        /// </returns>
        public static string SplitCamelCase(this string str)
        {
            if (string.IsNullOrEmpty(str)) return str;

            var result = new StringBuilder(str.Length * 2);
            result.Append(str[0]);

            for (int i = 1; i < str.Length; i++)
            {
                if (char.IsUpper(str[i])) result.Append(' ');
                result.Append(str[i]);
            }

            return result.ToString();
        }

        /// <summary>
        ///     Converts a hexadecimal color string to a Unity Color.
        /// </summary>
        /// <param name="hex">
        ///     The hexadecimal color string to convert. Can optionally start with "0x" or "#". Can optionally
        ///     include alpha channel.
        /// </param>
        /// <returns>
        ///     A Unity Color object corresponding to the input hexadecimal color string.
        ///     Returns null if input is less than 6 characters or any color channel information is invalid.
        /// </returns>
        public static Color? ToColor(this string hex)
        {
            hex = hex.Replace("0x", "").Replace("#", "");

            byte a = 255, r, g, b;

            if (hex.Length < 6
                || !byte.TryParse(hex.Substring(0, 2), NumberStyles.HexNumber, null, out r)
                || !byte.TryParse(hex.Substring(2, 2), NumberStyles.HexNumber, null, out g)
                || !byte.TryParse(hex.Substring(4, 2), NumberStyles.HexNumber, null, out b))
            {
                return null;
            }

            if (hex.Length >= 8
                && !byte.TryParse(hex.Substring(6, 2), NumberStyles.HexNumber, null, out a))
            {
                return null;
            }

            return new Color32(r, g, b, a);
        }
    }
}