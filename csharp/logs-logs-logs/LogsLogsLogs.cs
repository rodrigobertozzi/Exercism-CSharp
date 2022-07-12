using System;

enum LogLevel
{
    Trace,
    Debug,
    Info,
    Warning,
    Error,
    Fatal,
    Unknown
}

static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        return (logLine switch
        {
            _ when logLine.Contains("[TRC]") => LogLevel.Trace,
            _ when logLine.Contains("[DBG]") => LogLevel.Debug,
            _ when logLine.Contains("[INF]") => LogLevel.Info,
            _ when logLine.Contains("[WRN]") => LogLevel.Warning,
            _ when logLine.Contains("[ERR]") => LogLevel.Error,
            _ when logLine.Contains("[FTL]") => LogLevel.Fatal,
            _ => LogLevel.Unknown
        });
    }

    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return (logLevel switch
        {
            _ when logLevel.Equals(LogLevel.Trace) => $"1:{message}",
            _ when logLevel.Equals(LogLevel.Debug) => $"2:{message}",
            _ when logLevel.Equals(LogLevel.Info) => $"4:{message}",
            _ when logLevel.Equals(LogLevel.Warning) => $"5:{message}",
            _ when logLevel.Equals(LogLevel.Error) => $"6:{message}",
            _ when logLevel.Equals(LogLevel.Fatal) => $"42:{message}",
            _ => $"0:{message}",
        });
    }
}
