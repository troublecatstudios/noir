using Noir.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using UnityEngine;

namespace Noir.Serialization.Json {
    public static class UnityConverterInitializer {

        public static JsonSerializerSettings defaultUnityConvertersSettings { get; set; } = CreateJsonSettingsWithFreslyLoadedConfig();

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
#pragma warning disable IDE0051 // Remove unused private members
#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#endif
        internal static void Init()
#pragma warning restore IDE0051 // Remove unused private members
        {
            UpdateDefaultSettings();
        }

        private static void UpdateDefaultSettings()
        {
            if (JsonConvert.DefaultSettings == null) {
                JsonConvert.DefaultSettings = GetExistingDefaultUnitySettings;
            }
        }

        internal static JsonSerializerSettings GetExistingDefaultUnitySettings()
        {
            return defaultUnityConvertersSettings;
        }

        private static JsonSerializerSettings CreateJsonSettingsWithFreslyLoadedConfig()
        {
            var settings = new JsonSerializerSettings {
                Converters = CreateConverters(),
                ContractResolver = new UnityTypeContractResolver(),
            };
            return settings;
        }

        /// <summary>
        /// Create the converter instances.
        /// </summary>
        /// <returns>The converters.</returns>
        internal static List<JsonConverter> CreateConverters()
        {
            var reflectedConverters = FindConverters();

            var result = new List<JsonConverter>();
            result.AddRange(reflectedConverters.Select(CreateConverter));
            return result;
        }

        /// <summary>
        /// Finds all the valid converter types inside the <c>Newtonsoft.Json</c> assembly.
        /// </summary>
        /// <returns>The types.</returns>
        internal static IEnumerable<Type> FindConverters()
        {
#if UNITY_2019_2_OR_NEWER && UNITY_EDITOR
            var types = UnityEditor.TypeCache.GetTypesDerivedFrom<JsonConverter>();
#else
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(dll => dll.GetLoadableTypes());
#endif
            return FilterToJsonConvertersAndOrder(types);
        }

        private static IEnumerable<Type> FilterToJsonConvertersAndOrder(IEnumerable<Type> types)
        {
            return types
                .Where(type
                    => typeof(JsonConverter).IsAssignableFrom(type)
                    && !type.IsAbstract && !type.IsGenericTypeDefinition
                    && type.GetConstructor(Array.Empty<Type>()) != null
                )
                .OrderBy(type => type.FullName);
        }

        /// <summary>
        /// Try to create the converter of specified type.
        /// </summary>
        /// <returns>The converter.</returns>
        /// <param name="jsonConverterType">Type.</param>
        [return: MaybeNull]
        private static JsonConverter CreateConverter(Type jsonConverterType)
        {
            try
            {
                return (JsonConverter)Activator.CreateInstance(jsonConverterType);
            }
            catch (Exception exception)
            {
                Debug.LogErrorFormat("Cannot create JsonConverter '{0}':\n{1}", jsonConverterType?.FullName, exception);
            }

            return null;
        }
    }
}
