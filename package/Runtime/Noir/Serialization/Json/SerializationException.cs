using Newtonsoft.Json;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Reflection;
using System.Text;

namespace Noir.Serialization.Json {
    public class NoirSerializationException : JsonSerializationException {
        /// <summary>
        /// This refers to the ctor that lets you specify the line number and
        /// position that was introduced in Json.NET v12.0.1.
        /// <see cref="JsonSerializationException.JsonSerializationException(string, string, int, int, Exception)"/>
        /// <see href="https://github.com/JamesNK/Newtonsoft.Json/blob/12.0.1/Src/Newtonsoft.Json/JsonSerializationException.cs#L110"/>
        /// </summary>
        internal static readonly ConstructorInfo _JsonSerializationExceptionPositionalCtor
            = typeof(JsonSerializationException).GetConstructor(new[] {
                typeof(string), typeof(string), typeof(int), typeof(int), typeof(Exception)
            });

        public static NoirSerializationException CreateSerializationException(JsonReader reader, string message, [AllowNull] Exception innerException = null) {
            var builder = CreateStringBuilderWithSpaceAfter(message);

            builder.AppendFormat(CultureInfo.InvariantCulture, "Path '{0}'", reader.Path);

            var lineInfo = reader as IJsonLineInfo;
            int lineNumber = default;
            int linePosition = default;

            if (lineInfo?.HasLineInfo() == true)
            {
                lineNumber = lineInfo.LineNumber;
                linePosition = lineInfo.LinePosition;
                builder.AppendFormat(CultureInfo.InvariantCulture, ", line {0}, position {1}", lineNumber, linePosition);
            }

            builder.Append('.');

            return (NoirSerializationException)NewJsonSerializationException(message: builder.ToString(), reader.Path, lineNumber, linePosition, innerException);
        }

        private static StringBuilder CreateStringBuilderWithSpaceAfter(string message)
        {
            var builder = new StringBuilder(message);

            if (message.EndsWith("."))
            {
                builder.Append(' ');
            }
            else if (!message.EndsWith(". "))
            {
                builder.Append(". ");
            }

            return builder;
        }

        private static JsonSerializationException NewJsonSerializationException(string message, string path, int lineNumber, int linePosition, [AllowNull] Exception innerException)
        {
            if (_JsonSerializationExceptionPositionalCtor != null)
            {
                return (JsonSerializationException)_JsonSerializationExceptionPositionalCtor.Invoke(new object[] {
                    message, path, lineNumber, linePosition, innerException
                });
            }
            else
            {
                return new JsonSerializationException(message, innerException);
            }
        }
    }
}
