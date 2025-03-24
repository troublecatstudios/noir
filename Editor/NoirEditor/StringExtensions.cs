using Newtonsoft.Json.Serialization;

namespace NoirEditor {
    public static class StringExtensions {
        public static string ToCamelCase(this string source) { return new CamelCaseNamingStrategy().GetPropertyName(source, false); }
        public static string ToSnakeCase(this string source) { return new SnakeCaseNamingStrategy().GetPropertyName(source, false); }
    }
}