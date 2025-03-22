using Noir.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEngine;

namespace Noir {
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
            // LoggerSingleton.Info<Engine>($"Initializing engine.");
            InvokeEngineCallback(EngineCallbackType.Initialize);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
        private static void ConfigureServices() {
            // ServiceLocator.RegisterService(new GameTime());
            // ServiceLocator.RegisterService(() => NoirDataLibrary.Instance);
            // ServiceLocator.RegisterService<INoirEventDispatcher>(() => NoirEventManager.Instance);
            // ServiceLocator.RegisterService<INoirEventRegistry>(() => NoirEventManager.Instance);
            // ServiceLocator.RegisterService<IJobManager>(new JobManager());
            //
            // LoggerSingleton.Info<Engine>($"Essential services registered. Engine configured.");

            InvokeEngineCallback(EngineCallbackType.ConfigureServices);
        }

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        private static void Start() {
            SetTargetFramerate();
            InvokeEngineCallback(EngineCallbackType.Start);
            // LoggerSingleton.Info<Engine>($"Engine started.");
        }

        private static void InitializeConsole() {
            // NoirConsole.IsOpen = false;
        }

        private static void SetTargetFramerate() {
            // var settings = ServiceLocator.GetService<INoirProjectSettingsAccessor>().GetProjectSettings();
            // if (settings.IsFramerateLocked) {
            //     Application.targetFrameRate = settings.LockedFrameRate;
            //     LoggerSingleton.Info<Engine>($"Start setting target framerate. fps={Application.targetFrameRate}");
            // }
        }

        private static void InvokeEngineCallback(EngineCallbackType type) {
#if UNITY_EDITOR
            Debug.Log($"-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-= {type.ToString().ToUpper()} -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
#endif
            foreach (var method in _callbackMethods) {
                var attributes = method.GetCustomAttributes(typeof(EngineCallbackAttribute), false);
                if (attributes.Length == 0) continue;
                if (attributes[0] is not EngineCallbackAttribute attr || attr.CallbackType != type) continue;
                // LoggerSingleton.Debug<Engine>($"Invoking engine callback type={type}, assembly={method.DeclaringType?.Assembly.FullName}, name={method.DeclaringType?.FullName}.{method.Name}");
                method.Invoke(null, null);
            }
        }
    }
}