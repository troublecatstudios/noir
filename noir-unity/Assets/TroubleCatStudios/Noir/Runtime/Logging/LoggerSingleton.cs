﻿using System;
using System.Collections.Generic;
using Noir.IO.Paths;

namespace Noir.Logging {
    public sealed class LoggerSingleton {
        private static INoirLogger _writer;

        private static INoirLogger LogWriter {
            get {
                if (_writer == null) {
                    var paths = new PathsFactory().GetPlatformPaths();
                    _writer = new FileLogWriter(paths);
                }
                return _writer;
            }
        }

        private static readonly Dictionary<string, float> _sampleTimes = new Dictionary<string, float>();
        public void Sample(string token, float rate, string message) {
            var shouldLog = false;
            if (!_sampleTimes.ContainsKey(token)) {
                _sampleTimes.Add(token, UnityEngine.Time.time);
                shouldLog = true;
            } else {
                shouldLog = UnityEngine.Time.time - _sampleTimes[token] >= rate;
            }
            if (shouldLog) {
                _sampleTimes[token] = UnityEngine.Time.time;
                Debug($"SAMPLE [{token}] {message}");
            }
        }

        private readonly static LoggerSingleton _instance = new();
        public static LoggerSingleton Instance => _instance;

        private LoggerSingleton() { }

        public void StartTrace(string traceName) => LogWriter.StartTrace(traceName);

        public void EndTrace(string traceName) => LogWriter.EndTrace(traceName);

        public void EndAllTraces() => LogWriter.EndAllTraces();

        public void EnableSubsystem(string system) => LogWriter.EnableSubsystem(system);

        public void DisableSubsystem(string system) => LogWriter.DisableSubsystem(system);

        public void Verify(bool condition, string label, object context = null, string subsystem = null) => LogWriter.Verify(condition, label, context, subsystem);

        public void Verify(Func<bool> condition, string label, object context = null, string subsystem = null) => Verify(condition(), label, context, subsystem);


        public void Info(string message, object context = null, string subsystem = null) => LogWriter.Info(message, context, subsystem);

        public void Trace(string trace, string message, object context = null, string subsystem = null) => LogWriter.Trace(trace, message, context, subsystem);

        public void Debug(string message, object context = null, string subsystem = null) => LogWriter.Debug(message, context, subsystem);

        public void Warn(string message, object context = null, string subsystem = null) => LogWriter.Warn(message, context, subsystem);

        public void Error(string message, object context = null, string subsystem = null) => LogWriter.Error(message, context, subsystem);


        public static void Info<T>(string message, string subsystem = null) => LogWriter.Info(message, typeof(T).FriendlyName(), subsystem);

        public static void Trace<T>(string trace, string message, string subsystem = null) => LogWriter.Trace(trace, message, typeof(T).FriendlyName(), subsystem);

        public static void Debug<T>(string message, string subsystem = null) => LogWriter.Debug(message, typeof(T).FriendlyName(), subsystem);

        public static void Warn<T>(string message, string subsystem = null) => LogWriter.Warn(message, typeof(T).FriendlyName(), subsystem);

        public static void Error<T>(string message, string subsystem = null) => LogWriter.Error(message, typeof(T).FriendlyName(), subsystem);

        public static void Verify<T>(bool condition, string label, string subsystem = null) => LogWriter.Verify(condition, label, typeof(T).FriendlyName(), subsystem);

        public static void Verify<T>(Func<bool> condition, string label, string subsystem = null) => Verify<T>(condition(), label, subsystem);


        public void WriteLog(string message, LogLevel level = LogLevel.Info, object context = null, string subsystem = null, string trace = null) => LogWriter.WriteLog(message, level, context, subsystem, trace);
    }
}