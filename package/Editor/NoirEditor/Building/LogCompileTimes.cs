/*
 * Copyright (c) 2021 by Hextant Studios. https://HextantStudios.com
 * This work is licensed under CC BY 4.0. http://creativecommons.org/licenses/by/4.0/
 */

using System;
using UnityEditor;
using UnityEditor.Compilation;
using UnityEngine;

namespace NoirEditor.Building {
    /// <summary>
    /// Logs the time taken to perform script compilations and domain reloads.
    /// </summary>
    public sealed class LogCompileTimes : EditorSingleton<LogCompileTimes> {
        [InitializeOnLoadMethod]
        private static void OnLoad() => Initialize();

        private void OnEnable() {
            // Register for script compilation events.
            CompilationPipeline.compilationStarted += OnCompilationStarted;
            CompilationPipeline.compilationFinished += OnCompilationFinished;

            // Register for domain reload events.
            AssemblyReloadEvents.beforeAssemblyReload += OnBeforeAssemblyReload;
            AssemblyReloadEvents.afterAssemblyReload += OnAfterAssemblyReload;
        }

        private void OnDisable() {
            // Unregister for script compilation events.
            CompilationPipeline.compilationStarted -= OnCompilationStarted;
            CompilationPipeline.compilationFinished -= OnCompilationFinished;

            // Unregister for domain reload events.
            AssemblyReloadEvents.beforeAssemblyReload -= OnBeforeAssemblyReload;
            AssemblyReloadEvents.afterAssemblyReload -= OnAfterAssemblyReload;
        }

        private void OnCompilationStarted(object value) => _compilationStart = DateTime.Now.Ticks;

        private void OnCompilationFinished(object value) => _compilationTime = DateTime.Now.Ticks - _compilationStart;

        private void OnBeforeAssemblyReload() => _reloadStart = DateTime.Now.Ticks;

        private void OnAfterAssemblyReload() {
            // Return if the assembly was reloaded before timers were started.
            if (_compilationTime == 0 || _reloadStart == 0) return;

            var compilation = new TimeSpan(_compilationTime);
            var reload = new TimeSpan(DateTime.Now.Ticks - _reloadStart);
            Debug.Log($"Script compilation: {compilation.TotalSeconds:F3}s, Domain reload: {reload.TotalSeconds:F3}s, Total: {(compilation + reload).TotalSeconds:F3}s");
            _compilationTime = 0;
        }

        // The time (in ticks) when the script compilation started.
        private long _compilationStart;

        // The total time (in ticks) taken for script compilation.
        private long _compilationTime;

        // The time (in ticks) when the domain reload started.
        private long _reloadStart;
    }
}