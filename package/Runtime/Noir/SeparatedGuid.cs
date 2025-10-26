using System;

namespace Noir {
    /// <summary>
    /// Represents a <see cref="Guid"/> split into its component parts,
    /// allowing for more granular manipulation or inspection of its binary segments.
    /// </summary>
    [Serializable]
    public struct SeparatedGuid {
        /// <summary>
        /// The 32-bit prefix portion of the GUID.
        /// </summary>
        public Int32 Prefix;

        /// <summary>
        /// The first 16-bit segment of the GUID following the prefix.
        /// </summary>
        public Int16 A;

        /// <summary>
        /// The second 16-bit segment of the GUID following <see cref="A"/>.
        /// </summary>
        public Int16 B;

        /// <summary>
        /// The remaining 8-byte suffix portion of the GUID.
        /// </summary>
        public Byte[] Suffix;

        /// <summary>
        /// Implicitly converts a <see cref="SeparatedGuid"/> to a standard <see cref="Guid"/> instance.
        /// </summary>
        /// <param name="g">The <see cref="SeparatedGuid"/> to convert.</param>
        /// <returns>A <see cref="Guid"/> constructed from the separated components.</returns>
        public static implicit operator Guid(SeparatedGuid g) {
            return new Guid(g.Prefix, g.A, g.B, g.Suffix);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Guid"/> to a <see cref="SeparatedGuid"/> instance
        /// by splitting its byte representation into individual fields.
        /// </summary>
        /// <param name="g">The <see cref="Guid"/> to convert.</param>
        /// <returns>A <see cref="SeparatedGuid"/> representing the decomposed GUID.</returns>
        public static implicit operator SeparatedGuid(Guid g) {
            var bytes = g.ToByteArray();
            var prefix = BitConverter.ToInt32(bytes, 0);
            var a = BitConverter.ToInt16(bytes, 4);
            var b = BitConverter.ToInt16(bytes, 6);
            var suffix = new byte[8];
            Array.Copy(bytes, 8, suffix, 0, 8);
            return new SeparatedGuid {Prefix = prefix, A = a, B = b, Suffix = suffix};
        }
    }
}