using System;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Provides helper methods for creating <see cref="Color" /> objects.
    /// </summary>
    public static class NoirColor {

        /// <summary>
        /// Creates a <see cref="Color"/> object from a hexadecimal color string.
        /// </summary>
        /// <param name="color">
        /// The hexadecimal color string. Can optionally start with a '#' character.
        /// If the string is 6 characters long (e.g., "RRGGBB"), an alpha value of "FF" (opaque) is assumed.
        /// If the string is 8 characters long (e.g., "RRGGBBAA"), the last two characters represent the alpha channel.
        /// </param>
        /// <returns>
        /// A <see cref="Color"/> object corresponding to the specified hexadecimal color value.
        /// </returns>
        /// <exception cref="FormatException">
        /// Thrown if <paramref name="color"/> is not a valid hexadecimal string.
        /// </exception>
        public static Color FromHex(string color) {
            if (color.StartsWith("#", StringComparison.InvariantCulture)) {
                color = color.Substring(1); // strip #
            }
            if (color.Length == 6)
            {
                color += "FF"; // add alpha if missing
            }

            var hex = Convert.ToUInt32(color, 16);
            var r = ((hex & 0xff000000) >> 0x18) / 255f;
            var g = ((hex & 0xff0000) >> 0x10) / 255f;
            var b = ((hex & 0xff00) >> 8) / 255f;
            var a = ((hex & 0xff)) / 255f;
            return new Color(r,g,b,a);
        }
    }
}