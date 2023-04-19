# SharpLog
 C# Lightweight logger.


```
using SharpLog;
using System;

namespace SharpLogDemo {
    class Program {
        static void Main(string[] args) {
            SharpLog.SharpLog logger = new SharpLog.SharpLog("log.txt", SharpLog.LogLevel.Trace);

            logger.Trace("This is a trace message6");
            logger.Debug("This is a debug message5");
            logger.Info("This is an info message4");
            logger.Warning("This is a warning message3");
            logger.Error("This is an error message2");
            logger.Fatal("This is a fatal message1");
            Console.WriteLine("Log messages written to log.txt");

        }
    }
}

```