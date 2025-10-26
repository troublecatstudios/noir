using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace NoirEditor.Reflection {
    internal static class TypeExtensions {
        /// <summary>
        /// Retrieves all members (fields and properties) of a specified type that match a given name and binding flags.
        /// </summary>
        /// <param name="type">The Type object to search for members.</param>
        /// <param name="name">The name of the members to search for.</param>
        /// <param name="bindingFlags">A bitmask that specifies how the search for members is conducted. This can be a combination of one or more BindingFlags.</param>
        /// <returns>A list of MemberInfo objects representing the fields and properties that match the specified name and binding flags.</returns>
        public static List<MemberInfo> GetAllMembers(this Type type, string name, BindingFlags bindingFlags) {
            var fields = type.GetFields(bindingFlags);
            var properties = type.GetProperties(bindingFlags);
            var members = fields.Where(field => field.Name == name).Cast<MemberInfo>().ToList();
            members.AddRange(properties.Where(prop => prop.Name == name).Cast<MemberInfo>());
            return members;
        }
    }
}