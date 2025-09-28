using Newtonsoft.Json.Serialization;

namespace NoirEditor {
    public static class StringExtensions {
        /// <summary>
        /// Converts the string casing using a <see cref="CamelCaseNamingStrategy"/>.
        /// </summary>
        /// <param name="source">The string to convert.</param>
        /// <returns>The string, formatted with a camelcase naming format, e.g. <c>myVariableName</c>.</returns>
        public static string ToCamelCase(this string source) => new CamelCaseNamingStrategy().GetPropertyName(source, false);

        /// <summary>
        /// Converts the string casing using a <see cref="SnakeCaseNamingStrategy"/>.
        /// </summary>
        /// <param name="source">The string to convert.</param>
        /// <returns>The string, formatted with a snakecase naming format, e.g. <c>my_variable_name</c>.</returns>
        public static string ToSnakeCase(this string source) => new SnakeCaseNamingStrategy().GetPropertyName(source, false);
    }
}