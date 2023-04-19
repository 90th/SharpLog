using System;
using System.IO;

namespace SharpLog {
    public enum LogLevel {
        Trace,
        Debug,
        Info,
        Warning,
        Error,
        Fatal
    }

    public class SharpLog {
        private readonly string _logFilePath;
        private readonly LogLevel _minimumLogLevel;

        public SharpLog(string logFilePath, LogLevel minimumLogLevel) {
            _logFilePath = logFilePath;
            _minimumLogLevel = minimumLogLevel;
        }

        public void Log(LogLevel logLevel, string message) {
            if (logLevel < _minimumLogLevel) {
                return;
            }

            string logMessage = $"{DateTime.UtcNow} - [{logLevel}] > {message}";

            using (StreamWriter writer = File.AppendText(_logFilePath)) {
                writer.WriteLine(logMessage);
            }
        }

        public void Trace(string message) {
            Log(LogLevel.Trace, message);
        }

        public void Debug(string message) {
            Log(LogLevel.Debug, message);
        }

        public void Info(string message) {
            Log(LogLevel.Info, message);
        }

        public void Warning(string message) {
            Log(LogLevel.Warning, message);
        }

        public void Error(string message) {
            Log(LogLevel.Error, message);
        }

        public void Fatal(string message) {
            Log(LogLevel.Fatal, message);
        }
    }
}
