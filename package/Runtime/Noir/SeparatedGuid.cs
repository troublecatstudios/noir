using System;

namespace Noir {
    [Serializable]
    public struct SeparatedGuid {
        public Int32 Prefix;
        public Int16 A;
        public Int16 B;
        public Byte[] Suffix;

        public static implicit operator Guid(SeparatedGuid g) {
            return new Guid(g.Prefix, g.A, g.B, g.Suffix);
        }

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