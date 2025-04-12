using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;

namespace Noir.Serialization.Json {
    public static class JsonReaderExtensions {
        [return: MaybeNull]
        public static T ReadViaSerializer<T>(this JsonReader reader, JsonSerializer serializer)
        {
            reader.Read();
            return serializer.Deserialize<T>(reader);
        }

        public static float? ReadAsFloat(this JsonReader reader)
        {
            // https://github.com/jilleJr/Newtonsoft.Json-for-Unity.Converters/issues/46
            var str = reader.ReadAsString();

            if (string.IsNullOrEmpty(str))
            {
                return null;
            }
            else if (float.TryParse(str, NumberStyles.Any, CultureInfo.InvariantCulture, out var valueParsed))
            {
                return valueParsed;
            }
            else
            {
                return 0f;
            }
        }

        public static byte? ReadAsInt8(this JsonReader reader)
        {
            return checked((byte)(reader.ReadAsInt32() ?? 0));
        }
    }
}
