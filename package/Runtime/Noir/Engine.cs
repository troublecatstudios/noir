using Noir.Abstractions;
using Noir.Attributes;
using Noir.Configuration;
using Noir.DataObjects;
using Noir.Events;
using Noir.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Noir {
    /// <summary>
    /// Initializes core features of the Noir Library
    /// </summary>
    /// <remarks>
    /// <para>
    /// The Noir engine can invoke methods within developer's game code at specific points during the startup lifecycle.
    /// </para>
    /// <para>
    /// Initialize is invoked during the <see cref="RuntimeInitializeLoadType.SubsystemRegistration">SubSystemRegistration</see> phase of the UnityEngine initialization lifecycle.
    /// </para>
    /// <para>
    /// ConfigureServices is invoked after all the assemblies have been loaded by the UnityEngine. Developer's can utilize
    /// this callback to register types and instances with Noir's <see cref="ServiceLocator"/>.
    /// </para>
    /// <para>
    /// Start is invoked after all the first Scene has been loaded by Unity.
    /// </para>
    /// <para>
    /// Noir engine callbacks are global, the library performs a scan of the loaded assemblies at startup, looking for
    /// all the static members that are decorated with a <see cref="EngineCallbackAttribute"/>.
    /// </para>
    /// </remarks>
    public sealed class Engine {
        private static readonly List<MethodInfo> _callbackMethods = new();
        static Engine() {
            foreach (var asm in AppDomain.CurrentDomain.GetAssemblies()) {
                var methods = asm.GetTypes()
                    .SelectMany(t => t.GetMethods())
                    .Where(m => m.GetCustomAttributes(typeof(EngineCallbackAttribute), false).Length > 0 && m.IsStatic)
                    .ToArray();
                _callbackMethods.AddRange(methods);
            }
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void Initialize() {
            LoggerSingleton.Info<Engine>($"Initializing engine.");
            InvokeEngineCallback(EngineCallbackType.Initialize);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void ConfigureServices() {
            ServiceLocator.RegisterService(new GameTime());
            ServiceLocator.RegisterService<IGameTime, GameTime>();
            ServiceLocator.RegisterService(() => NoirDataLibrary.Instance);
            ServiceLocator.RegisterService<INoirEventDispatcher>(() => NoirEventManager.Instance);
            ServiceLocator.RegisterService<INoirEventRegistry>(() => NoirEventManager.Instance);

            LoggerSingleton.Info<Engine>($"Essential services registered. Engine configured.");

            InvokeEngineCallback(EngineCallbackType.ConfigureServices);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Start() {
            SetTargetFramerate();
            InvokeEngineCallback(EngineCallbackType.Start);
            LoggerSingleton.Info<Engine>($"Engine started.");
        }

        private static void SetTargetFramerate() {
            var settings = ServiceLocator.GetService<INoirProjectConfigurationAccessor>().GetProjectConfiguration();
            if (settings.IsFramerateLocked) {
                Application.targetFrameRate = settings.LockedFrameRate;
                LoggerSingleton.Info<Engine>($"Start setting target framerate. fps={Application.targetFrameRate}");
            }
        }

        private static void InvokeEngineCallback(EngineCallbackType type) {
#if UNITY_EDITOR
            Debug.Log($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= {type.ToString().ToUpper()} -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
#endif
            foreach (var method in _callbackMethods) {
                var attributes = method.GetCustomAttributes(typeof(EngineCallbackAttribute), false);
                if (attributes.Length == 0) continue;
                if (attributes[0] is not EngineCallbackAttribute attr || attr.CallbackType != type) continue;
                LoggerSingleton.Debug<Engine>($"Invoking engine callback type={type}, assembly={method.DeclaringType?.Assembly.FullName}, name={method.DeclaringType?.FullName}.{method.Name}");
                method.Invoke(null, null);
            }
        }
    }
}