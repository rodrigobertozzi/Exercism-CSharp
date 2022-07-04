using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine[(logLine.IndexOf(':') + 1)..].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string logLevel = logLine.Substring(1, logLine.IndexOf(']') - 1).Trim().ToLower();
        return logLevel;
    }

    public static string Reformat(string logLine)
    {
        string reformat = LogLine.Message(logLine) + " (" + LogLine.LogLevel(logLine) + ")";
        return reformat;
    }

}
