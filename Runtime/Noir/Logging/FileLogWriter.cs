﻿using System;
using System.Collections.Generic;
using Noir.IO;
using Noir.IO.Paths;
using UnityEngine;

namespace Noir.Logging {
    public class FileLogWriter : INoirLogger {
        private readonly Dictionary<string, bool> _subsystemDictionary = new Dictionary<string, bool>();
        private bool _isTraceMode = false;
        private readonly List<string> _activeTraces = new List<string>();
        private readonly string _absoluteLogFilePath = "";

        private static string LogFileName => $"{DateTime.Now:yyyy-MM-dd}_noir.log";

#if UNITY_EDITOR
        private static string LogMessageTime => $"[{Time.realtimeSinceStartup}]";
#else
        private static string LogMessageTime => $"{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
#endif


        public FileLogWriter(IPlatformPaths paths) {
            _absoluteLogFilePath = $"{paths.LogDirectory}/{LogFileName}";
        }

        public void DisableSubsystem(string system) {
            _subsystemDictionary.Remove(system);
        }

        public void EnableSubsystem(string system) {
            if (!_subsystemDictionary.ContainsKey(system)) {
                _subsystemDictionary.Add(system, true);
            }
            _subsystemDictionary[system] = true;
        }

        public void EndAllTraces() {
            WriteLog($"Ending all traces", LogLevel.Debug);
            _activeTraces.Clear();
            _isTraceMode = false;
        }

        public void EndTrace(string traceName) {
            _activeTraces.Remove(traceName);
            WriteLog($"Ending trace: {traceName}", LogLevel.Debug);
            if (_activeTraces.Count == 0) {
                _isTraceMode = false;
            }
        }

        public void StartTrace(string traceName) {
            if (!_activeTraces.Contains(traceName)) {
                _activeTraces.Add(traceName);
                _isTraceMode = true;
                WriteLog($"Starting trace: {traceName}", LogLevel.Debug);
            }
        }

        public void Verify(bool condition, string label, object context = null, string subsystem = null) {
            if (condition) {
                // Debug($"[VERIFY] [PASS] {label}", context, subsystem);
                return;
            }
            Error($"[VERIFY] [FAIL] {label}", context, subsystem);
        }

        public void Verify(Func<bool> condition, string label, object context = null, string subsystem = null) => Verify(condition(), label, context, subsystem);

        public void Debug(string message, object context = null, string subsystem = null) => WriteLog(message, level: LogLevel.Debug, context: context, subsystem: subsystem);
        public void Error(string message, object context = null, string subsystem = null) => WriteLog(message, level: LogLevel.Error, context: context, subsystem: subsystem);
        public void Info(string message, object context = null, string subsystem = null) => WriteLog(message, level: LogLevel.Info, context: context, subsystem: subsystem);
        public void Trace(string trace, string message, object context = null, string subsystem = null) => WriteLog(message, level: LogLevel.Verbose, context: context, subsystem: subsystem, trace: trace);
        public void Warn(string message, object context = null, string subsystem = null) => WriteLog(message, level: LogLevel.Warn, context: context, subsystem: subsystem);
        public void WriteLog(string message, LogLevel level = LogLevel.Info, object context = null, string subsystem = null, string trace = null) {
            var traceHasValue = !string.IsNullOrEmpty(trace);
            if (_isTraceMode && (traceHasValue && !IsTraceActive(trace))) {
                return;
            }
            if (!_isTraceMode && traceHasValue) {
                return;
            }
            var component = "UNKNOWN";
            if (context is Type t) {
                component = t.Name ?? "UNKNOWN";
            } else if (context is string s) {
                component = s ?? "UNKNOWN";
            } else {
                component = context?.GetType()?.Name ?? "UNKNOWN";
            }

            UnityEngine.Object contextObject = null;
            if (context is UnityEngine.Object obj) {
                contextObject = obj;
            }
            var sub = string.IsNullOrEmpty(subsystem) ? "" : $"[{subsystem}]";
            var trc = string.IsNullOrEmpty(trace) ? "" : $" TRACE={trace}";
            var log = $"{LogMessageTime} {ConvertLogLevel(level)} {Time.frameCount} [{component}]{sub}{trc} {message}";

#if UNITY_EDITOR
            if (!Application.isBatchMode) {
                switch (level) {
                    case LogLevel.Verbose:
                    case LogLevel.Debug:
                    case LogLevel.Info:
                        if (contextObject == null) UnityEngine.Debug.Log(log);
                        else UnityEngine.Debug.Log(log, contextObject);
                        break;
                    case LogLevel.Warn:
                        if (contextObject == null) UnityEngine.Debug.LogWarning(log);
                        else UnityEngine.Debug.LogWarning(log, contextObject);
                        break;
                    case LogLevel.Error:
                        if (contextObject == null) UnityEngine.Debug.LogError(log);
                        else UnityEngine.Debug.LogError(log, contextObject);
                        break;
                }
            }
#endif
            // TODO [#166]: optimize this to buffer writes
            NoirFile.Write(log, _absoluteLogFilePath);
        }

        private bool IsSubsystemActive(string subsystem) {
            if (string.IsNullOrEmpty(subsystem)) return false;
            return _subsystemDictionary.ContainsKey(subsystem) && _subsystemDictionary[subsystem];
        }

        private bool IsTraceActive(string traceName) => _isTraceMode && _activeTraces.Contains(traceName);

        private static string ConvertLogLevel(LogLevel level) {
            switch (level) {
                case LogLevel.Debug: return "DEBUG";
                case LogLevel.Error: return "ERROR";
                case LogLevel.Warn: return "WARN";
                case LogLevel.Verbose: return "VERBOSE";
                case LogLevel.Info:
                default: return "INFO";
            }
        }
    }
}